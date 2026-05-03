using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TFMV.SourceEngine
{
    public static class VPK
    {

        public static string tf_dir, tf2_dir;

        //converts long paths to short paths, for "dos" console commands
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)] public static extern int GetShortPathName(
        [MarshalAs(UnmanagedType.LPTStr)] string path,
        [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath, int shortPathLength);

        private static string tools_dir { get { return Main.tools_dir; } }
        private static string app_data_dir { get { return Main.app_data_dir; } }
        private static string tmp_dir { get { return Main.tmp_dir; } }


        //gets tf/steam cpaths from the main form
        public static void set_tf_paths(string tf, string tf2)
        {
            tf_dir = tf; tf2_dir = tf2;
        }


        //check if vpk.exe exists
        public static bool vpk_tool_check()
        {
            bool result = true;

            if (File.Exists(tf2_dir + "bin/vpk.exe") == false)
            {
                MessageBox.Show("Error: " + tf2_dir + "bin/vpk.exe is missing! \n SDK Tools are needed to extract from the game VPKs.");
                result = false;
            }

            return result;
        }

        //for skins or workshop skins dragged and dropped into TFMV
        public static bool Extract_ALL(string vpk_file, string extract_dir)
        {

            if (File.Exists(tf2_dir + "bin/vpk.exe") == false)
            {
                MessageBox.Show("Error: " + tf2_dir + "bin/vpk.exe is missing! \n SDK Tools are needed to extract from the game VPKs.");
                return false;
            }

            //create temporary directory if it doesn't exist
            if (Directory.Exists(tmp_dir) == false) { Directory.CreateDirectory(tmp_dir); }

            extract_dir = extract_dir.Replace("\\", "/");

            if (Directory.Exists(extract_dir) == false) { Directory.CreateDirectory(extract_dir); }

            StringBuilder shortPath = new StringBuilder(512);
            GetShortPathName(@extract_dir, shortPath, shortPath.Capacity);
            @extract_dir = shortPath.ToString();


            StringBuilder shortPath1 = new StringBuilder(512);
            GetShortPathName(vpk_file, shortPath1, shortPath1.Capacity);
            vpk_file = shortPath1.ToString();

            string args = vpk_file;


            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = extract_dir, // + "team fortress 2\\tf\\",
                    FileName = tf2_dir + "bin/vpk.exe",
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();

            //get process output to check for errors
            while (!proc.StandardOutput.EndOfStream)
            {
                string str = proc.StandardOutput.ReadLine();

                // if (str.Contains("not found in package"))
                // {
                // MessageBox.Show("Error extracting from VPK: file " + file_path + " not found in the VPK!");
                // }
            }
            return true;

        }


        //Extract file from gcf...
        public static bool Extract(string file_path, string extract_path, int vpk_selection)
        {
            if (string.IsNullOrEmpty(file_path) || string.IsNullOrEmpty(extract_path)) { return false; }

            // 0 = tf2_misc_dir.vpk (models, vmts, pcf...) — 1 = tf2_textures_dir.vpk (VTFs only)
            string vpk_file = (vpk_selection == 1) ? "tf2_textures_dir.vpk" : "tf2_misc_dir.vpk";
            string vpk_path = tf_dir + vpk_file;
            if (!File.Exists(vpk_path)) { return false; }

            try
            {
                if (!Directory.Exists(extract_path)) { Directory.CreateDirectory(extract_path); }

                using (var vpk = new VPKReader(vpk_path))
                {
                    if (!vpk.FileExists(file_path)) { return false; }
                    byte[] data = vpk.ReadFile(file_path);
                    string out_file = Path.Combine(extract_path, Path.GetFileName(file_path));
                    File.WriteAllBytes(out_file, data);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        //Validate that a file exists inside one of the TF2 VPK archives
        public static bool Find(string path, int vpk_selection)
        {
            if (string.IsNullOrEmpty(path)) { return false; }

            string vpk_file = (vpk_selection == 1) ? "tf2_textures_dir.vpk" : "tf2_misc_dir.vpk";
            string vpk_path = tf_dir + vpk_file;
            if (!File.Exists(vpk_path)) { return false; }

            try
            {
                using (var vpk = new VPKReader(vpk_path))
                {
                    return vpk.FileExists(path);
                }
            }
            catch
            {
                return false;
            }
        }


    }
}
