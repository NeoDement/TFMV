using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TFMV.SourceEngine;
using TFMV.Functions;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using System.Reflection;

namespace TFMV.UserControls
{
    public partial class Bodygroup_manager : UserControl
    {
        private TF2.player_bodygroups player_bodygroups;

        private List<TF2.player_bodygroup> bodygroups_class = new List<TF2.player_bodygroup>();

        private string tfmv_dir,player_class,team_color;


        public Bodygroup_manager()
        {
            InitializeComponent();
        }


        public void setup(List<String> loadout_bodygroups_off, string _tfmv_dir, string _player_class, string _team_color)
        {
            tfmv_dir = _tfmv_dir;
            player_class = _player_class;
            team_color = _team_color;

            // construct here so app_data_dir has been set (debug override runs before setup is called)
            player_bodygroups = new TF2.player_bodygroups();

            this.Controls.Clear();
            bodygroups_manager_setup(this.player_class, loadout_bodygroups_off);
        }

        public void switch_skin(string _team_color)
        {
            team_color = _team_color;

            create_bodygroups_mask(true);
        }

        #region forms

        public void add_bodygroups(string name, bool _checked)
        {
            Point checkbox_pos = new Point();
            int posy_increment = 0; //starting position for the first checkbox
            Panel p = (Panel)this.Controls["this"];

            // search checkboxes
            // if checkboxes exist, get the position
            foreach (var checkbox in this.Controls.OfType<CheckBox>())
            {
                checkbox_pos = checkbox.Location;
                posy_increment = 20;
            }

            //add checkbox and set position Y
            add_checkbox(name, checkbox_pos.Y + posy_increment, _checked);
        }

        private void add_checkbox(string name, int posy, bool _checked)
        {
            CheckBox cb = new CheckBox();

            cb.Checked = _checked;

            cb.Location = new Point(5, posy);
            cb.Text = name;

            //neodement: fix for long bodygroup names getting cut off (such as medic_backpack)
            cb.Width = 110;

            this.Controls.Add(cb);

            cb.CheckedChanged += new EventHandler(this.checkbox_event);
        }

        private void checkbox_event(object sender, EventArgs e)
        {
            create_bodygroups_mask(true);
        }

        #endregion


        #region bodygroups manager

        // creates the bodygroup manager user control within the control "bodygroups_panel"
        // and adds checkboxes for each existing bodygroup for a TF2 player/class model
        private void bodygroups_manager_setup(string tf_class, List<String> loadout_bodygroups_off)
        {

            if ((tf_class == "") || (tfmv_dir == "") || (team_color == "")) { return; }

            // clear bodygroups panel
            this.Controls.Clear();


            // get class's bodygroups from bodygroups.txt via player_bodygroups
            bodygroups_class = player_bodygroups.get_list(tf_class) ?? new List<TF2.player_bodygroup>();

            if (tf_class == "heavy") { tf_class = "hvyweapon"; }

            // for each TF2.player_bodygroups.tfmv_bodygroup add a checkbox for the bodygroup-name
            foreach (var item in bodygroups_class)
            {
                if (item.mask_name != "")
                {
                    bool _bodygroup_on = true;
                    string bodygroupname_without_class = item.mask_name.Replace(tf_class + "_", "");

                    if (loadout_bodygroups_off.Contains(bodygroupname_without_class)) //item.mask_name.Split('_')[1]
                    {
                        _bodygroup_on = false;
                    }

                    this.add_bodygroups(item.name, _bodygroup_on);
                }
            }

            create_bodygroups_mask(true);
        }

        private void Bodygroup_manager_Load(object sender, EventArgs e)
        {

        }

        public void create_bodygroups_mask(bool refresh_hlmv)
        {
            List<string> bodygroups_off = new List<string>();

            // loop through bodygroup_manager_panel checkboxes
            // if bodygroup on, add to list
            foreach (var cb in this.Controls.OfType<CheckBox>())
            {
                if (!cb.Checked) bodygroups_off.Add(cb.Text);
            }

            gen_player_material(bodygroups_off);

            if(refresh_hlmv)
            {
                Main.refresh_hlmv(false);
            }
        }

        public int bodygroups_off_count()
        {
            int count = 0;
            // loop through bodygroup_manager_panel checkboxes
            // if bodygroup on, add to list
            foreach (var cb in this.Controls.OfType<CheckBox>())
            {
                if (!cb.Checked) count++;
            }

            return count;
        }



        // loads a bodygroup mask PNG from config\bodygroup_masks\ as a Bitmap
        private Bitmap load_mask(string mask_name, string tf_class, string bodygroup_name)
        {
            string name = (mask_name != "") ? mask_name : tf_class + "_" + bodygroup_name;
            string png_path = Main.app_data_dir + "bodygroup_masks\\" + name + ".png";

            if (!File.Exists(png_path)) { return null; }
            return new Bitmap(png_path);
        }

        // combines two mask bitmaps by taking the brighter pixel (additive blend)
        private Bitmap combine_masks(Bitmap a, Bitmap b)
        {
            int w = Math.Max(a.Width, b.Width);
            int h = Math.Max(a.Height, b.Height);
            Bitmap result = new Bitmap(w, h);

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    int va = (x < a.Width && y < a.Height) ? a.GetPixel(x, y).R : 255;
                    int vb = (x < b.Width && y < b.Height) ? b.GetPixel(x, y).R : 255;
                    int v = Math.Min(255, va + vb);
                    result.SetPixel(x, y, Color.FromArgb(255, v, v, v));
                }
            }

            return result;
        }

        // generates player's VTF with transparency alpha mask for the bodygroups
        // and the VMT with transparency parameters
        public void gen_player_material(List<string> bodygroups_off)
        {
            #region checks and setup vars

            string tf_class = player_class;

            if (tf_class == "demo") { tf_class = "demoman"; }

            #region search for player material

            TF2.player_material player_material = null;
            TF2.player_materials player_mats = new TF2.player_materials();

            // search for the class material
            for (int i = 0; i < player_mats.players_mats.Count; i++)
            {
                if (player_mats.players_mats[i].tf_class == tf_class)
                {
                    player_material = player_mats.players_mats[i];
                    break;
                }
            }

            #endregion

            // force use of red material for the grey skin
            if (Main.grey_material) { team_color = "red"; }

            // if player material was no found, exit
            if (player_material == null) { return; }

            // default material name for this class + team
            string default_mat = player_material.mat_name + "_" + team_color;
            if (tf_class == "medic") { default_mat = "medic_backpack_" + team_color; }

            #endregion

            // if there's no bodygroups to hide and not grey material, clean up and return
            if ((bodygroups_off.Count == 0) && (!Main.grey_material))
            {
                miscFunc.delete_safe(tfmv_dir + player_material.mat_dir + default_mat + ".vtf");
                miscFunc.delete_safe(tfmv_dir + player_material.mat_dir + default_mat + ".vmt");
                return;
            }

            #region group bodygroups by target material

            // bodygroups can target different materials (e.g. heavy hands targets sheen, others target body)
            // group them so we process each material once with a combined mask
            Dictionary<string, List<string>> mat_to_bodygroups = new Dictionary<string, List<string>>();

            foreach (string bodygroup_name in bodygroups_off)
            {
                string target = default_mat;
                foreach (var bg in bodygroups_class)
                {
                    if (bg.name == bodygroup_name && bg.target_mat != null)
                    {
                        target = bg.target_mat;
                        break;
                    }
                }

                if (!mat_to_bodygroups.ContainsKey(target))
                {
                    mat_to_bodygroups[target] = new List<string>();
                }
                mat_to_bodygroups[target].Add(bodygroup_name);
            }

            // if grey material with no bodygroups off, still need to process the default material
            if (mat_to_bodygroups.Count == 0 && Main.grey_material)
            {
                mat_to_bodygroups[default_mat] = new List<string>();
            }

            #endregion

            VTFedit vtf_edit = new VTFedit();

            foreach (var kvp in mat_to_bodygroups)
            {
                string mat_name = kvp.Key;
                List<string> bodygroups_for_mat = kvp.Value;

                #region build combined alpha mask from individual masks

                Bitmap combined_mask = null;

                foreach (string bodygroup_name in bodygroups_for_mat)
                {
                    string mask_name = "";
                    foreach (var bg in bodygroups_class)
                    {
                        if (bg.name == bodygroup_name) { mask_name = bg.mask_name; break; }
                    }

                    Bitmap mask = load_mask(mask_name, tf_class, bodygroup_name);
                    if (mask == null) { continue; }

                    if (combined_mask == null)
                    {
                        combined_mask = mask;
                    }
                    else
                    {
                        Bitmap old = combined_mask;
                        combined_mask = combine_masks(combined_mask, mask);
                        old.Dispose();
                        mask.Dispose();
                    }
                }

                if (combined_mask == null && !Main.grey_material) { continue; }

                #endregion

                #region extract VTF from VPK and inject alpha mask

                byte[] vtf_bytes = vtf_edit.extract_and_prepare_vtf(player_material.mat_dir, mat_name, Main.tmp_dir);

                if (vtf_bytes != null && combined_mask != null)
                {
                    string out_dir = tfmv_dir + player_material.mat_dir;
                    if (!Directory.Exists(out_dir)) { Directory.CreateDirectory(out_dir); }
                    vtf_edit.write_alpha_v2(vtf_bytes, combined_mask, out_dir + mat_name + ".vtf");
                    combined_mask.Dispose();
                }

                #endregion

                #region extract and edit VMT to add transparency

                // extract VMT from VPK
                if (!Main.grey_material)
                {
                    VPK.Extract(player_material.mat_dir + mat_name + ".vmt", tfmv_dir + player_material.mat_dir, 0);
                }

                try
                {
                    string vmt_path = tfmv_dir + player_material.mat_dir + mat_name + ".vmt";

                    if ((bodygroups_for_mat.Count == 0) && (Main.grey_material))
                    {
                        VMT.set_parameter(vmt_path, "basetexture", "tfmv\\flat_color.vtf");
                        continue;
                    }
                    else if ((bodygroups_for_mat.Count > 0) && (Main.grey_material))
                    {
                        VMT.set_parameter(vmt_path, "basetexture", player_material.mat_dir.ToLower().Replace("materials\\models\\", "models\\") + mat_name + ".vtf");
                        continue;
                    }

                    List<string> vmt_lines = new List<string>();
                    string rline;
                    System.IO.StreamReader file = new System.IO.StreamReader(vmt_path);
                    while ((rline = file.ReadLine()) != null)
                    {
                        vmt_lines.Add(rline);
                    }
                    file.Close();

                    RegexOptions options = RegexOptions.None;
                    Regex regex = new Regex(@"\s*?$", options);

                    for (int i = 0; i < vmt_lines.Count; i++)
                    {
                        string line = ((regex.Replace(vmt_lines[i], @" ")).Trim()).ToLower().Replace("  ", " ");

                        if (line.Contains("{"))
                        {
                            if (tf_class == "medic")
                            {
                                vmt_lines.Insert(i + 1, "\t$translucent 1\n\t$alphatest 1\n" + "\t$basemapalphaphongmask 0");
                            }
                            else
                            {
                                vmt_lines.Insert(i + 1, "\t$translucent 1\n\t$alphatest 1\n");
                            }
                            break;
                        }
                    }

                    // make VMT red, since we can't switch the model skin in HLMV
                    string vmt_out = mat_name;
                    if (team_color == "blue") { vmt_out = vmt_out.Replace("blue", "red"); }

                    File.WriteAllLines(tfmv_dir + player_material.mat_dir + vmt_out + ".vmt", vmt_lines);
                }
                catch
                {
                }

                #endregion
            }
        }

        #endregion
    }
}
