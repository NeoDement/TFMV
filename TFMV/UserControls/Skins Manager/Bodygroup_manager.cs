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
            this.AutoScroll = true;
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

        public void add_bodygroups(string name, bool _checked, bool bold = false)
        {
            add_checkbox(name, next_control_y(), _checked, bold);
        }

        // Y position for the next vertically-stacked control. Walks every existing
        // control (checkbox or divider panel) so dividers don't get overlapped by
        // the next checkbox. Stride is 20px after a checkbox (its own height) but
        // only ~9px after a 1px divider, so the gap below the divider matches the
        // gap above it instead of looking lopsided.
        private int next_control_y()
        {
            int max_y = -1;
            Control top_control = null;
            foreach (Control c in this.Controls)
            {
                if (c.Location.Y > max_y)
                {
                    max_y = c.Location.Y;
                    top_control = c;
                }
            }
            if (max_y < 0) { return 0; }
            int stride = (top_control is CheckBox) ? 20 : 9;
            return max_y + stride;
        }

        // Adds a thin horizontal separator line — used between official (bold)
        // bodygroups and TFMV's synthetic / unofficial entries below them.
        private void add_divider()
        {
            Panel divider = new Panel();
            divider.Location = new Point(5, next_control_y() + 5);
            divider.Size = new Size(125, 1);
            divider.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(divider);
        }

        private void add_checkbox(string name, int posy, bool _checked, bool bold = false)
        {
            CheckBox cb = new CheckBox();

            cb.Checked = _checked;

            cb.Location = new Point(5, posy);
            cb.Text = name;

            //neodement: fix for long bodygroup names getting cut off (such as backpack_connector)
            cb.Width = 135;

            if (bold)
            {
                cb.Font = new Font(cb.Font, FontStyle.Bold);
            }

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
        // and adds checkboxes for each existing bodygroup for a TF2 player/class model.
        // Display order, bold rendering, and $no_draw-head behaviour are all driven by
        // bodygroups.txt — see player_bodygroups.cs for the format and tag list.
        private void bodygroups_manager_setup(string tf_class, List<String> loadout_bodygroups_off)
        {

            if ((tf_class == "") || (tfmv_dir == "") || (team_color == "")) { return; }

            // clear bodygroups panel
            this.Controls.Clear();

            // get class's bodygroups from bodygroups.txt via player_bodygroups
            bodygroups_class = player_bodygroups.get_list(tf_class) ?? new List<TF2.player_bodygroup>();

            string tf_class_internal = tf_class;
            if (tf_class_internal == "heavy") { tf_class_internal = "hvyweapon"; }

            foreach (var item in bodygroups_class)
            {
                // divider entries render as a horizontal line between sections — no checkbox
                if (item.has_tag("divider"))
                {
                    this.add_divider();
                    continue;
                }

                // nodraw=<key> entries hide a satellite material set on top of (or
                // instead of) any body-sheet mask. additive when a mask exists
                // (sniper glasses), standalone when no body-sheet mask exists
                // (heads on *_head_red, medic backpack on medic_backpack_red).
                string nodraw_key = item.nodraw_key;

                // skip dead entries: no mask AND no nodraw behaviour
                if (item.mask_name == "" && nodraw_key == null) { continue; }

                bool _bodygroup_on = !loadout_bodygroups_off.Contains(item.name);
                if (item.mask_name != "")
                {
                    string bodygroupname_without_class = item.mask_name.Replace(tf_class_internal + "_", "");
                    if (loadout_bodygroups_off.Contains(bodygroupname_without_class))
                        _bodygroup_on = false;
                }

                this.add_bodygroups(item.name, _bodygroup_on, item.has_tag("bold"));

                if (nodraw_key != null)
                {
                    // tag the checkbox so create_bodygroups_mask routes it to apply_nodraw
                    this.Controls.OfType<CheckBox>().Last().Tag = nodraw_key;
                }
            }

            create_bodygroups_mask(true);
        }

        private void Bodygroup_manager_Load(object sender, EventArgs e)
        {

        }

        // pattern sets for each nodraw=<key> option. on toggle, apply_nodraw
        // writes (or removes) $no_draw VMTs for any class material whose path
        // contains one of the patterns. add a new entry here to introduce a
        // new nodraw=<key> kind — no other code change required.
        private static readonly Dictionary<string, string[]> NODRAW_PATTERNS =
            new Dictionary<string, string[]>
            {
                { "head",     new[] { "_head_", "eyeball_" } },
                { "backpack", new[] { "_backpack_" } },
                { "lens",     new[] { "_lens" } },
            };

        public void create_bodygroups_mask(bool refresh_hlmv)
        {
            List<string> bodygroups_off = new List<string>();

            // seed with every nodraw key the loaded class uses, so re-checking a
            // bodygroup cleans up its $no_draw VMTs from a previous toggle.
            Dictionary<string, bool> nodraw_state = new Dictionary<string, bool>();
            foreach (var bg in bodygroups_class)
            {
                if (bg.nodraw_key != null) { nodraw_state[bg.nodraw_key] = false; }
            }

            // walk checkboxes — nodraw and mask paths fire independently, so a
            // checkbox can carry both (e.g. sniper glasses: mask + nodraw=lens)
            foreach (var cb in this.Controls.OfType<CheckBox>())
            {
                string tag = cb.Tag as string;
                if (tag != null && NODRAW_PATTERNS.ContainsKey(tag))
                {
                    nodraw_state[tag] = !cb.Checked;
                }

                if (!cb.Checked)
                {
                    var bg = bodygroups_class.FirstOrDefault(b => b.name == cb.Text);
                    if (bg != null && !string.IsNullOrEmpty(bg.mask_name))
                    {
                        bodygroups_off.Add(cb.Text);
                    }
                }
            }

            foreach (var kvp in nodraw_state) { apply_nodraw(kvp.Key, kvp.Value); }
            gen_player_material(bodygroups_off);

            if (refresh_hlmv)
            {
                Main.refresh_hlmv(false);
            }
        }

        // writes (or removes) $no_draw VMTs for any class material whose path
        // contains one of the substrings registered for this nodraw key. used to
        // hide satellite material sets that don't live on the body sheet — heads
        // (separate *_head_red), the medic backpack (medic_backpack_red), the
        // sniper goggle lens (sniper_lens), etc. NODRAW_PATTERNS is the table of
        // built-in keys; add a new entry there to introduce a new kind.
        private void apply_nodraw(string key, bool hidden)
        {
            string[] patterns;
            if (!NODRAW_PATTERNS.TryGetValue(key, out patterns)) { return; }

            string tf_class = player_class;
            if (tf_class == "demo") { tf_class = "demoman"; }

            TF2.player_all_materials all_mats = new TF2.player_all_materials();
            List<TF2.player_mats> mats_list = all_mats.players_mats_red;

            foreach (var tfclass in mats_list)
            {
                if (tfclass.class_name != tf_class) continue;

                foreach (var mat in tfclass.materials)
                {
                    string mat_lower = mat.material.ToLower();
                    bool matched = false;
                    foreach (var p in patterns)
                    {
                        if (mat_lower.Contains(p)) { matched = true; break; }
                    }
                    if (!matched) continue;

                    string vmt_path = tfmv_dir + mat.material + ".vmt";

                    if (hidden)
                    {
                        Functions.miscFunc.create_missing_dir(Path.GetDirectoryName(vmt_path));
                        File.WriteAllLines(vmt_path, new string[]
                        {
                            "\"VertexLitGeneric\"",
                            "{",
                            "\t\"$no_draw\" \"1\"",
                            "}"
                        });
                    }
                    else
                    {
                        // remove override so the original material shows through again
                        Functions.miscFunc.delete_safe(vmt_path);
                    }
                }
                break;
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



        // loads a bodygroup mask PNG from assets\bodygroup_masks\ as a Bitmap
        private Bitmap load_mask(string mask_name, string tf_class, string bodygroup_name)
        {
            string name = (mask_name != "") ? mask_name : tf_class + "_" + bodygroup_name;
            string png_path = Main.bodygroup_masks_dir + name + ".png";

            if (!File.Exists(png_path)) { return null; }
            return new Bitmap(png_path);
        }

        // combines two mask bitmaps by taking the darker pixel (min blend)
        private Bitmap combine_masks(Bitmap a, Bitmap b)
        {
            int w = Math.Max(a.Width, b.Width);
            int h = Math.Max(a.Height, b.Height);
            Bitmap result = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            var ra = a.LockBits(new Rectangle(0, 0, a.Width, a.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            var rb = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            var rr = result.LockBits(new Rectangle(0, 0, w, h), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            byte[] pa = new byte[ra.Stride * a.Height];
            byte[] pb = new byte[rb.Stride * b.Height];
            byte[] pr = new byte[rr.Stride * h];

            System.Runtime.InteropServices.Marshal.Copy(ra.Scan0, pa, 0, pa.Length);
            System.Runtime.InteropServices.Marshal.Copy(rb.Scan0, pb, 0, pb.Length);

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    byte va = (x < a.Width && y < a.Height) ? pa[y * ra.Stride + x * 4 + 2] : (byte)255; // R channel
                    byte vb = (x < b.Width && y < b.Height) ? pb[y * rb.Stride + x * 4 + 2] : (byte)255;
                    byte v = Math.Min(va, vb);
                    int idx = y * rr.Stride + x * 4;
                    pr[idx] = v;       // B
                    pr[idx + 1] = v;   // G
                    pr[idx + 2] = v;   // R
                    pr[idx + 3] = 255; // A
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pr, 0, rr.Scan0, pr.Length);
            a.UnlockBits(ra);
            b.UnlockBits(rb);
            result.UnlockBits(rr);

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

            #endregion

            // if there's no bodygroups to hide and not grey material, clean up and return
            if ((bodygroups_off.Count == 0) && (!Main.grey_material))
            {
                miscFunc.delete_safe(tfmv_dir + player_material.mat_dir + default_mat + ".vtf");
                miscFunc.delete_safe(tfmv_dir + player_material.mat_dir + default_mat + ".vmt");
                return;
            }

            #region group bodygroups by target material

            // every off bodygroup contributes its mask to default_mat. The
            // dict-of-lists structure is preserved (one entry today) so a future
            // per-bodygroup target-material override can drop in without
            // restructuring the loop below.
            Dictionary<string, List<string>> mat_to_bodygroups = new Dictionary<string, List<string>>();
            if (bodygroups_off.Count > 0)
            {
                mat_to_bodygroups[default_mat] = new List<string>(bodygroups_off);
            }
            else if (Main.grey_material)
            {
                // grey material with no bodygroups off — still need to process the default material
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
                    // grey material: replace RGB with flat grey, keep alpha from bodygroup mask
                    if (Main.grey_material)
                    {
                        vtf_edit.fill_rgb(vtf_bytes, 112, 114, 112);
                    }

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
                        // grey with no bodygroups off — VTF already filled grey by write_grey_material
                        continue;
                    }
                    else if ((bodygroups_for_mat.Count > 0) && (Main.grey_material))
                    {
                        // point to the modified VTF (grey RGB + alpha mask) and fall through
                        // to add transparency parameters
                        VMT.set_parameter(vmt_path, "basetexture", player_material.mat_dir.ToLower().Replace("materials\\models\\", "models\\") + mat_name + ".vtf");
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
