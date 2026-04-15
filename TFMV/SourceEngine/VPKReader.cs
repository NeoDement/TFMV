using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TFMV.SourceEngine
{
    /// <summary>
    /// Native VPK archive reader. Parses the directory tree from _dir.vpk
    /// and reads file data from the associated _NNN.vpk archive files.
    /// Supports VPK v1 and v2.
    /// </summary>
    public class VPKReader : IDisposable
    {
        private const uint VPK_SIGNATURE = 0x55AA1234;

        private string _dirPath;       // full path to the _dir.vpk file
        private string _basePath;      // path without _dir.vpk suffix
        private int _version;
        private uint _treeSize;
        private long _dataOffset;      // offset where embedded file data starts (for ArchiveIndex 0x7fff)

        // lookup: "path/filename.ext" -> entry info
        private Dictionary<string, VPKEntry> _entries = new Dictionary<string, VPKEntry>(StringComparer.OrdinalIgnoreCase);

        // cache of opened archive file streams
        private Dictionary<int, FileStream> _archiveStreams = new Dictionary<int, FileStream>();
        private FileStream _dirStream;

        public struct VPKEntry
        {
            public uint CRC;
            public ushort PreloadBytes;
            public ushort ArchiveIndex;
            public uint EntryOffset;
            public uint EntryLength;
            public byte[] PreloadData;
        }

        public int EntryCount { get { return _entries.Count; } }

        /// <summary>
        /// Opens and parses a VPK directory file (e.g. tf2_textures_dir.vpk).
        /// </summary>
        public VPKReader(string dirVpkPath)
        {
            if (!File.Exists(dirVpkPath))
                throw new FileNotFoundException("VPK directory file not found: " + dirVpkPath);

            _dirPath = dirVpkPath;

            // derive base path: "tf2_textures_dir.vpk" -> "tf2_textures"
            string filename = Path.GetFileNameWithoutExtension(dirVpkPath); // "tf2_textures_dir"
            if (filename.EndsWith("_dir"))
                filename = filename.Substring(0, filename.Length - 4);
            _basePath = Path.Combine(Path.GetDirectoryName(dirVpkPath), filename);

            _dirStream = new FileStream(dirVpkPath, FileMode.Open, FileAccess.Read, FileShare.Read);
            using (BinaryReader reader = new BinaryReader(_dirStream, Encoding.ASCII, leaveOpen: true))
            {
                ReadHeader(reader);
                ReadTree(reader);
            }
        }

        private void ReadHeader(BinaryReader reader)
        {
            uint sig = reader.ReadUInt32();
            if (sig != VPK_SIGNATURE)
                throw new InvalidDataException("Not a VPK file (bad signature)");

            _version = (int)reader.ReadUInt32();
            _treeSize = reader.ReadUInt32();

            if (_version == 2)
            {
                // skip v2-specific header fields
                reader.ReadUInt32(); // FileDataSectionSize
                reader.ReadUInt32(); // ArchiveMD5SectionSize
                reader.ReadUInt32(); // OtherMD5SectionSize
                reader.ReadUInt32(); // SignatureSectionSize
            }

            // data for ArchiveIndex 0x7fff starts right after header + tree
            int headerSize = (_version == 1) ? 12 : 28;
            _dataOffset = headerSize + _treeSize;
        }

        private void ReadTree(BinaryReader reader)
        {
            while (true)
            {
                string extension = ReadNullString(reader);
                if (extension == "") break;

                while (true)
                {
                    string path = ReadNullString(reader);
                    if (path == "") break;

                    while (true)
                    {
                        string filename = ReadNullString(reader);
                        if (filename == "") break;

                        // read VPKDirectoryEntry
                        VPKEntry entry;
                        entry.CRC = reader.ReadUInt32();
                        entry.PreloadBytes = reader.ReadUInt16();
                        entry.ArchiveIndex = reader.ReadUInt16();
                        entry.EntryOffset = reader.ReadUInt32();
                        entry.EntryLength = reader.ReadUInt32();
                        ushort terminator = reader.ReadUInt16(); // should be 0xFFFF

                        // read preload data if present
                        if (entry.PreloadBytes > 0)
                        {
                            entry.PreloadData = reader.ReadBytes(entry.PreloadBytes);
                        }
                        else
                        {
                            entry.PreloadData = null;
                        }

                        // build full path key
                        string fullPath;
                        if (path == " ")
                            fullPath = filename + "." + extension;
                        else
                            fullPath = path + "/" + filename + "." + extension;

                        _entries[fullPath] = entry;
                    }
                }
            }
        }

        private static string ReadNullString(BinaryReader reader)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                byte b = reader.ReadByte();
                if (b == 0) return sb.ToString();
                sb.Append((char)b);
            }
        }

        /// <summary>
        /// Checks if a file exists in the VPK.
        /// </summary>
        public bool FileExists(string path)
        {
            return _entries.ContainsKey(path.Replace("\\", "/"));
        }

        /// <summary>
        /// Reads a file's complete data from the VPK archives.
        /// Returns null if file not found.
        /// </summary>
        public byte[] ReadFile(string path)
        {
            path = path.Replace("\\", "/");
            VPKEntry entry;
            if (!_entries.TryGetValue(path, out entry))
                return null;

            int totalSize = entry.PreloadBytes + (int)entry.EntryLength;
            byte[] data = new byte[totalSize];
            int offset = 0;

            // copy preload data
            if (entry.PreloadBytes > 0 && entry.PreloadData != null)
            {
                Buffer.BlockCopy(entry.PreloadData, 0, data, 0, entry.PreloadBytes);
                offset = entry.PreloadBytes;
            }

            // read archive data
            if (entry.EntryLength > 0)
            {
                if (entry.ArchiveIndex == 0x7FFF)
                {
                    // data is embedded in the directory file
                    _dirStream.Seek(_dataOffset + entry.EntryOffset, SeekOrigin.Begin);
                    _dirStream.Read(data, offset, (int)entry.EntryLength);
                }
                else
                {
                    // data is in an external archive file
                    FileStream archiveStream = GetArchiveStream(entry.ArchiveIndex);
                    archiveStream.Seek(entry.EntryOffset, SeekOrigin.Begin);
                    archiveStream.Read(data, offset, (int)entry.EntryLength);
                }
            }

            return data;
        }

        /// <summary>
        /// Returns all file paths matching a prefix (e.g. "materials/backpack/").
        /// </summary>
        public List<string> FindFiles(string pathPrefix)
        {
            pathPrefix = pathPrefix.Replace("\\", "/");
            List<string> results = new List<string>();
            foreach (var key in _entries.Keys)
            {
                if (key.StartsWith(pathPrefix, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(key);
                }
            }
            return results;
        }

        private FileStream GetArchiveStream(int archiveIndex)
        {
            FileStream stream;
            if (!_archiveStreams.TryGetValue(archiveIndex, out stream))
            {
                string archivePath = _basePath + "_" + archiveIndex.ToString("D3") + ".vpk";
                if (!File.Exists(archivePath))
                    throw new FileNotFoundException("VPK archive not found: " + archivePath);

                stream = new FileStream(archivePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                _archiveStreams[archiveIndex] = stream;
            }
            return stream;
        }

        public void Dispose()
        {
            if (_dirStream != null)
            {
                _dirStream.Dispose();
                _dirStream = null;
            }
            foreach (var stream in _archiveStreams.Values)
            {
                stream.Dispose();
            }
            _archiveStreams.Clear();
        }
    }
}
