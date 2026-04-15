using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TFMV_Updater
{
    internal static class Program
    {
        // folders inside the install directory that should never be overwritten
        private static readonly string[] PreservedFolders = new[] { "config", "tf2_schema", "cached", "tmp", "tmp_loadout", "tmp_workshop_zip", "cubemaps" };

        [STAThread]
        private static int Main(string[] args)
        {
            if (args.Length < 3)
            {
                MessageBox.Show(
                    "TFMV_Updater was launched with invalid arguments.\n\n" +
                    "Expected: TFMV_Updater.exe <pid_to_wait_for> <source_dir> <install_dir>",
                    "TFMV Updater");
                return 1;
            }

            int pid;
            if (!int.TryParse(args[0], out pid))
            {
                MessageBox.Show("Invalid PID: " + args[0], "TFMV Updater");
                return 1;
            }

            string srcDir = args[1];
            string installDir = args[2];

            if (!Directory.Exists(srcDir))
            {
                MessageBox.Show("Source directory not found:\n" + srcDir, "TFMV Updater");
                return 1;
            }

            if (!Directory.Exists(installDir))
            {
                MessageBox.Show("Install directory not found:\n" + installDir, "TFMV Updater");
                return 1;
            }

            WaitForTfmvToExit(pid);

            try
            {
                CopyDirectory(srcDir, installDir);
            }
            catch (UnauthorizedAccessException)
            {
                // need admin — relaunch self with UAC
                if (RelaunchAsAdmin(args))
                {
                    return 0;
                }

                MessageBox.Show(
                    "TFMV_Updater needs administrator rights to write to:\n" + installDir +
                    "\n\nThe update was not applied. Your existing TFMV install is unchanged.",
                    "TFMV Updater");
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The update failed:\n\n" + ex.Message +
                    "\n\nYour existing TFMV install may be in an inconsistent state.\n" +
                    "Downloaded files are at:\n" + srcDir,
                    "TFMV Updater");
                return 1;
            }

            // launch TFMV back up
            string tfmvExe = Path.Combine(installDir, "TFMV.exe");
            if (File.Exists(tfmvExe))
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = tfmvExe,
                        WorkingDirectory = installDir,
                        UseShellExecute = true
                    });
                }
                catch { /* launch failure is non-fatal */ }
            }

            return 0;
        }

        private static void WaitForTfmvToExit(int pid)
        {
            try
            {
                Process p = Process.GetProcessById(pid);
                // wait up to 30 seconds
                if (!p.WaitForExit(30000))
                {
                    // still running — fall through and hope for the best
                }
            }
            catch (ArgumentException)
            {
                // process already exited
            }
            catch { }

            // small grace period for file handles to release
            Thread.Sleep(500);
        }

        private static bool IsPreservedTopLevelFolder(string relativePath)
        {
            // only treat top-level matches as preserved (e.g. "config", not "libs/config")
            int sep = relativePath.IndexOfAny(new[] { '\\', '/' });
            string topSegment = sep < 0 ? relativePath : relativePath.Substring(0, sep);
            return PreservedFolders.Any(f => string.Equals(f, topSegment, StringComparison.OrdinalIgnoreCase));
        }

        private static void CopyDirectory(string src, string dst)
        {
            foreach (string srcFile in Directory.GetFiles(src, "*", SearchOption.AllDirectories))
            {
                string relative = srcFile.Substring(src.Length).TrimStart('\\', '/');

                if (IsPreservedTopLevelFolder(relative)) continue;

                string dstFile = Path.Combine(dst, relative);
                string dstDir = Path.GetDirectoryName(dstFile);

                if (!Directory.Exists(dstDir))
                {
                    Directory.CreateDirectory(dstDir);
                }

                File.Copy(srcFile, dstFile, true);
            }
        }

        private static bool RelaunchAsAdmin(string[] args)
        {
            try
            {
                string quotedArgs = string.Join(" ", args.Select(a => "\"" + a + "\""));
                var psi = new ProcessStartInfo
                {
                    FileName = Process.GetCurrentProcess().MainModule.FileName,
                    Arguments = quotedArgs,
                    UseShellExecute = true,
                    Verb = "runas"
                };
                Process.Start(psi);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
