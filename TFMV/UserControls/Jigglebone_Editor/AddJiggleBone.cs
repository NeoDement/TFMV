using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



//TODO: A LOT OF THIS SHOULD BE PRIVATE!

//TODO: LIMIT TO THREE DECIMAL PLACES TO HIDE IMPRECISION! MAYBE ROUND UP NUMBERS THAT END IN .999! maybe done?

//TODO: WHEN WRITING JIGGLEBONE DATA, CONSIDER MOVING THEM ALL TO THE END OF THE FILE AND RE-POINTING THE OFFSETS! BECAUSE IS_BOING IS WRITING OVER 2 BYTES OF UNKNOWN DATA!!


namespace TFMV.UserControls.Jigglebone_Editor
{

    using ExtensionMethods;
    using Microsoft.JScript;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Threading;

    



    public partial class AddJiggleBone : Form
    {

        //used to stop hlmv from loading when it probably hasn't finished the last load yet



        //public Form form_AddJigglebone;

        
        [DllImport("User32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOACTIVATE = 0x0010;
        private const uint SWP_SHOWWINDOW = 0x0040;

        /*
        public Thread always_on_top_thread = new Thread(() =>
                {
                });
        */
        private System.Windows.Forms.Timer alwaysOnTopTimer;


        //a reference to the form that popped open this window, given to this in Model_Painter.cs
        public Form Main_Form;


        private Point NULL_PROPERTY_PANEL_LOCATION = new Point(1000, 1000); //out of bounds ;)
        private Point LEFT_PROPERTY_PANEL_LOCATION = new Point(12, 97);
        private Point RIGHT_PROPERTY_PANEL_LOCATION = new Point(232, 97);

        //ready_to_refresh is used to stop a refresh happening before we're done loading values
        private bool ready_to_refresh = false;

        //refresh_pending is used to refresh hlmv at the next available tick of the delay timer
        private bool refresh_pending = true;

        //FLAGS!!!
        public const int JIGGLE_IS_FLEXIBLE = 0x01;
        public const int JIGGLE_IS_RIGID = 0x02;
        public const int JIGGLE_HAS_YAW_CONSTRAINT = 0x04;
        public const int JIGGLE_HAS_PITCH_CONSTRAINT = 0x08;
        public const int JIGGLE_HAS_ANGLE_CONSTRAINT = 0x10;
        public const int JIGGLE_HAS_LENGTH_CONSTRAINT = 0x20;
        public const int JIGGLE_HAS_BASE_SPRING = 0x40;
        public const int JIGGLE_IS_BOING = 0x80;


        //TODO: this is a copy of the one in TFMV.Main and both should be moved to a more generic functions script

        //this method makes sure the user can't type invalid stuff into textboxes intended for numbers. allows . and - key presses.
        private void textBoxNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {

                // Allow digits, control keys (e.g., backspace), '.' and '-'
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
                    return;

                // Block all other inputs
                e.Handled = true;

            return;
        }



        public List<jiggleBone> allJiggleBones = new List<jiggleBone>();

        //currently loaded mdl
        public byte[] mdl_data = { };

        //currently loaded mdl path
        public string mdlpath = "";

        //original mdl data (we restore jigglebones from it) todo: better method?
        public string original_mdlpath = "";

        Process proc_HLMV;

        public AddJiggleBone()
        {
            InitializeComponent();

            alwaysOnTopTimer = new System.Windows.Forms.Timer();
            alwaysOnTopTimer.Interval = 1; // Adjust interval as needed
            alwaysOnTopTimer.Tick += AlwaysOnTopTimer_Tick;

            //todo: this should save like other checkboxes.
            if (chk_Always_On_Top.Checked)
            {
                alwaysOnTopTimer.Start();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddJiggleBone_Shown(object sender, EventArgs e)
        {
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }


        private string ReadNullTerminatedString(BinaryReader inputFileReader)
        {
            StringBuilder text = new StringBuilder();

            text.Length = 0;

            while (inputFileReader.PeekChar() > 0)
            {

                text.Append(inputFileReader.ReadChar());
            }

            //' Read the null character.

            try
            {
                inputFileReader.ReadChar();
            }
            catch (IOException)
            {
                //return "<INVALID>";
            }

            return text.ToString();

        }



        public void readJigglebones(string mdlpath)
        {



            //test item
            //          string filepath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\models\\workshop\\player\\items\\medic\\birdkeepers_brim\\birdkeepers_brim.mdl"; //NOTE WHEN YOU REMOVE THIS YOU NEED TO REMOVE IT ELSEWHERE IN THIS FILE TOO OR IT WONT SAVE HEX EDITED BONES CORRECTLY!

            //            MessageBox.Show(filepath);


            //clear any existing bones before we start
            lstBoneName.Items.Clear();
            allJiggleBones.Clear();

            string filepath = TFMV.Main.tmp_dir + mdlpath;

            //if (File.Exists(filepath))
            //{
                //todo: uncomment this
                //try
                //{
                //mdl_data = File.ReadAllBytes(filepath);


            using (var stream = File.Open(filepath, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
            {
                //156 is the offset to the bone count
                stream.Seek(156, SeekOrigin.Begin);
                int bone_count = reader.ReadInt32();

                //neodement: 160 is the offset to the first bone in the bone data(seems to always be 664)
                //156 is the offset to the bone count
                stream.Seek(160, SeekOrigin.Begin);
                int bone_offset = reader.ReadInt32();

                for (int i = 1; i <= bone_count; i++)
                {
                    //check if it's a jigglebone or not
                    //the 164th byte is the procedural bone type.
                    stream.Seek(bone_offset + 164, SeekOrigin.Begin);
                    int bone_type = reader.ReadInt32();

                    if (bone_type == 0x05) //if bone type is jigglebone (05), carry on.
                    {
                        stream.Seek(348, SeekOrigin.Begin);
                        int bone_names_list_offset = reader.ReadInt32();

                        stream.Seek(bone_offset, SeekOrigin.Begin);

                        int bone_name_offset = reader.ReadInt32() + bone_offset; //the first int32 in each bone is the offset to its entry in the name table

                        stream.Seek(bone_name_offset, SeekOrigin.Begin);
                        string bone_name = ReadNullTerminatedString(reader);

                        stream.Seek(bone_offset + 168, SeekOrigin.Begin);
                        int jiggleboneDataOffset = reader.ReadInt32() + bone_offset;

                        //make a new serialized jigglebone object to set params
                        jiggleBone theJiggleBone = new jiggleBone
                        {
                            Name = bone_name,
                            Offset = jiggleboneDataOffset
                        };

                        stream.Seek(theJiggleBone.Offset, SeekOrigin.Begin);
                        theJiggleBone.getFlags(reader.ReadInt32());

                        theJiggleBone.length = reader.ReadSingle();
                        theJiggleBone.tipMass = reader.ReadSingle();
                        theJiggleBone.yawStiffness = reader.ReadSingle();
                        theJiggleBone.yawDamping = reader.ReadSingle();
                        theJiggleBone.pitchStiffness = reader.ReadSingle();
                        theJiggleBone.pitchDamping = reader.ReadSingle();
                        theJiggleBone.alongStiffness = reader.ReadSingle();
                        theJiggleBone.alongDamping = reader.ReadSingle();
                        theJiggleBone.angleLimit = reader.ReadSingle();
                        theJiggleBone.yawConstraintMin = reader.ReadSingle();
                        theJiggleBone.yawConstraintMax = reader.ReadSingle();
                        theJiggleBone.yawFriction = reader.ReadSingle();
                        theJiggleBone.yawBounce = reader.ReadSingle();
                        theJiggleBone.pitchConstraintMin = reader.ReadSingle();
                        theJiggleBone.pitchConstraintMax = reader.ReadSingle();
                        theJiggleBone.pitchFriction = reader.ReadSingle();
                        theJiggleBone.pitchBounce = reader.ReadSingle();
                        theJiggleBone.baseMass = reader.ReadSingle();
                        theJiggleBone.baseStiffness = reader.ReadSingle();
                        theJiggleBone.baseDamping = reader.ReadSingle();
                        theJiggleBone.baseLeftConstraintMin = reader.ReadSingle();
                        theJiggleBone.baseLeftConstraintMax = reader.ReadSingle();
                        theJiggleBone.baseLeftFriction = reader.ReadSingle();
                        theJiggleBone.baseUpConstraintMin = reader.ReadSingle();
                        theJiggleBone.baseUpConstraintMax = reader.ReadSingle();
                        theJiggleBone.baseUpFriction = reader.ReadSingle();
                        theJiggleBone.baseForwardConstraintMin = reader.ReadSingle();
                        theJiggleBone.baseForwardConstraintMax = reader.ReadSingle();
                        theJiggleBone.baseForwardFriction = reader.ReadSingle();

                        //todo: is_boing params. DO NOT READ if file wasn't compiled with isBoing or you'll read past the jigglebone data!

                        //todo: this is (possibly) incorrect! there are 2 types of jigglebone and 2 subproperties!

                        if (theJiggleBone.isBoing)
                        {
                            theJiggleBone.boingImpactSpeed = reader.ReadSingle();
                            theJiggleBone.boingImpactAngle = reader.ReadSingle();
                            theJiggleBone.boingDampingRate = reader.ReadSingle();
                            theJiggleBone.boingFrequency = reader.ReadSingle();
                            theJiggleBone.boingAmplitude = reader.ReadSingle();
                        }
                        //todo: need proper defaults for all values
                        else
                        {
                            theJiggleBone.boingImpactSpeed = 0;
                            theJiggleBone.boingImpactAngle = (float)Math.Cos(0);
                            theJiggleBone.boingDampingRate = 0;
                            theJiggleBone.boingFrequency = 0;
                            theJiggleBone.boingAmplitude = 0;
                        }

                        //add the jigglebone to the list of jigglebones, accessed by the Bone Name combobox. update combobox at same time so the indexes stay in sync
                        allJiggleBones.Add(theJiggleBone);
                        lstBoneName.Items.Add(theJiggleBone.Name);
                    }

                    bone_offset += 216; // Move to the next bone
                }
            }



            if (lstBoneName.Items.Count == 0)
            {
                Main_Form.Enabled = true;
                this.Close();
                MessageBox.Show("No jigglebones found on model:" + "\n\n" + mdlpath);
                return;
            }

            lstBoneName.SelectedIndex = 0;

            this.Show();



            /*
            //todo: move this somewhere else, like form_load
            always_on_top_thread = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        if (chk_Always_On_Top.Checked)
                        {
                            //this.Invoke(new MethodInvoker(delegate { this.TopMost = true; }));
                            this.TopMost = true;
                            //this.Invoke((MethodInvoker)(delegate { this.TopMost = true; }));
                            //SetWindowPos(this.Handle, Main.proc_HLMV.MainWindowHandle, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE | SWP_NOACTIVATE);
                        }
                        Thread.Sleep(1);
                    }
                }
                catch (Exception ex) { }
            });


            always_on_top_thread.Start();
            */

        }



        [Serializable]
        public class jiggleBone
        {
            public int Offset { get; set; }

            public string Name { get; set; }

            //rotational property groups
            public bool isRigid { get; set; }
            public bool isFlexible { get; set; }

            //translational property groups
            public bool hasBaseSpring { get; set; }
            public bool isBoing { get; set; }




            public bool hasYawConstraint { get; set; }
            public bool hasPitchConstraint { get; set; }
            public bool hasAngleConstraint { get; set; }
            public bool hasLengthConstraint { get; set; }



            public Single length { get; set; }
            public Single tipMass { get; set; }

            public Single yawStiffness { get; set; }
            public Single yawDamping { get; set; }

            public Single pitchStiffness { get; set; }
            public Single pitchDamping { get; set; }

            public Single alongStiffness { get; set; }
            public Single alongDamping { get; set; }

            public Single angleLimit { get; set; }

            public Single yawConstraintMin { get; set; }
            public Single yawConstraintMax { get; set; }
            public Single yawFriction { get; set; } //todo: this ALSO seems to be unimplemented?? possibly hide both these unused things?? triple check!
            public Single yawBounce { get; set; } //pretty sure this is unimplemented, but store it anyway. maybe add a checkbox to show it

            public Single pitchConstraintMin { get; set; }
            public Single pitchConstraintMax { get; set; }
            public Single pitchFriction { get; set; } //todo: this ALSO seems to be unimplemented?? possibly hide both these unused things?? triple check!
            public Single pitchBounce { get; set; } //pretty sure this is unimplemented, but store it anyway. maybe add a checkbox to show it



            //has base spring!
            public Single baseMass { get; set; }

            public Single baseStiffness { get; set; }
            public Single baseDamping { get; set; }

            public Single baseLeftConstraintMin { get; set; }
            public Single baseLeftConstraintMax { get; set; }

            public Single baseLeftFriction { get; set; }

            public Single baseUpConstraintMin { get; set; }
            public Single baseUpConstraintMax { get; set; }

            public Single baseUpFriction { get; set; }

            public Single baseForwardConstraintMin { get; set; }
            public Single baseForwardConstraintMax { get; set; }

            public Single baseForwardFriction { get; set; }

            //NOTE: These fields seem to be only in models compiled with Source SDK Base 2013 MP and SP.
            //(might be important for a non-tf2 version of this?)

            //MORE IMPORTANT NOTE: If a model isn't compiled with boing jigglebones, it won't have the extra bytes required for those properties. so we are probably reading unknown data.

            public Single boingImpactSpeed { get; set; }
            public Single boingImpactAngle { get; set; }

            public Single boingDampingRate { get; set; }
            public Single boingFrequency { get; set; }
            public Single boingAmplitude { get; set; }


            //method to get all the jigglebone flags from the flags int
            public void getFlags(int jiggleFlags)
            {

                if ((jiggleFlags & JIGGLE_IS_FLEXIBLE) > 0)
                {
                    isRigid = false;
                    isFlexible = true;
                }
                else if ((jiggleFlags & JIGGLE_IS_RIGID) > 0)
                {
                    isRigid = true;
                    isFlexible = false;
                }
                //todo: this is incorrect! there are 2 types of jigglebone and 2 subproperties!
                if ((jiggleFlags & JIGGLE_HAS_BASE_SPRING) > 0)
                {
                    hasBaseSpring = true;
                    isBoing = false;
                }
                //probably a jigglebone that only has base spring or is boing
                else if ((jiggleFlags & JIGGLE_IS_BOING) > 0)
                {
                    hasBaseSpring = false;
                    isBoing = true;
                }


                if ((jiggleFlags & JIGGLE_HAS_YAW_CONSTRAINT) > 0)
                {
                    hasYawConstraint = true;
                }

                if ((jiggleFlags & JIGGLE_HAS_PITCH_CONSTRAINT) > 0)
                {
                    hasPitchConstraint = true;
                }

                if ((jiggleFlags & JIGGLE_HAS_ANGLE_CONSTRAINT) > 0)
                {
                    hasAngleConstraint = true;
                }

                if ((jiggleFlags & JIGGLE_HAS_LENGTH_CONSTRAINT) > 0)
                {
                    hasLengthConstraint = true;
                }

            }



            //funky extra properties for offset of this jigglebones start and end in the qc textbox
            public int QC_START { get; set; } = 0;

            public int QC_END { get; set; } = 0;



        }



        private void AddJiggleBone_Load(object sender, EventArgs e)
        {
        }

        private void lstBoneName_SelectedIndexChanged(object sender, EventArgs e)
        {
                                              
            jiggleBone theJiggleBone = allJiggleBones[lstBoneName.SelectedIndex];


            //JIGGLEBONE NAME
            //lstBoneName.Text = theJiggleBone.Name;



            //todo: this works but seems like a dumb way of locking the values?
            ready_to_refresh = false;


            //JIGGLE TYPE
            //lstJiggleType.SelectedIndex = Convert.ToInt32(theJiggleBone.jiggleType);
            if (theJiggleBone.isRigid)
            {
                chk_isRigid.Checked = true;
                chk_isFlexible.Checked = false;
            }
            else if (theJiggleBone.isFlexible)
            {
                chk_isRigid.Checked = false;
                chk_isFlexible.Checked = true;
            }
            else
            {
                chk_isRigid.Checked = false;
                chk_isFlexible.Checked = false;
            }

            if (theJiggleBone.hasBaseSpring)
            {
                chk_hasBaseSpring.Checked = true;
                chk_isBoing.Checked = false;
            }
            else if(theJiggleBone.isBoing)
            {
                chk_hasBaseSpring.Checked = false;
                chk_isBoing.Checked = true;
            }
            else
            {
                chk_hasBaseSpring.Checked = false;
                chk_isBoing.Checked = false;
            }






            //GENERAL
            txtLength.SetNumber(theJiggleBone.length);
            txtTipMass.SetNumber(theJiggleBone.tipMass);

            chkAngleConstraint.Checked = theJiggleBone.hasAngleConstraint;
            txtAngleConstraint.SetNumber(theJiggleBone.angleLimit, true); // in radians

            //YAW
            txtYawStiffness.SetNumber(theJiggleBone.yawStiffness);
            txtYawDamping.SetNumber(theJiggleBone.yawDamping);

            chkYawConstraint.Checked = theJiggleBone.hasYawConstraint;
            txtYawConstraintMin.SetNumber(theJiggleBone.yawConstraintMin, true); // in radians
            txtYawConstraintMax.SetNumber(theJiggleBone.yawConstraintMax, true); // in radians

            //chkYawFriction.Checked = false;
            txtYawFriction.SetNumber(theJiggleBone.yawFriction);


            //PITCH
            txtPitchStiffness.SetNumber(theJiggleBone.pitchStiffness);
            txtPitchDamping.SetNumber(theJiggleBone.pitchDamping);

            chkPitchConstraint.Checked = theJiggleBone.hasPitchConstraint;
            txtPitchConstraintMin.SetNumber(theJiggleBone.pitchConstraintMin, true); // in radians
            txtPitchConstraintMax.SetNumber(theJiggleBone.pitchConstraintMax, true); // in radians

            //chkPitchFriction.Checked = false;
            txtPitchFriction.SetNumber(theJiggleBone.pitchFriction);


            //ALONG
            txtAlongStiffness.SetNumber(theJiggleBone.alongStiffness);
            txtAlongDamping.SetNumber(theJiggleBone.alongDamping);

            ///////////////////////////
            ///BASE SPRING PARAMS!!! //
            ///////////////////////////


            chkHasBaseSpring.Checked = theJiggleBone.hasBaseSpring;

            if (chkHasBaseSpring.Checked)
            {
                chkHasBaseSpring.Checked = theJiggleBone.hasBaseSpring;

                //GENERAL
                txtBaseStiffness.SetNumber(theJiggleBone.baseStiffness);
                txtBaseDamping.SetNumber(theJiggleBone.baseDamping);

                txtBaseBaseMass.SetNumber(theJiggleBone.baseMass);

                //LEFT_CONSTRAINT
                txtBaseLeftConstraintMin.SetNumber(theJiggleBone.baseLeftConstraintMin);
                txtBaseLeftConstraintMax.SetNumber(theJiggleBone.baseLeftConstraintMax);

                txtBaseLeftFriction.SetNumber(theJiggleBone.baseLeftFriction);

                //UP_CONSTRAINT
                txtBaseUpConstraintMin.SetNumber(theJiggleBone.baseUpConstraintMin);
                txtBaseUpConstraintMax.SetNumber(theJiggleBone.baseUpConstraintMax);

                txtBaseLeftFriction.SetNumber(theJiggleBone.baseLeftFriction);

                //FORWARD_CONSTRAINT
                txtBaseForwardConstraintMin.SetNumber(theJiggleBone.baseForwardConstraintMin);
                txtBaseForwardConstraintMax.SetNumber(theJiggleBone.baseForwardConstraintMax);

                txtBaseForwardFriction.SetNumber(theJiggleBone.baseForwardFriction);

            }


            ///////////////////////////
            ///   BOING PARAMS!!!   ///
            ///////////////////////////

            txtBoingImpactSpeed.SetNumber(theJiggleBone.boingImpactSpeed);
            txtBoingImpactAngle.SetNumber(theJiggleBone.boingImpactAngle, true, true); //run cosine on the degrees and then convert to radians

            txtBoingDampingRate.SetNumber(theJiggleBone.boingDampingRate);

            txtBoingFrequency.SetNumber(theJiggleBone.boingFrequency);
            txtBoingAmplitude.SetNumber(theJiggleBone.boingAmplitude);


            //done! let auto-refreshing commence.
            ready_to_refresh = true;

            evaluate_Jigglebone_Property_Groups(); //todo: testing if this works

            //todo: disabled... for now?
            //get that timer ticking too.
            //hlmv_refresh_delay.Start();


        }


        private void jigglePropertyChanged(object sender, EventArgs e)
        {

            //if there are no bones loaded, don't do anything!
            if(lstBoneName.SelectedIndex == -1)
            {
                return;
            }

            //MessageBox.Show("if control equals controlname, set whichever relevant jigglebone property on the live model");

            // Properties ob =  (Object)sender;
            string obj_name = "";
            string arg = "";

            if (sender.GetType() == typeof(CheckBox))
            {
                CheckBox obj = (CheckBox)sender;
                obj_name = obj.Name.ToString();
                arg = obj.Checked.ToString();
            }

            if (sender.GetType() == typeof(TextBox))
            {
                TextBox obj = (TextBox)sender;
                obj_name = obj.Name.ToString();
                arg = obj.Text.ToString();
            }

            //todo: ugh...
            if (sender.GetType() == typeof(DeviceCtrlLibrary.NumericUpDown_CustomFormat))
            {
                DeviceCtrlLibrary.NumericUpDown_CustomFormat obj = (DeviceCtrlLibrary.NumericUpDown_CustomFormat)sender;
                obj_name = obj.Name.ToString();
                arg = obj.Text.ToString();
            }

            /*
            if (sender.GetType() == typeof(NumericUpDown))
            {
                NumericUpDown obj = (NumericUpDown)sender;
                obj_name = obj.Name.ToString();
                arg = obj.Text.ToString();
            }
            */

            jiggleBone theJiggleBone = allJiggleBones[lstBoneName.SelectedIndex];


            //todo: where is pitch/yaw friction and bounce? are you missing anything else??


            switch (obj_name)
            {
                //case 


                //GENERAL
                case "txtLength":
                    theJiggleBone.length = txtLength.GetNumber(false);
                    break;
                case "txtTipMass":
                    theJiggleBone.tipMass = txtTipMass.GetNumber(false);
                    break;

                //ANGLE
                case "chkAngleConstraint":
                    theJiggleBone.hasAngleConstraint = chkAngleConstraint.Checked;
                    break;
                case "txtAngleConstraint":
                    theJiggleBone.angleLimit = txtAngleConstraint.GetNumber(true); // in radians
                    break;

                //YAW
                case "txtYawStiffness":
                    theJiggleBone.yawStiffness = txtYawStiffness.GetNumber(false);
                    break;
                case "txtYawDamping":
                    theJiggleBone.yawDamping = txtYawDamping.GetNumber(false);
                    break;


                case "chkYawConstraint":
                    theJiggleBone.hasYawConstraint = chkYawConstraint.Checked;
                    break;

                case "txtYawConstraintMin":
                    theJiggleBone.yawConstraintMin = txtYawConstraintMin.GetNumber(true); // in radians
                    break;
                case "txtYawConstraintMax":
                    theJiggleBone.yawConstraintMax = txtYawConstraintMax.GetNumber(true); // in radians
                    break;

                //PITCH
                case "txtPitchStiffness":
                    theJiggleBone.pitchStiffness = txtPitchStiffness.GetNumber(false);
                    break;
                case "txtPitchDamping":
                    theJiggleBone.pitchDamping = txtPitchDamping.GetNumber(false);
                    break;


                case "chkPitchConstraint":
                    theJiggleBone.hasPitchConstraint = chkPitchConstraint.Checked;
                    break;

                case "txtPitchConstraintMin":
                    theJiggleBone.pitchConstraintMin = txtPitchConstraintMin.GetNumber(true); // in radians
                    break;
                case "txtPitchConstraintMax":
                    theJiggleBone.pitchConstraintMax = txtPitchConstraintMax.GetNumber(true); // in radians
                    break;


                //ALONG
                case "txtAlongStiffness":
                    theJiggleBone.alongStiffness = txtAlongStiffness.GetNumber(false);
                    break;
                case "txtAlongDamping":
                    theJiggleBone.alongDamping = txtAlongDamping.GetNumber(false);
                    break;


                ///////////////////////////
                ///BASE SPRING PARAMS!!! //
                ///////////////////////////
                case "chkHasBaseSpring":
                    theJiggleBone.hasBaseSpring = chkHasBaseSpring.Checked;

                    //disable all controls relating to base spring if it's unchecked
                    grp_HAS_BASE_SPRING.Enabled = chkHasBaseSpring.Checked;

                    break;

                //GENERAL
                case "txtBaseStiffness":
                    theJiggleBone.baseStiffness = txtBaseStiffness.GetNumber(false);
                    break;
                case "txtBaseDamping":
                    theJiggleBone.baseDamping = txtBaseDamping.GetNumber(false);
                    break;

                case "txtBaseBaseMass":
                    theJiggleBone.baseMass = txtBaseBaseMass.GetNumber(false);
                    break;

                //LEFT
                case "txtBaseLeftConstraintMin":
                    theJiggleBone.baseLeftConstraintMin = txtBaseLeftConstraintMin.GetNumber(false);
                    break;
                case "txtBaseLeftConstraintMax":
                    theJiggleBone.baseLeftConstraintMax = txtBaseLeftConstraintMax.GetNumber(false);
                    break;

                case "txtBaseLeftFriction":
                    theJiggleBone.baseLeftFriction = txtBaseLeftFriction.GetNumber(false);
                    break;

                //UP
                case "txtBaseUpConstraintMin":
                    theJiggleBone.baseUpConstraintMin = txtBaseUpConstraintMin.GetNumber(false);
                    break;
                case "txtBaseUpConstraintMax":
                    theJiggleBone.baseUpConstraintMax = txtBaseUpConstraintMax.GetNumber(false);
                    break;

                case "txtBaseUpFriction":
                    theJiggleBone.baseUpFriction = txtBaseUpFriction.GetNumber(false);
                    break;

                //FORWARD
                case "txtBaseForwardConstraintMin":
                    theJiggleBone.baseForwardConstraintMin = txtBaseForwardConstraintMin.GetNumber(false);
                    break;
                case "txtBaseForwardConstraintMax":
                    theJiggleBone.baseForwardConstraintMax = txtBaseForwardConstraintMax.GetNumber(false);
                    break;

                case "txtBaseForwardFriction":
                    theJiggleBone.baseForwardFriction = txtBaseForwardFriction.GetNumber(false);
                    break;

                ///////////////////////////
                ///   BOING PARAMS!!!   ///
                ///////////////////////////
                case "txtBoingImpactSpeed":
                    theJiggleBone.boingImpactSpeed = txtBoingImpactSpeed.GetNumber(false);
                    break;
                case "txtBoingImpactAngle":
                    theJiggleBone.boingImpactAngle = txtBoingImpactAngle.GetNumber(true, true);  //run radians to degrees on the inverse cosine of the bone
                    break;
                    
                case "txtBoingDampingRate":
                    theJiggleBone.boingDampingRate = txtBoingDampingRate.GetNumber(false);
                    break;

                case "txtBoingFrequency":
                    theJiggleBone.boingFrequency = txtBoingFrequency.GetNumber(false);
                    break;
                case "txtBoingAmplitude":
                    theJiggleBone.boingAmplitude = txtBoingAmplitude.GetNumber(false);
                    break;

            }

            UpdateQC();


            /*
            //refresh_pending is used to refresh hlmv at the next available tick of the delay timer
            refresh_pending = true;


            if (chk_Auto_Apply.Checked)
            {
                WriteJiggleBoneToFile();


                //annoying system to make sure hlmv doesn't get spammed with too many F5 requests (it buffers them for some reason)
                //it will always refresh to the latest version of the model when the timer goes off, if there is a new version of the model pending
                if (ready_to_refresh)
                {
                    ready_to_refresh = false;
                    hlmv_refresh_delay.Stop();
                    hlmv_refresh_delay.Start();

                    TFMV.Main.refresh_hlmv(false);

                    refresh_pending = false;
                }

            }
            */


        }



        private string WriteJiggleBoneConstraints(jiggleBone theJiggleBone)
        {

            //bit easier to read than \t \r\n repeatedly
            string Tab = "\t";
            string NewLine = "\r\n";


            string line = "";

            //extra QC_output to insert at the end of the existing one
            string QC_output = "";

            if (theJiggleBone.hasPitchConstraint)
            {
                line = Tab;

                line += Tab;
                line += "pitch_constraint ";

                line += SingleToString(theJiggleBone.pitchConstraintMin, true);  // in radians

                line += " ";

                line += SingleToString(theJiggleBone.pitchConstraintMax, true);  // in radians


                line += NewLine;
                QC_output += line;

                line = Tab;

                line += Tab;
                line += "pitch_friction ";

                line += theJiggleBone.pitchFriction;

                line += NewLine;
                QC_output += line;

                line = Tab;

                line += Tab;
                line += "pitch_bounce ";

                line += theJiggleBone.pitchBounce;

                line += NewLine;
                QC_output += line;
            }

            if (theJiggleBone.hasYawConstraint)
            {
                line = Tab;

                line += Tab;
                line += "yaw_constraint ";

                line += SingleToString(theJiggleBone.yawConstraintMin, true);  // in radians

                line += " ";

                line += SingleToString(theJiggleBone.yawConstraintMax, true);  // in radians

                line += NewLine;
                QC_output += line;

                line = Tab;

                line += Tab;
                line += "yaw_friction ";

                line += theJiggleBone.yawFriction;

                line += NewLine;
                QC_output += line;

                line = Tab;

                line += Tab;
                line += "yaw_bounce ";

                line += theJiggleBone.yawBounce;

                line += NewLine;
                QC_output += line;
            }

            if (theJiggleBone.hasAngleConstraint)
            {
                line = Tab;

                line += Tab;
                line += "angle_constraint ";

                line += SingleToString(theJiggleBone.angleLimit, true); // in radians

                line += NewLine;
                QC_output += line;
            }

            return QC_output;
        }


        private void UpdateQC()
        {
            //bit easier to read than \t \" \r\n repeatedly
            string Tab = "\t";
            string Quote = "\"";
            string NewLine = "\r\n";


            string QC_output = "";


            //we can finally get qc params out of this!

            //iterate thru all jigglebones!!!
            for (var i = 0; i < allJiggleBones.Count; i++)
            {
                jiggleBone theJiggleBone = allJiggleBones[i];

                //remember where this bone starts so we can select it with the button
                theJiggleBone.QC_START = QC_output.Length;


                string line = "$jigglebone ";

                line += "\"";
                line += theJiggleBone.Name;
                line += Quote;

                line += NewLine;
                QC_output += line;

                line = "{";

                line += NewLine;
                QC_output += line;

                if (theJiggleBone.isFlexible)
                {
                    line = Tab;

                    line += "is_flexible";

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += "{";

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "length ";

                    line += theJiggleBone.length;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "tip_mass ";

                    line += theJiggleBone.tipMass;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "pitch_stiffness ";

                    line += theJiggleBone.pitchStiffness;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "pitch_damping ";

                    line += theJiggleBone.pitchDamping;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "yaw_stiffness ";

                    line += theJiggleBone.yawStiffness;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "yaw_damping ";

                    line += theJiggleBone.yawDamping;

                    line += NewLine;
                    QC_output += line;

                    if (!theJiggleBone.hasLengthConstraint)
                    {
                        line = Tab;

                        line += Tab;

                        line += "allow_length_flex";

                        line += NewLine;
                        QC_output += line;
                    }

                    line = Tab;

                    line += Tab;

                    line += "along_stiffness ";

                    line += theJiggleBone.alongStiffness;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "along_damping ";

                    line += theJiggleBone.alongDamping;

                    line += NewLine;
                    QC_output += line;

                    QC_output += WriteJiggleBoneConstraints(theJiggleBone);


                    line = Tab;

                    line += "}";

                    line += NewLine;
                    QC_output += line;
                }

                if (theJiggleBone.isRigid)
                {
                    line = Tab;

                    line += "is_rigid";

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += "{";

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "length ";

                    line += theJiggleBone.length;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "tip_mass ";

                    line += theJiggleBone.tipMass;

                    line += NewLine;
                    QC_output += line;

                    QC_output += WriteJiggleBoneConstraints(theJiggleBone);



                    line = Tab;

                    line += "}";

                    line += NewLine;
                    QC_output += line;
                }

                if (theJiggleBone.hasBaseSpring)
                {
                    line = Tab;

                    line += "has_base_spring";

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += "{";

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "base_mass ";

                    line += theJiggleBone.baseMass;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "stiffness ";

                    line += theJiggleBone.baseStiffness;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "damping ";

                    line += theJiggleBone.baseDamping;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "left_constraint ";

                    //old junk from Crowbar
                    //'line += MathModule.RadiansToDegrees(theJiggleBone.baseMinLeft);

                    //'line += " "

                    //'line += MathModule.RadiansToDegrees(theJiggleBone.baseMaxLeft);

                    //todo: so do these need to converted?
                    line += SingleToString(theJiggleBone.baseLeftConstraintMin, true);

                    line += " ";

                    line += SingleToString(theJiggleBone.baseLeftConstraintMax, true);

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "left_friction ";

                    line += SingleToString(theJiggleBone.baseLeftFriction);

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "up_constraint ";

                    //old junk from crowbar
                    //'line += MathModule.RadiansToDegrees(theJiggleBone.baseMinUp);

                    //'line += " "

                    //'line += MathModule.RadiansToDegrees(theJiggleBone.baseMaxUp);

                    line += SingleToString(theJiggleBone.baseUpConstraintMin, true);

                    line += " ";

                    line += SingleToString(theJiggleBone.baseUpConstraintMax, true);

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "up_friction ";

                    line += theJiggleBone.baseUpFriction;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "forward_constraint ";

                    //old junk from crowbar
                    //'line += MathModule.RadiansToDegrees(theJiggleBone.baseMinForward);

                    //'line += " "

                    //'line += MathModule.RadiansToDegrees(theJiggleBone.baseMaxForward);

                    line += SingleToString(theJiggleBone.baseForwardConstraintMin, true);

                    line += " ";

                    line += SingleToString(theJiggleBone.baseForwardConstraintMax, true);

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "forward_friction ";

                    line += SingleToString(theJiggleBone.baseForwardFriction);

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += "}";

                    line += NewLine;
                    QC_output += line;
                }

                if (theJiggleBone.isBoing)
                {
                    line = Tab;

                    line += "is_boing";

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += "{";

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "impact_speed ";

                    line += SingleToString(theJiggleBone.boingImpactSpeed);

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "impact_angle ";

                    line += SingleToString(theJiggleBone.boingImpactAngle, true, true); //run cosine on the degrees and then convert to radians

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "damping_rate ";

                    line += theJiggleBone.boingDampingRate;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "frequency ";

                    line += theJiggleBone.boingFrequency;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += Tab;

                    line += "amplitude ";

                    line += theJiggleBone.boingAmplitude;

                    line += NewLine;
                    QC_output += line;

                    line = Tab;

                    line += "}";

                    line += NewLine;
                    QC_output += line;
                }

                line = "}";

                line += NewLine;
                QC_output += line;


                //remember where this bone ends so we can select it with the button
                theJiggleBone.QC_END = QC_output.Length;




            }

            txt_QC.Text = QC_output;
        }






        //todo: this should probably say jiggleBONES...?
        private void WriteJiggleBoneToFile()
        {

            string filepath = TFMV.Main.tfmv_dir + mdlpath;

            //todo: REMOVE THIS!
            //string filepath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\models\\workshop\\player\\items\\medic\\birdkeepers_brim\\birdkeepers_brim.mdl";

            //MessageBox.Show(filepath);

            //create the file if it doesn't exist before you write to it
            if (!File.Exists(filepath))
                {
                    File.WriteAllBytes(filepath, mdl_data);
                    //MessageBox.Show("wrote a file to " + filepath);
                }

                using (var stream = File.Open(filepath, FileMode.Open))
                {
                    using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                    {

                    //iterate thru all jigglebones!!!
                    for (var i = 0; i < allJiggleBones.Count; i++)
                    {
                        jiggleBone theJiggleBone = allJiggleBones[i];



                        //seek to the start of the jigglebone data before you start writing
                        writer.BaseStream.Position = theJiggleBone.Offset;


                        //calculate the flags
                        int flags = 0;



                        if (theJiggleBone.isRigid)
                        {
                            flags = JIGGLE_IS_RIGID;
                        }
                        else if (theJiggleBone.isFlexible)
                        {
                            flags = JIGGLE_IS_FLEXIBLE;
                        }

                        if (theJiggleBone.isBoing)
                        {
                            flags = JIGGLE_IS_BOING;
                        }
                        else if (theJiggleBone.hasBaseSpring)
                        {
                            flags += JIGGLE_HAS_BASE_SPRING;
                        }

                        if (theJiggleBone.hasYawConstraint)
                        {
                            flags += JIGGLE_HAS_YAW_CONSTRAINT;
                        }

                        if (theJiggleBone.hasPitchConstraint)
                        {
                            flags += JIGGLE_HAS_PITCH_CONSTRAINT;
                        }

                        if (theJiggleBone.hasAngleConstraint)
                        {
                            flags += JIGGLE_HAS_ANGLE_CONSTRAINT;
                        }

                        if (theJiggleBone.hasLengthConstraint)
                        {
                            flags += JIGGLE_HAS_LENGTH_CONSTRAINT;
                        }

                        //write the flags
                        writer.Write(flags);

                        writer.Write(theJiggleBone.length);

                        writer.Write(theJiggleBone.tipMass);

                        writer.Write(theJiggleBone.yawStiffness);



                        writer.Write(theJiggleBone.yawDamping);

                        writer.Write(theJiggleBone.pitchStiffness);

                        writer.Write(theJiggleBone.pitchDamping);

                        writer.Write(theJiggleBone.alongStiffness);

                        writer.Write(theJiggleBone.alongDamping);


                        writer.Write(theJiggleBone.angleLimit);


                        writer.Write(theJiggleBone.yawConstraintMin);

                        writer.Write(theJiggleBone.yawConstraintMax);

                        writer.Write(theJiggleBone.yawFriction);

                        writer.Write(theJiggleBone.yawBounce);


                        writer.Write(theJiggleBone.pitchConstraintMin);

                        writer.Write(theJiggleBone.pitchConstraintMax);

                        writer.Write(theJiggleBone.pitchFriction);

                        writer.Write(theJiggleBone.pitchBounce);


                        writer.Write(theJiggleBone.baseMass);

                        writer.Write(theJiggleBone.baseStiffness);

                        writer.Write(theJiggleBone.baseDamping);


                        writer.Write(theJiggleBone.baseLeftConstraintMin);

                        writer.Write(theJiggleBone.baseLeftConstraintMax);

                        writer.Write(theJiggleBone.baseLeftFriction);


                        writer.Write(theJiggleBone.baseUpConstraintMin);

                        writer.Write(theJiggleBone.baseUpConstraintMax);

                        writer.Write(theJiggleBone.baseUpFriction);


                        writer.Write(theJiggleBone.baseForwardConstraintMin);

                        writer.Write(theJiggleBone.baseForwardConstraintMax);

                        writer.Write(theJiggleBone.baseForwardFriction);


                        writer.Write(theJiggleBone.boingImpactAngle);

                        writer.Write(theJiggleBone.boingImpactSpeed);


                        writer.Write(theJiggleBone.boingDampingRate);


                        writer.Write(theJiggleBone.boingFrequency);

                        writer.Write(theJiggleBone.boingAmplitude);


                    }

                }

            }

        }




        //applied jigglebones, show them in hlmv!
        private void btnApplyJigglebones_Click(object sender, EventArgs e)
        {
            WriteJiggleBoneToFile();
            TFMV.Main.refresh_hlmv(false);
        }

        private void lstJiggleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            //currently selected jigglebone
            jiggleBone theJiggleBone = allJiggleBones[lstBoneName.SelectedIndex];

            //enable these by default, isBoing overrides
            chkHasBaseSpring.Enabled = true;
            grpHasBaseSpring.Enabled = true;

            switch (lstJiggleType.SelectedIndex)
            {
                case 0: //none
                    theJiggleBone.jiggleType = JiggleType.none;
                    break;

                case 1: //is_flexible
                    theJiggleBone.jiggleType = JiggleType.isFlexible;
                break;

                case 2: //is_rigid
                    theJiggleBone.jiggleType = JiggleType.isRigid;
                    break;

                //todo: this is incorrect! there are 2 types of jigglebone and 2 subproperties!
                case 3: //is_boing
                    theJiggleBone.jiggleType = JiggleType.isBoing;
                    chkHasBaseSpring.Enabled = false;
                    grpHasBaseSpring.Enabled = false;
                    break;
            }
            */
        }




        private void evaluate_Jigglebone_Property_Groups()
        {

            if (!ready_to_refresh)
            {
                return; //todo: quick fix attempt...
            }

            //currently selected jigglebone
            jiggleBone theJiggleBone = allJiggleBones[lstBoneName.SelectedIndex];


            if (chk_isRigid.Checked)
            {
                theJiggleBone.isRigid = true;
                theJiggleBone.isFlexible = false;

                //todo: set up ui!
            }
            else if (chk_isFlexible.Checked)
            {
                theJiggleBone.isRigid = false;
                theJiggleBone.isFlexible = true;

                //todo: set up ui!
            }
            else
            {
                theJiggleBone.isRigid = false;
                theJiggleBone.isFlexible = false;

                //todo: set up ui!
            }



            if (chk_hasBaseSpring.Checked)
            {
                theJiggleBone.hasBaseSpring = true;
                theJiggleBone.isBoing = false;

                //todo: set up ui!
            }
            else if (chk_isBoing.Checked)
            {
                theJiggleBone.hasBaseSpring = false;
                theJiggleBone.isBoing = true;

                //todo: set up ui!
            }
            else
            {
                theJiggleBone.hasBaseSpring = false;
                theJiggleBone.isBoing = false;

                //todo: set up ui!
            }


        }



        //handle property groups so you can't select any that don't work together
        private void chk_isRigid_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_isRigid.Checked)
            {
                chk_isFlexible.Checked = false;

                lbl_IS_FLEXIBLE.Text = "IS_RIGID";

                //allow length flex
                chkAllowLengthFlex.Enabled = false;

                //pitch
                btnPitchStiffness.Enabled = false;
                lblPitchStiffness.Enabled = false;
                txtPitchStiffness.Enabled = false;

                btnPitchDamping.Enabled = false;
                lblPitchDamping.Enabled = false;
                txtPitchDamping.Enabled = false;

                //yaw
                btnYawStiffness.Enabled = false;
                lblYawStiffness.Enabled = false;
                txtYawStiffness.Enabled = false;

                btnYawDamping.Enabled = false;
                lblYawDamping.Enabled = false;
                txtYawDamping.Enabled = false;

                //along
                lbl_Along.Enabled = false;
                grp_Along.Enabled = false;

                //make sure we can see it
                grp_IS_FLEXIBLE.Location = LEFT_PROPERTY_PANEL_LOCATION;


                //chk_isFlexible.Enabled = false;
            }
            else
            {
                //only hide this panel if both variants of it aren't being used
                if (!chk_isFlexible.Checked)
                {
                    grp_IS_FLEXIBLE.Location = NULL_PROPERTY_PANEL_LOCATION;
                }

                //chk_isFlexible.Enabled = true;

            }

            evaluate_Jigglebone_Property_Groups();
        }

        private void chk_isFlexible_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_isFlexible.Checked)
            {
                chk_isRigid.Checked = false;

                lbl_IS_FLEXIBLE.Text = "IS_FLEXIBLE";

                //allow length flex
                chkAllowLengthFlex.Enabled = true;

                //pitch
                btnPitchStiffness.Enabled = true;
                lblPitchStiffness.Enabled = true;
                txtPitchStiffness.Enabled = true;

                btnPitchDamping.Enabled = true;
                lblPitchDamping.Enabled = true;
                txtPitchDamping.Enabled = true;

                //yaw
                btnYawStiffness.Enabled = true;
                lblYawStiffness.Enabled = true;
                txtYawStiffness.Enabled = true;

                btnYawDamping.Enabled = true;
                lblYawDamping.Enabled = true;
                txtYawDamping.Enabled = true;

                //along
                lbl_Along.Enabled = true;
                grp_Along.Enabled = true;

                //make sure we can see it
                grp_IS_FLEXIBLE.Location = LEFT_PROPERTY_PANEL_LOCATION;

                //chk_isRigid.Enabled = false;
            }
            else
            {
                //only hide this panel if both variants of it aren't being used
                if (!chk_isRigid.Checked)
                {
                    grp_IS_FLEXIBLE.Location = NULL_PROPERTY_PANEL_LOCATION;
                }

                //chk_isRigid.Enabled = true;
            }

            evaluate_Jigglebone_Property_Groups();
        }

        private void chk_hasBaseSpring_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hasBaseSpring.Checked)
            {
                chk_isBoing.Checked = false;

                grp_HAS_BASE_SPRING.Location = RIGHT_PROPERTY_PANEL_LOCATION;
                //chk_isBoing.Enabled = false;
            }
            else
            {
                grp_HAS_BASE_SPRING.Location = NULL_PROPERTY_PANEL_LOCATION;
                //chk_isBoing.Enabled = true;
            }

            evaluate_Jigglebone_Property_Groups();
        }

        private void chk_isBoing_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_isBoing.Checked)
            {
                chk_hasBaseSpring.Checked = false;

                grp_IS_BOING.Location = RIGHT_PROPERTY_PANEL_LOCATION;
                //chk_hasBaseSpring.Enabled = false;
            }
            else
            {
                grp_IS_BOING.Location = NULL_PROPERTY_PANEL_LOCATION;
                //chk_hasBaseSpring.Enabled = true;
            }

            evaluate_Jigglebone_Property_Groups();
        }


        private string param_to_reset = "";

        private void ResetParamToDefault(string Param_To_Reset)
        {
            MessageBox.Show("todo: finish this reset function. each reset button must be linked to a textbox and each textbox must be linked to a param.");
            //Param_To
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void btn_reset_generic_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            param_to_reset = button.Tag.ToString();

            menuResetValue.Show(MousePosition);
        }




        private void resetToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetParamToDefault(param_to_reset);
        }

        private void revertToOriginalboneNameValueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void groupBox21_Enter(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void chk_Always_On_Top_CheckedChanged(object sender, EventArgs e)
        {



            if (chk_Always_On_Top.Checked)
            {
                alwaysOnTopTimer.Start();
            }
            else
            {
                alwaysOnTopTimer.Stop();
            }


        }

        private void AlwaysOnTopTimer_Tick(object sender, EventArgs e)
        {
            if (!this.IsDisposed && chk_Always_On_Top.Checked)
            {
                SetWindowPos(Main.proc_HLMV.MainWindowHandle, this.Handle, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE | SWP_NOACTIVATE);
            }
        }



        private string txt_QC_backup = "";

        private void txt_QC_Enter(object sender, EventArgs e)
        {
            txt_QC_backup = txt_QC.Text;
        }

        private void txt_QC_TextChanged(object sender, EventArgs e)
        {
            return;
            //todo: idk?
            bool show_error = (txt_QC.Text == txt_QC_backup);
            txt_QC.Text = txt_QC_backup;
            if (show_error)
            {
                //MessageBox.Show("This text is not directly editable in the BETA version.\n\nPlease use the controls on the left.", "Sorry!");
            }
        }


        private void numericUpDown_any__ValueChanged(object sender, EventArgs e)
        {

        }



        //for converting any of the jigglebone properties to their correct string equivalent (with option to convert radians to degrees)
        public static string SingleToString(double value, bool RadiansToDegrees = false, bool isBoingImpactAngle = false)
        {

            //according to the crowbar source, we need the INVERSE cosine of the actual value
            //this is ONLY for boingImpactAngle
            if (isBoingImpactAngle)
            {
                value = Math.Acos(value);
            }

            //conversion function from crowbar
            if (RadiansToDegrees)
            {
                value = value * 180 / 3.1415926535897931;

                //value = Math.Round(value);

                /*
                //deal with numbers that aren't quite correct as a result of conversion
                double rounded = Math.Floor(value);
                if (value - rounded >= 0.99999)
                {
                    value = rounded + 1;
                }
                */
            }


            string value_formatted = value.ToString("0.#####");

            /*
            //set correct string length for desired decimal places, accounting for negative numbers
            int StringLength = 8;
            if (value < 0)
            {
                StringLength = 9;
            }


            //trim string down to appropriate length, don't trim if it's not long enough
            if (value_formatted.Length >= StringLength)
            {
                value_formatted = value_formatted.Substring(0, StringLength);
            }

            value_formatted = value_formatted.Replace(".000000", "");
            */

            return value_formatted;
        }

        private void btn_QC_select_current_Click(object sender, EventArgs e)
        {
            jiggleBone theJiggleBone = allJiggleBones[lstBoneName.SelectedIndex];

            int QC_start = theJiggleBone.QC_START;
            int QC_count = (theJiggleBone.QC_END) -theJiggleBone.QC_START;

            if (QC_count < 1 || (QC_start + QC_count) > txt_QC.TextLength)
            {
                theJiggleBone.QC_START = 0;
                theJiggleBone.QC_END = 0;
                return;
            }

            txt_QC.Select(QC_start, QC_count);
            txt_QC.Focus();

            //todo: fix this
            /*SendKeys.Send("{RIGHT}");

            txt_QC.Select(QC_start, QC_count);
            txt_QC.Focus();
            */
        }

        private void menubtn_QC_Select_Current_Click(object sender, EventArgs e)
        {
            jiggleBone theJiggleBone = allJiggleBones[lstBoneName.SelectedIndex];

            int QC_start = theJiggleBone.QC_START;
            int QC_count = (theJiggleBone.QC_END) - theJiggleBone.QC_START;

            if (QC_count < 1 || (QC_start + QC_count) > txt_QC.TextLength)
            {
                theJiggleBone.QC_START = 0;
                theJiggleBone.QC_END = 0;
                return;
            }

            txt_QC.Select(QC_start, QC_count);
            txt_QC.Focus();
        }



        private void btn_QC_select_all_Click(object sender, EventArgs e)
        {
            txt_QC.Select(0, txt_QC.TextLength);
            txt_QC.Focus();
        }

        private void menubtn_QC_Select_All_Click(object sender, EventArgs e)
        {
            txt_QC.Select(0, txt_QC.TextLength);
            txt_QC.Focus();
        }


        private void btn_QC_copy_Click(object sender, EventArgs e)
        {
            if (txt_QC.SelectionLength > 0)
            {
                System.Windows.Forms.Clipboard.SetText(txt_QC.Text.Substring(txt_QC.SelectionStart, txt_QC.SelectionLength));
            }
        }
        private void menubtn_QC_Copy_Click(object sender, EventArgs e)
        {
            if (txt_QC.SelectionLength > 0)
            {
                System.Windows.Forms.Clipboard.SetText(txt_QC.Text.Substring(txt_QC.SelectionStart, txt_QC.SelectionLength));
            }
        }

        private void numericUpDown_any_ValueChanged(object sender, EventArgs e)
        {
            //DeviceCtrlLibrary.NumericUpDown_CustomFormat i guess
            //NumericUpDown numericUpDown = sender as NumericUpDown;


            /*
            if (numericUpDown.Value != 0)
            {
                numericUpDown.Value = 0;
            }
            */
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddJiggleBone_FormClosing(object sender, FormClosingEventArgs e)
        {


            //kill timer
            alwaysOnTopTimer.Stop();

            //restore original jigglebone data //todo: probably a better way to do this
            File.Copy(TFMV.Main.tmp_dir + mdlpath + "_original_jigglebone_data", TFMV.Main.tmp_dir + mdlpath, true);

            //re-enable main form
            Main_Form.Enabled = true;
        }

        //todo: auto-refresh is disabled, and may not be coming back   
        private void hlmv_refresh_delay_Tick(object sender, EventArgs e)
        {
            return;
            ready_to_refresh = true;

            //refresh_pending is used to refresh hlmv at the next available tick of the delay timer
            if (refresh_pending)
            {
                Main.refresh_hlmv(false);
                refresh_pending = false;
            }
        }

        private void btn_ResetAll_Click(object sender, EventArgs e)
        {
            readJigglebones(original_mdlpath);
        }
    }




    namespace ExtensionMethods
    {
        public static class MyExtensions
        {

            //extends NumericUpDown, puts a float into the text box and correctly formats it (with option to convert radians to degrees)
            public static void SetNumber(this System.Windows.Forms.NumericUpDown txtBox, double value, bool RadiansToDegrees = false, bool isBoingImpactAngle = false)
            {
                txtBox.Text = AddJiggleBone.SingleToString(value, RadiansToDegrees, isBoingImpactAngle);
                return;
            }

        //extends NumericUpDown, gets the text from the text box and correctly formats it as a Single (with option to convert degrees to radians)
        public static Single GetNumber(this System.Windows.Forms.NumericUpDown txtBox, bool DegreesToRadians, bool isBoingImpactAngle = false)
            {


                if (!double.TryParse(txtBox.Text, out double number))
                    {

                    //todo: could reset to default instead
                    txtBox.Text = "0";

                }


                double value = System.Convert.ToDouble(txtBox.Text);


                //conversion function from crowbar
                if (DegreesToRadians)
                {
                    value = value * 3.1415926535897931 / 180;
                }

                //according to the crowbar source, we need the cosine of the actual value
                //this is ONLY for boingImpactAngle
                if (isBoingImpactAngle)
                {
                    value = Math.Cos(value);
                }



                return System.Convert.ToSingle(value);
            }




        }

}
}
