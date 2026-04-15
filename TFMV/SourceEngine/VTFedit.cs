using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace TFMV.SourceEngine
{
    // reads/writes VTF texture files for bodygroup transparency masking
    class VTFedit
    {

        // VTF format constants
        private const int VTF_OFFSET_HEADER_SIZE = 12;
        private const int VTF_OFFSET_WIDTH = 16;
        private const int VTF_OFFSET_HEIGHT = 18;
        private const int VTF_OFFSET_FLAGS = 20;
        private const int VTF_OFFSET_FORMAT = 52;
        private const int VTF_OFFSET_MIPCOUNT = 56;
        private const int VTF_FORMAT_BGRA8888 = 12;
        private const int VTF_FORMAT_DXT1 = 13;
        private const int VTF_FORMAT_DXT5 = 15;
        private const uint VTF_FLAG_EIGHTBITALPHA = 0x00002000;

        /// <summary>
        /// Decodes DXT1 color block endpoints into R,G,B values.
        /// DXT1 stores two 16-bit colors as RGB565.
        /// </summary>
        private void decode_rgb565(ushort c, out byte r, out byte g, out byte b)
        {
            r = (byte)((c >> 11) * 255 / 31);
            g = (byte)(((c >> 5) & 0x3F) * 255 / 63);
            b = (byte)((c & 0x1F) * 255 / 31);
        }

        /// <summary>
        /// Decodes a single DXT1 4x4 block into BGRA8888 pixel data.
        /// Writes 4*4*4 = 64 bytes into dst at the correct pixel positions for the given block coords.
        /// </summary>
        private void decode_dxt1_block(byte[] src, int src_offset, byte[] dst, int dst_stride, int block_x, int block_y, int img_width, int img_height)
        {
            ushort c0 = BitConverter.ToUInt16(src, src_offset);
            ushort c1 = BitConverter.ToUInt16(src, src_offset + 2);
            uint indices = BitConverter.ToUInt32(src, src_offset + 4);

            byte r0, g0, b0, r1, g1, b1;
            decode_rgb565(c0, out r0, out g0, out b0);
            decode_rgb565(c1, out r1, out g1, out b1);

            // build color palette
            byte[][] colors = new byte[4][];
            colors[0] = new byte[] { b0, g0, r0 }; // BGRA order
            colors[1] = new byte[] { b1, g1, r1 };
            if (c0 > c1)
            {
                colors[2] = new byte[] { (byte)((2 * b0 + b1 + 1) / 3), (byte)((2 * g0 + g1 + 1) / 3), (byte)((2 * r0 + r1 + 1) / 3) };
                colors[3] = new byte[] { (byte)((b0 + 2 * b1 + 1) / 3), (byte)((g0 + 2 * g1 + 1) / 3), (byte)((r0 + 2 * r1 + 1) / 3) };
            }
            else
            {
                colors[2] = new byte[] { (byte)((b0 + b1) / 2), (byte)((g0 + g1) / 2), (byte)((r0 + r1) / 2) };
                colors[3] = new byte[] { 0, 0, 0 };
            }

            for (int py = 0; py < 4; py++)
            {
                int y = block_y * 4 + py;
                if (y >= img_height) continue;
                for (int px = 0; px < 4; px++)
                {
                    int x = block_x * 4 + px;
                    if (x >= img_width) continue;
                    int idx = (int)((indices >> (2 * (py * 4 + px))) & 0x3);
                    int dst_offset = y * dst_stride + x * 4;
                    dst[dst_offset] = colors[idx][0];     // B
                    dst[dst_offset + 1] = colors[idx][1]; // G
                    dst[dst_offset + 2] = colors[idx][2]; // R
                    dst[dst_offset + 3] = 255;            // A (opaque)
                }
            }
        }

        /// <summary>
        /// Decodes a single DXT5 4x4 block (16 bytes) into BGRA8888 pixel data.
        /// DXT5 = 8 bytes alpha + 8 bytes color (same color block as DXT1).
        /// </summary>
        private void decode_dxt5_block(byte[] src, int src_offset, byte[] dst, int dst_stride, int block_x, int block_y, int img_width, int img_height)
        {
            // --- alpha block (8 bytes) ---
            byte alpha0 = src[src_offset];
            byte alpha1 = src[src_offset + 1];

            // 48-bit alpha index table (6 bytes, 3 bits per pixel)
            ulong alphaBits = 0;
            for (int j = 0; j < 6; j++)
                alphaBits |= (ulong)src[src_offset + 2 + j] << (8 * j);

            byte[] alphaTable = new byte[8];
            alphaTable[0] = alpha0;
            alphaTable[1] = alpha1;
            if (alpha0 > alpha1)
            {
                alphaTable[2] = (byte)((6 * alpha0 + 1 * alpha1 + 3) / 7);
                alphaTable[3] = (byte)((5 * alpha0 + 2 * alpha1 + 3) / 7);
                alphaTable[4] = (byte)((4 * alpha0 + 3 * alpha1 + 3) / 7);
                alphaTable[5] = (byte)((3 * alpha0 + 4 * alpha1 + 3) / 7);
                alphaTable[6] = (byte)((2 * alpha0 + 5 * alpha1 + 3) / 7);
                alphaTable[7] = (byte)((1 * alpha0 + 6 * alpha1 + 3) / 7);
            }
            else
            {
                alphaTable[2] = (byte)((4 * alpha0 + 1 * alpha1 + 2) / 5);
                alphaTable[3] = (byte)((3 * alpha0 + 2 * alpha1 + 2) / 5);
                alphaTable[4] = (byte)((2 * alpha0 + 3 * alpha1 + 2) / 5);
                alphaTable[5] = (byte)((1 * alpha0 + 4 * alpha1 + 2) / 5);
                alphaTable[6] = 0;
                alphaTable[7] = 255;
            }

            // --- color block (8 bytes at src_offset+8), same as DXT1 ---
            int color_offset = src_offset + 8;
            ushort c0 = BitConverter.ToUInt16(src, color_offset);
            ushort c1 = BitConverter.ToUInt16(src, color_offset + 2);
            uint indices = BitConverter.ToUInt32(src, color_offset + 4);

            byte r0, g0, b0, r1, g1, b1;
            decode_rgb565(c0, out r0, out g0, out b0);
            decode_rgb565(c1, out r1, out g1, out b1);

            byte[][] colors = new byte[4][];
            colors[0] = new byte[] { b0, g0, r0 };
            colors[1] = new byte[] { b1, g1, r1 };
            colors[2] = new byte[] { (byte)((2 * b0 + b1 + 1) / 3), (byte)((2 * g0 + g1 + 1) / 3), (byte)((2 * r0 + r1 + 1) / 3) };
            colors[3] = new byte[] { (byte)((b0 + 2 * b1 + 1) / 3), (byte)((g0 + 2 * g1 + 1) / 3), (byte)((r0 + 2 * r1 + 1) / 3) };

            for (int py = 0; py < 4; py++)
            {
                int y = block_y * 4 + py;
                if (y >= img_height) continue;
                for (int px = 0; px < 4; px++)
                {
                    int x = block_x * 4 + px;
                    if (x >= img_width) continue;

                    int colorIdx = (int)((indices >> (2 * (py * 4 + px))) & 0x3);
                    int alphaIdx = (int)((alphaBits >> (3 * (py * 4 + px))) & 0x7);

                    int dst_offset = y * dst_stride + x * 4;
                    dst[dst_offset] = colors[colorIdx][0];       // B
                    dst[dst_offset + 1] = colors[colorIdx][1];   // G
                    dst[dst_offset + 2] = colors[colorIdx][2];   // R
                    dst[dst_offset + 3] = alphaTable[alphaIdx];  // A
                }
            }
        }

        /// <summary>
        /// Converts a DXT1 VTF to uncompressed BGRA8888 format.
        /// Decodes all mipmap levels from DXT1 blocks to raw pixels.
        /// Zero quality loss — pixel-perfect reproduction of the DXT1 decoded colors.
        /// </summary>
        public byte[] convert_dxt1_to_bgra8888(byte[] vtf_bytes)
        {
            int format = BitConverter.ToInt32(vtf_bytes, VTF_OFFSET_FORMAT);
            ushort width = BitConverter.ToUInt16(vtf_bytes, VTF_OFFSET_WIDTH);
            ushort height = BitConverter.ToUInt16(vtf_bytes, VTF_OFFSET_HEIGHT);
            byte mip_count = vtf_bytes[VTF_OFFSET_MIPCOUNT];

            if (format != VTF_FORMAT_DXT1)
            {
                return vtf_bytes;
            }

            // calculate total DXT1 and BGRA8888 sizes for all mipmaps
            int dxt1_total = 0;
            int bgra_total = 0;
            int[] dxt1_mip_sizes = new int[mip_count];
            int[] bgra_mip_sizes = new int[mip_count];
            int[] mip_widths = new int[mip_count];
            int[] mip_heights = new int[mip_count];
            int mw = width, mh = height;
            for (int m = 0; m < mip_count; m++)
            {
                int bw = Math.Max(1, (mw + 3) / 4);
                int bh = Math.Max(1, (mh + 3) / 4);
                dxt1_mip_sizes[m] = bw * bh * 8;
                bgra_mip_sizes[m] = Math.Max(1, mw) * Math.Max(1, mh) * 4;
                mip_widths[m] = Math.Max(1, mw);
                mip_heights[m] = Math.Max(1, mh);
                dxt1_total += dxt1_mip_sizes[m];
                bgra_total += bgra_mip_sizes[m];
                mw = Math.Max(1, mw / 2);
                mh = Math.Max(1, mh / 2);
            }

            int dxt1_data_start = vtf_bytes.Length - dxt1_total;

            // build new file: header/pre-data + BGRA pixel data
            byte[] new_vtf = new byte[dxt1_data_start + bgra_total];
            Array.Copy(vtf_bytes, 0, new_vtf, 0, dxt1_data_start);

            // decode each mip level (stored smallest-first in file)
            int src_pos = dxt1_data_start;
            int dst_pos = dxt1_data_start;
            for (int m = mip_count - 1; m >= 0; m--)
            {
                int w = mip_widths[m];
                int h = mip_heights[m];
                int stride = w * 4;
                byte[] pixels = new byte[bgra_mip_sizes[m]];

                int blocks_x = Math.Max(1, (w + 3) / 4);
                int blocks_y = Math.Max(1, (h + 3) / 4);

                for (int by = 0; by < blocks_y; by++)
                {
                    for (int bx = 0; bx < blocks_x; bx++)
                    {
                        decode_dxt1_block(vtf_bytes, src_pos, pixels, stride, bx, by, w, h);
                        src_pos += 8;
                    }
                }

                Array.Copy(pixels, 0, new_vtf, dst_pos, bgra_mip_sizes[m]);
                dst_pos += bgra_mip_sizes[m];
            }

            // update header: format to BGRA8888, add EIGHTBITALPHA flag
            Array.Copy(BitConverter.GetBytes(VTF_FORMAT_BGRA8888), 0, new_vtf, VTF_OFFSET_FORMAT, 4);
            uint flags = BitConverter.ToUInt32(new_vtf, VTF_OFFSET_FLAGS);
            flags |= VTF_FLAG_EIGHTBITALPHA;
            Array.Copy(BitConverter.GetBytes(flags), 0, new_vtf, VTF_OFFSET_FLAGS, 4);

            return new_vtf;
        }


        /// <summary>
        /// Extracts a VTF from VPK at runtime and converts to uncompressed BGRA8888.
        /// </summary>
        public byte[] extract_and_prepare_vtf(string mat_dir, string vtf_name, string tmp_dir)
        {
            string vtf_path = mat_dir + vtf_name + ".vtf";
            string extract_dir = tmp_dir + mat_dir;

            // extract VTF from game VPK (vpk_selection=1 = tf2_textures_dir.vpk)
            VPK.Extract(vtf_path, extract_dir, 1);

            string extracted_file = extract_dir + vtf_name + ".vtf";
            if (!File.Exists(extracted_file)) { return null; }

            byte[] vtf_bytes = File.ReadAllBytes(extracted_file);

            // convert DXT1 to uncompressed BGRA8888 (preserves all mipmaps, zero quality loss)
            vtf_bytes = convert_dxt1_to_bgra8888(vtf_bytes);

            return vtf_bytes;
        }

        /// <summary>
        /// Writes a PNG mask into every mip level of a BGRA8888 VTF's alpha channel.
        /// For each pixel, the mask's brightness is written directly as the alpha byte.
        /// </summary>
        public void write_alpha_v2(byte[] vtf_bytes, Bitmap mask_bmp, string out_path)
        {
            int format = BitConverter.ToInt32(vtf_bytes, VTF_OFFSET_FORMAT);
            if (format != VTF_FORMAT_BGRA8888) { return; }

            ushort width = BitConverter.ToUInt16(vtf_bytes, VTF_OFFSET_WIDTH);
            ushort height = BitConverter.ToUInt16(vtf_bytes, VTF_OFFSET_HEIGHT);
            byte mip_count = vtf_bytes[VTF_OFFSET_MIPCOUNT];

            // calculate per-mip sizes and total
            int[] mip_sizes = new int[mip_count];
            int[] mip_widths = new int[mip_count];
            int[] mip_heights = new int[mip_count];
            int total_image_size = 0;
            int mw = width, mh = height;
            for (int m = 0; m < mip_count; m++)
            {
                mip_widths[m] = Math.Max(1, mw);
                mip_heights[m] = Math.Max(1, mh);
                mip_sizes[m] = mip_widths[m] * mip_heights[m] * 4;
                total_image_size += mip_sizes[m];
                mw = Math.Max(1, mw / 2);
                mh = Math.Max(1, mh / 2);
            }

            int data_start = vtf_bytes.Length - total_image_size;

            // write alpha into each mip level (stored smallest-first)
            int vtf_pos = data_start;
            for (int m = mip_count - 1; m >= 0; m--)
            {
                int w = mip_widths[m];
                int h = mip_heights[m];

                // scale mask to this mip's dimensions
                Bitmap scaled;
                if (w == mask_bmp.Width && h == mask_bmp.Height)
                {
                    scaled = mask_bmp;
                }
                else
                {
                    scaled = new Bitmap(mask_bmp, w, h);
                }

                // write alpha byte directly for each pixel (byte 3 of each BGRA quad)
                for (int y = 0; y < h; y++)
                {
                    for (int x = 0; x < w; x++)
                    {
                        Color c = scaled.GetPixel(x, y);
                        byte alpha = (byte)((c.R + c.G + c.B) / 3);
                        vtf_bytes[vtf_pos + (y * w + x) * 4 + 3] = alpha;
                    }
                }

                if (scaled != mask_bmp) { scaled.Dispose(); }

                vtf_pos += mip_sizes[m];
            }

            File.WriteAllBytes(out_path, vtf_bytes);
        }

        /// <summary>
        /// Converts a VTF byte array to a Bitmap. Handles BGRA8888, DXT1, and DXT5 formats.
        /// Decodes the largest mip level only.
        /// </summary>
        public Bitmap vtf_to_bitmap(byte[] vtf_bytes)
        {
            if (vtf_bytes == null || vtf_bytes.Length < 64) return null;

            int format = BitConverter.ToInt32(vtf_bytes, VTF_OFFSET_FORMAT);
            ushort width = BitConverter.ToUInt16(vtf_bytes, VTF_OFFSET_WIDTH);
            ushort height = BitConverter.ToUInt16(vtf_bytes, VTF_OFFSET_HEIGHT);
            byte mip_count = vtf_bytes[VTF_OFFSET_MIPCOUNT];

            if (width == 0 || height == 0) return null;

            byte[] pixels; // BGRA8888 output

            if (format == VTF_FORMAT_BGRA8888)
            {
                int pixel_data_size = width * height * 4;
                int data_start = vtf_bytes.Length - pixel_data_size;
                if (data_start < 0) return null;

                pixels = new byte[pixel_data_size];
                Array.Copy(vtf_bytes, data_start, pixels, 0, pixel_data_size);
            }
            else if (format == VTF_FORMAT_DXT1)
            {
                pixels = decode_dxt_largest_mip(vtf_bytes, width, height, mip_count, 8, false);
            }
            else if (format == VTF_FORMAT_DXT5)
            {
                pixels = decode_dxt_largest_mip(vtf_bytes, width, height, mip_count, 16, true);
            }
            else
            {
                // unsupported format
                return null;
            }

            if (pixels == null) return null;

            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            BitmapData bmpData = bmp.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb);
            Marshal.Copy(pixels, 0, bmpData.Scan0, pixels.Length);
            bmp.UnlockBits(bmpData);

            return bmp;
        }

        /// <summary>
        /// Decodes the largest mip level from a DXT1 or DXT5 VTF.
        /// blockSize: 8 for DXT1, 16 for DXT5.
        /// </summary>
        private byte[] decode_dxt_largest_mip(byte[] vtf_bytes, int width, int height, int mip_count, int blockSize, bool isDxt5)
        {
            // calculate total compressed size for all mips to find data start
            int total_compressed = 0;
            int mw = width, mh = height;
            int[] mip_sizes = new int[mip_count];
            for (int m = 0; m < mip_count; m++)
            {
                int bw = Math.Max(1, (mw + 3) / 4);
                int bh = Math.Max(1, (mh + 3) / 4);
                mip_sizes[m] = bw * bh * blockSize;
                total_compressed += mip_sizes[m];
                mw = Math.Max(1, mw / 2);
                mh = Math.Max(1, mh / 2);
            }

            int data_start = vtf_bytes.Length - total_compressed;
            if (data_start < 0) return null;

            // the largest mip is stored LAST (mips are smallest-first)
            // skip all smaller mips to get to mip 0
            int src_pos = data_start;
            for (int m = mip_count - 1; m > 0; m--)
            {
                src_pos += mip_sizes[m];
            }

            // decode the largest mip
            int stride = width * 4;
            byte[] pixels = new byte[width * height * 4];

            int blocks_x = Math.Max(1, (width + 3) / 4);
            int blocks_y = Math.Max(1, (height + 3) / 4);

            for (int by = 0; by < blocks_y; by++)
            {
                for (int bx = 0; bx < blocks_x; bx++)
                {
                    if (isDxt5)
                        decode_dxt5_block(vtf_bytes, src_pos, pixels, stride, bx, by, width, height);
                    else
                        decode_dxt1_block(vtf_bytes, src_pos, pixels, stride, bx, by, width, height);
                    src_pos += blockSize;
                }
            }

            return pixels;
        }

    }
}
