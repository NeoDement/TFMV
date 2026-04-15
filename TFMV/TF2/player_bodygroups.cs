using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TFMV.TF2
{
    public class player_bodygroups
    {
        // bodygroup lists per class — populated from bodygroups.txt
        public List<player_bodygroup> scout = new List<player_bodygroup>();
        public List<player_bodygroup> soldier = new List<player_bodygroup>();
        public List<player_bodygroup> pyro = new List<player_bodygroup>();
        public List<player_bodygroup> demoman = new List<player_bodygroup>();
        public List<player_bodygroup> engineer = new List<player_bodygroup>();
        public List<player_bodygroup> heavy = new List<player_bodygroup>();
        public List<player_bodygroup> medic = new List<player_bodygroup>();
        public List<player_bodygroup> sniper = new List<player_bodygroup>();

        public player_bodygroups()
        {
            string config_path = Main.app_data_dir + "bodygroups.txt";

            if (File.Exists(config_path))
            {
                load_from_file(config_path);
            }
        }

        private void load_from_file(string path)
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string raw_line in lines)
            {
                string line = raw_line.Trim();

                // skip comments and blank lines
                if (line == "" || line.StartsWith("#")) { continue; }

                string[] parts = line.Split(',');
                if (parts.Length < 3) { continue; }

                string tf_class = parts[0].Trim().ToLower();
                string name = parts[1].Trim();
                string mask_name = parts[2].Trim();
                string target_mat = (parts.Length > 3 && parts[3].Trim() != "") ? parts[3].Trim() : null;

                player_bodygroup bg = new player_bodygroup(name, mask_name, target_mat);

                List<player_bodygroup> list = get_list(tf_class);
                if (list != null) { list.Add(bg); }
            }
        }

        public List<player_bodygroup> get_list(string tf_class)
        {
            switch (tf_class)
            {
                case "scout": return scout;
                case "soldier": return soldier;
                case "pyro": return pyro;
                case "demoman": return demoman;
                case "demo": return demoman;
                case "engineer": return engineer;
                case "heavy": return heavy;
                case "medic": return medic;
                case "sniper": return sniper;
                default: return null;
            }
        }
    }

    public class player_bodygroup
    {
        public string name { get; set; }
        public string mask_name { get; set; }
        // optional: override the material this bodygroup targets (null = use class default)
        public string target_mat { get; set; }

        public player_bodygroup(string name, string mask_name, string target_mat = null)
        {
            this.name = name;
            this.mask_name = mask_name;
            this.target_mat = target_mat;
        }
    }

    // kept for backwards compatibility
    public class bodygroup_combination
    {
        public String[] mask_names { get; set; }
        public string mask_filename { get; set; }

        public bodygroup_combination(String[] _masks, string _mask_filename)
        {
            this.mask_names = _masks;
            this.mask_filename = _mask_filename;
        }
    }
}
