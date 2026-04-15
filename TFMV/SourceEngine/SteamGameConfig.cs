using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Microsoft.Win32;


namespace TFMV.SourceEngine
{
    /// <summary>
    /// 2022: this is a complete mess and unreliable method to detect the steam/game directories
    /// requires a total overhaul to properly detect Steam/game install folders
    /// </summary>
    public partial class SteamGameConfig : UserControl
    {

        private int appid = 440;

        public string steam_dir { get; set; }

        public string tf_dir { get; set; }
        public string tf2_dir { get; set; }
        public string bin_dir { get; set; }

        public string settings_dir { get { return Main.settings_dir; } }

        public bool valid_config;


        public SteamGameConfig()
        {
            InitializeComponent();
        }

        // get Steam install directory from the windows registry
        // bool detecting : for when we are searching the dir through the steam config, we don't warn if hlmv.exe is not found
        public bool get_SteamDir(bool detecting)
        {

            // check if hlmv.exe exists with paths from saved config
            if (validate_tf_dir(detecting))
            {
                valid_config = true;
                return true;
            }
           
            // if not try to find SteamDir and TF2 dir and test if hlmv.exe exists
            try
            {
                #region find steam install dir in windows registry
                //find steam install dir in windows registry
                string tmppath = "";
                RegistryKey regKey = Registry.CurrentUser;
                regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

                if (regKey != null)
                {
                    if (tmppath.Trim().EndsWith("\\"))
                    {
                        tmppath = regKey.GetValue("SteamPath").ToString();
                    }
                    else
                    {
                        tmppath = regKey.GetValue("SteamPath").ToString().Replace("/", "\\") + "\\";
                    }
                }


                //rtxtb.AppendText("\nRedistry path: " + tmppath);
                steam_dir = tmppath.Replace("steamapps", "").Replace(@"\\", @"\");

                #endregion

                #region verify steam dir exists

                //verify that steam dir is valid
                if (Directory.Exists(steam_dir))
                {
                     txtb_steamdir.Text = steam_dir;

                    //get team fortress 2 install dir
                    if (get_app_config(appid))
                    {
                        if(validate_tf_dir(true))
                        {
                            valid_config = true;
                            // successfully found steam dir, tf2 dir and the sdk tools
                            return true;
                        } else {
                            valid_config = false;
                            MessageBox.Show(
                                "Steam and TF2 were found, but hlmv.exe is missing.\n\n" +
                                "The Source SDK tools ship with TF2 in 'Team Fortress 2\\bin\\'.\n" +
                                "Try verifying TF2's game files through Steam to restore the missing tools.",
                                "TF2 SDK Tools Missing");
                            // could not find HLMV
                            return false;
                        }


                    } else {

                        valid_config = false;
                        // tf2 dir not found
                        return false;
                    }
                }
                else
                {
                    valid_config = false;
                    MessageBox.Show(
                        "Could not find your Steam install directory.\n\n" +
                        "Please click 'Select Directory' next to Steam Directory and point it at your Steam folder manually (e.g. C:\\Program Files (x86)\\Steam\\).",
                        "Steam Not Found");
                    return false;
                }
                #endregion

            }
            catch
            {
                MessageBox.Show(
                    "Failed to read the Steam install directory from the Windows registry.\n\n" +
                    "Please click 'Select Directory' next to Steam Directory and point it at your Steam folder manually.",
                    "Steam Registry Read Failed");
                valid_config = false;
                return false;
            }

     
        }

        // gets game (tf2) install path from the steam config.vdf
        private bool get_app_config(int appid)
        {
            var steam_config = steam_dir + "config\\config.vdf";

            // if config.vdf exists, try to get the exact install path from it first
            if (File.Exists(steam_config))
            {
                try
                {
                    TFMV.VDF_parser pr_config = new TFMV.VDF_parser();
                    pr_config.file_path = steam_config;
                    pr_config.load_VDF_file();

                    TFMV.VDF_parser.VDF_node node_App = pr_config.sGet_NodePath("InstallConfigStore.Software.Valve.Steam.apps." + appid.ToString());
                    string installdir_test = pr_config.sGet_KeyVal(node_App, "installdir");
                    if (!string.IsNullOrEmpty(installdir_test))
                    {
                        installdir_test = Regex.Replace(installdir_test, @"\\\\", @"\");
                        if (Directory.Exists(installdir_test) && sett_tf_dir(installdir_test + "\\tf\\"))
                        {
                            return true;
                        }
                    }
                }
                catch { /* fall through to library scan */ }
            }

            // scan every Steam library folder listed in libraryfolders.vdf
            var libraries = get_steam_library_folders();

            foreach (string lib in libraries)
            {
                string candidate = Path.Combine(lib, "steamapps", "common", "Team Fortress 2", "tf") + "\\";
                candidate = candidate.Replace("/", "\\").Replace("\\\\", "\\");
                if (Directory.Exists(candidate))
                {
                    if (sett_tf_dir(candidate))
                    {
                        return true;
                    }
                }
            }

            valid_config = false;

            MessageBox.Show(
                "Could not find your TF2 install in any Steam library folder.\n\n" +
                "Scanned libraries:\n  - " + string.Join("\n  - ", libraries.ToArray()) +
                "\n\nPlease click 'Select Directory' next to TF Directory and point it at your TF2 \"tf\" folder manually.",
                "TF2 Install Not Found");
            return false;
        }

        // returns every Steam library folder root (not including \steamapps\common)
        private List<string> get_steam_library_folders()
        {
            var result = new List<string>();

            // the default Steam install is always a library
            if (!string.IsNullOrEmpty(steam_dir) && Directory.Exists(steam_dir))
            {
                result.Add(steam_dir.TrimEnd('\\', '/'));
            }

            // newer Steam stores libraries in steamapps\libraryfolders.vdf
            // older Steam used config\libraryfolders.vdf — try both
            string[] candidates = new[]
            {
                (steam_dir + "steamapps\\libraryfolders.vdf").Replace("/", "\\").Replace("\\\\", "\\"),
                (steam_dir + "config\\libraryfolders.vdf").Replace("/", "\\").Replace("\\\\", "\\")
            };

            foreach (string path in candidates)
            {
                if (!File.Exists(path)) continue;

                try
                {
                    TFMV.VDF_parser parser = new TFMV.VDF_parser();
                    parser.file_path = path;
                    parser.load_VDF_file();

                    TFMV.VDF_parser.VDF_node root = parser.sGet_NodePath("LibraryFolders");
                    if (root == null || root.nSubNodes == null) root = parser.sGet_NodePath("libraryfolders");
                    if (root == null || root.nSubNodes == null) continue;

                    // each subnode is a numerically-indexed library folder
                    foreach (var sub in root.nSubNodes)
                    {
                        // newer format: node key is "0", "1", ... each with a "path" subnode
                        // older format: node key is "1", "2", ... with a direct string value
                        string libPath = null;

                        if (sub.nSubNodes != null && sub.nSubNodes.Count > 0)
                        {
                            libPath = parser.sGet_KeyVal(sub, "path");
                        }

                        if (string.IsNullOrEmpty(libPath))
                        {
                            libPath = sub.nvalue;
                        }

                        if (string.IsNullOrEmpty(libPath)) continue;

                        libPath = libPath.Replace(@"\\", @"\").TrimEnd('\\', '/');

                        if (!string.IsNullOrEmpty(libPath) && Directory.Exists(libPath) && !result.Contains(libPath))
                        {
                            result.Add(libPath);
                        }
                    }

                    break; // found a libraryfolders.vdf that parsed successfully
                }
                catch { /* try next candidate */ }
            }

            return result;
        }

        // checks that the TF2 install looks intact — returns the list of missing files, or empty list if OK
        public List<string> validate_tf_install()
        {
            var missing = new List<string>();

            if (string.IsNullOrEmpty(tf_dir) || string.IsNullOrEmpty(tf2_dir))
            {
                missing.Add("(no TF directory set)");
                return missing;
            }

            string[] required = new[]
            {
                tf2_dir + "bin\\hlmv.exe",
                tf_dir + "scripts\\items\\items_game.txt",
                tf_dir + "tf2_textures_dir.vpk"
            };

            foreach (string path in required)
            {
                if (!File.Exists(path)) missing.Add(path);
            }

            return missing;
        }

        // checks that all required TF2 files exist — used internally by the load/detect flow
        private bool validate_tf_dir(bool show_error)
        {
            var missing = validate_tf_install();
            if (missing.Count == 0) return true;

            if (show_error)
            {
                MessageBox.Show(
                    "The TF2 install at this path is missing required files:\n\n" +
                    "  - " + string.Join("\n  - ", missing.ToArray()) +
                    "\n\nTry verifying TF2's game files through Steam, or pick a different folder.",
                    "TF2 Install Invalid");
            }
            return false;
        }


        // dialog select SteamDir manually
        private void btn_sel_steamdir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;

                if (Path.GetFileNameWithoutExtension(path).ToLower() == "steam")
                {
                    steam_dir = (path + "\\").Replace(@"\\", @"\");

                    txtb_steamdir.Text = steam_dir;

                    save_game_config();

                    if (get_app_config(appid))
                    {
                        valid_config = true;
                        save_game_config();
                    }
                }
                else
                {
                    valid_config = false;
                    MessageBox.Show("Please select the \"steam\" folder.\n\nExample: C:\\Program Files (x86)\\Steam\\", "Invalid Folder");
                }
            }
        }

        // dialog select TF2 Dir manually
        private void btn_sel_mod_dir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;

                if (Path.GetFileNameWithoutExtension(path).ToLower() == "tf")
                {
                    // check if tools exist
                    if (!File.Exists(((path + "\\").Replace(@"\\", @"\")).Replace("\\tf\\", "\\") + "bin\\hlmv.exe"))
                    {
                        MessageBox.Show("Error: invalid TF directory, could not find " + ((path + "\\").Replace(@"\\", @"\")).Replace("\\tf\\", "\\") + "bin\\hlmv.exe");
                        return;
                    }

                    sett_tf_dir(path + "\\");
                    save_game_config();
                }
                else
                {
                    valid_config = false;
                    MessageBox.Show("Please select the \"tf\" folder.\n\nExample: C:\\Program Files (x86)\\Steam\\SteamApps\\common\\Team Fortress 2\\tf\\", "Invalid Folder");
                }
            }
        }


        // detect steam dir button
        private void btn_get_steamdir_Click(object sender, EventArgs e)
        {
            reset_config();
            get_SteamDir(false);
            save_game_config();
        }



        public void save_game_config()
        {
            //MessageBox.Show(settings_dir);
            try
            {
                TextWriter tw = new StreamWriter(settings_dir + "game_config.ini");

                tw.WriteLine("steam_dir|" + steam_dir);
                tw.WriteLine("tf_dir|" + tf_dir);

                tw.Close();
            }
            catch (System.Exception excep)
            {
                MessageBox.Show("Error saving settings! " + excep.Message);
            }

            Main.tfmv_dir = (tf_dir + Main.tfmv_dir_short).Replace("\\\\", "\\");
            VPK.set_tf_paths(tf_dir, tf2_dir);

        }

        // loads game config, if config is not found and silent_detect = true, try to detect, if tf2 dir found, no need to warn the user the config save file isn't found
        public void load_game_config(bool silent_detect)
        {
            try
            {
                string f = settings_dir + "game_config.ini";
                if (File.Exists(f))
                {
                    List<string> lines = new List<string>();

                    using (StreamReader r = new StreamReader(f))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            string[] arg = line.Split('|');

                            if (arg[0] == "steam_dir")
                            {
                                steam_dir = arg[1];
                                txtb_steamdir.Text = arg[1];
                            }

                            if (arg[0] == "tf_dir")
                            {
                                //this.tf_dir = arg[1];

                                sett_tf_dir(arg[1]);
                            }
                        }
                    }
                }

                }

            catch (System.Exception excep)
            {
                valid_config = false;
                MessageBox.Show("Error loading settings " + excep.Message);
            }

            if (!validate_tf_dir(false))
            {
                if (!silent_detect)
                {
                    valid_config = false;
                    MessageBox.Show("TF2 directory path loaded from settings file is invalid. \nAttempting to auto-detect TF2 directory.");
                }
                reset_config();
                get_SteamDir(false);
                save_game_config();

                //sett_tf_dir(string tf_path);
                Main.tfmv_dir = (tf_dir + Main.tfmv_dir_short).Replace("\\\\", "\\");
                VPK.set_tf_paths(tf_dir, tf2_dir);

            }
            else
            {
                //sett_tf_dir(string tf_path);
                Main.tfmv_dir = (tf_dir + Main.tfmv_dir_short).Replace("\\\\", "\\");
                VPK.set_tf_paths(tf_dir, tf2_dir);

                valid_config = true;

            }

        }

        private bool sett_tf_dir(string tf_path)
        {
            string hlmv_exe_path = ((tf_path + "\\").Replace(@"\\", @"\")).Replace("\\tf\\", "\\") + "bin\\hlmv.exe";

            if (File.Exists(hlmv_exe_path))
            {
                tf_dir = (tf_path + "\\").Replace(@"\\", @"\");
                tf2_dir = tf_dir.Replace("\\tf\\", "\\");
                bin_dir = (tf2_dir + "\\bin\\").Replace("\\tf\\", "\\").Replace(@"\\", @"\"); 
                txtb_moddir.Text = tf_dir;
                valid_config = true;

                return true;
            }

            return false;
        }

        // sets steam_dir and tf_dir to ""
        private void reset_config()
        {
            steam_dir = "";
            txtb_steamdir.Text = "";

            tf_dir = "";
            tf2_dir = "";
            bin_dir = "";
            txtb_moddir.Text = "";
        }


    }
}
