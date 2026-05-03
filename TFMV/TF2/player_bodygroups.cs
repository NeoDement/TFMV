using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        public List<player_bodygroup> spy = new List<player_bodygroup>();

        public player_bodygroups()
        {
            // bodygroups.txt is bundled, read-only schema data — lives under assets/
            string config_path = Main.assets_dir + "bodygroups.txt";

            if (File.Exists(config_path))
            {
                load_from_file(config_path);
            }
        }

        // tag that marks an entry as "structural rather than a real bodygroup"
        // (currently just "divider"). Entries with this tag may have an empty
        // mask_name without the validator warning.
        private const string DIVIDER_TAG = "divider";

        // Format: section-headed text. See header doc-comment in bodygroups.txt
        // for the full spec; in short:
        //   [classname]      -> opens a class section
        //   name [, opts]    -> entry; mask defaults to <class>_<name>.png
        //   ---              -> divider in the current section
        //   # ...            -> comment
        // opts is comma-separated key=value pairs (format=bold, nodraw=<key>,
        // nomask=true).
        private void load_from_file(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string masks_dir = Main.bodygroup_masks_dir;
            string current_class = null;
            int line_num = 0;

            foreach (string raw_line in lines)
            {
                line_num++;

                // strip trailing comment and surrounding whitespace
                string line = raw_line;
                int hash = line.IndexOf('#');
                if (hash >= 0) { line = line.Substring(0, hash); }
                line = line.Trim();
                if (line == "") { continue; }

                // [classname] header
                if (line.StartsWith("[") && line.EndsWith("]"))
                {
                    current_class = line.Substring(1, line.Length - 2).Trim().ToLower();
                    if (get_list(current_class) == null)
                    {
                        MessageBox.Show(
                            "bodygroups.txt line " + line_num + ":\n" +
                            "unknown class '" + current_class + "'. Entries in this section will be skipped.",
                            "TFMV: unknown bodygroup class");
                    }
                    continue;
                }

                if (current_class == null)
                {
                    MessageBox.Show(
                        "bodygroups.txt line " + line_num + ":\n" +
                        "entry appears before any [class] header. Skipped.\n\n" +
                        raw_line,
                        "TFMV: bodygroups.txt parse error");
                    continue;
                }

                List<player_bodygroup> list = get_list(current_class);
                if (list == null) { continue; } // unknown class warned at the header

                // divider: dashes only on the line
                if (line.Replace("-", "") == "")
                {
                    HashSet<string> divider_tags = new HashSet<string> { "divider" };
                    list.Add(new player_bodygroup("", "", divider_tags));
                    continue;
                }

                // entry: name [, opt, opt, …] — every comma is a separator,
                // first field is the name, the rest are key=value options
                string[] fields = line.Split(',');
                string name = fields[0].Trim();

                if (name == "")
                {
                    MessageBox.Show(
                        "bodygroups.txt line " + line_num + ":\n" +
                        "empty bodygroup name. Skipped.\n\n" +
                        raw_line,
                        "TFMV: bodygroups.txt parse error");
                    continue;
                }

                HashSet<string> tags = new HashSet<string>();
                string nodraw_key = null;
                bool nomask = false;

                for (int i = 1; i < fields.Length; i++)
                {
                    string tok = fields[i].Trim();
                    if (tok == "") { continue; }

                    int eq = tok.IndexOf('=');
                    if (eq <= 0)
                    {
                        MessageBox.Show(
                            "bodygroups.txt line " + line_num + ":\n" +
                            "option '" + tok + "' on entry '" + name + "' isn't a key=value pair. Skipped.\n\n" +
                            raw_line,
                            "TFMV: bodygroups.txt parse error");
                        continue;
                    }

                    string key = tok.Substring(0, eq);
                    string val = tok.Substring(eq + 1);

                    if (key == "format")
                    {
                        // format=bold maps to a "bold" tag for downstream consumers
                        tags.Add(val);
                    }
                    else if (key == "nodraw") { nodraw_key = val; }
                    else if (key == "nomask") { nomask = (val == "true"); }
                    // unknown keys are silently ignored — easy to extend later
                }

                // mask resolution: nomask=true clears it explicitly (used when the
                // entry has no body-sheet mask file — e.g. heads on *_head_red).
                // Otherwise mask defaults to <class>_<name>; if that file is
                // missing, the validator below warns rather than silently clearing.
                string mask_name = nomask ? "" : (current_class + "_" + name);

                // validate
                bool is_structural = nodraw_key != null;
                if (mask_name == "" && !is_structural)
                {
                    MessageBox.Show(
                        "bodygroups.txt line " + line_num + ":\n" +
                        "entry '" + name + "' (class '" + current_class + "') has no mask and no nodraw= option — its checkbox would do nothing.\n\n" +
                        raw_line,
                        "TFMV: dead bodygroup entry");
                }
                else if (mask_name != "" && masks_dir != null && !File.Exists(masks_dir + mask_name + ".png"))
                {
                    MessageBox.Show(
                        "bodygroups.txt line " + line_num + ":\n" +
                        "mask file '" + mask_name + ".png' for entry '" + name + "' (class '" + current_class + "') was not found at:\n" +
                        masks_dir,
                        "TFMV: missing bodygroup mask");
                }

                var bg = new player_bodygroup(name, mask_name, tags);
                bg.nodraw_key = nodraw_key;
                list.Add(bg);
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
                case "spy": return spy;
                default: return null;
            }
        }
    }

    public class player_bodygroup
    {
        public string name { get; set; }
        public string mask_name { get; set; }
        // free-form tags from bodygroups.txt options field. Currently recognised:
        //   "bold"     — render the checkbox in bold
        //   "divider"  — render as a horizontal separator (no checkbox)
        public HashSet<string> tags { get; set; }
        // when set, toggling this bodygroup off will also write $no_draw VMTs
        // for any class material matching the key's pattern set (looked up in
        // Bodygroup_manager.NODRAW_PATTERNS). Set by the parser from the
        // nodraw=<key> option. Null when the entry has no nodraw behaviour.
        public string nodraw_key { get; set; }

        public player_bodygroup(string name, string mask_name, HashSet<string> tags = null)
        {
            this.name = name;
            this.mask_name = mask_name;
            this.tags = tags ?? new HashSet<string>();
            this.nodraw_key = null;
        }

        public bool has_tag(string tag)
        {
            return tags != null && tags.Contains(tag);
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
