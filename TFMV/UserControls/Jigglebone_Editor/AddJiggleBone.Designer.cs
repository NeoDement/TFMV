namespace TFMV.UserControls.Jigglebone_Editor
{
    using System.Windows.Forms;

    partial class AddJiggleBone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJiggleBone));
            this.lstJiggleType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtYawConstraintMax = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.txtYawConstraintMin = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.chkYawConstraint = new System.Windows.Forms.CheckBox();
            this.btnYawDamping = new System.Windows.Forms.Button();
            this.btnYawStiffness = new System.Windows.Forms.Button();
            this.txtYawDamping = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.lblYawStiffness = new System.Windows.Forms.Label();
            this.lblYawDamping = new System.Windows.Forms.Label();
            this.txtYawStiffness = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.numericUpDown14 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtYawFriction = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.chkYawFriction = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grp_HAS_BASE_SPRING = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.txtBaseLeftFriction = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtBaseLeftConstraintMax = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.txtBaseLeftConstraintMin = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.lbl_HAS_BASE_SPRING = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBaseForwardFriction = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtBaseForwardConstraintMax = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.txtBaseForwardConstraintMin = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.btn_resetBaseMass = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.txtBaseBaseMass = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.txtBaseUpFriction = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBaseUpConstraintMax = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.txtBaseUpConstraintMin = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_ResetBaseDamping = new System.Windows.Forms.Button();
            this.btn_ResetBaseStiffness = new System.Windows.Forms.Button();
            this.txtBaseDamping = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBaseStiffness = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_Along = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtAlongDamping = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.txtAlongStiffness = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtAngleConstraint = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.chkAngleConstraint = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.txtLength = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.chkAllowLengthFlex = new System.Windows.Forms.CheckBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtPitchConstraintMax = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.txtPitchConstraintMin = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.chkPitchConstraint = new System.Windows.Forms.CheckBox();
            this.btnPitchDamping = new System.Windows.Forms.Button();
            this.btnPitchStiffness = new System.Windows.Forms.Button();
            this.txtPitchDamping = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.lblPitchStiffness = new System.Windows.Forms.Label();
            this.lblPitchDamping = new System.Windows.Forms.Label();
            this.txtPitchStiffness = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.numericUpDown15 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtPitchFriction = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.chkPitchFriction = new System.Windows.Forms.CheckBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkHasBaseSpring = new System.Windows.Forms.CheckBox();
            this.btnApplyJigglebones_OLD = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button21 = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.txtBoingDampingRate = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.txtBoingImpactAngle = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtBoingImpactSpeed = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.txtBoingAmplitude = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.txtBoingFrequency = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.label46 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lstPropertyGroupsMain = new System.Windows.Forms.CheckedListBox();
            this.label47 = new System.Windows.Forms.Label();
            this.lstBoneName = new System.Windows.Forms.ListBox();
            this.label48 = new System.Windows.Forms.Label();
            this.lstPropertyGroupsSub = new System.Windows.Forms.CheckedListBox();
            this.chk_isRigid = new System.Windows.Forms.CheckBox();
            this.chk_isFlexible = new System.Windows.Forms.CheckBox();
            this.chk_isBoing = new System.Windows.Forms.CheckBox();
            this.chk_hasBaseSpring = new System.Windows.Forms.CheckBox();
            this.grp_IS_BOING = new System.Windows.Forms.GroupBox();
            this.lbl_IS_BOING = new System.Windows.Forms.Label();
            this.txt_QC = new System.Windows.Forms.TextBox();
            this.menuQCEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menubtn_QC_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtn_QC_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtn_QC_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtn_QC_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menubtn_QC_Select_Current = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtn_QC_Select_All = new System.Windows.Forms.ToolStripMenuItem();
            this.label49 = new System.Windows.Forms.Label();
            this.btn_HideQC = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.btn_QC_copy = new System.Windows.Forms.Button();
            this.btn_QC_select_all = new System.Windows.Forms.Button();
            this.btn_QC_select_current = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.label58 = new System.Windows.Forms.Label();
            this.grp_IS_FLEXIBLE = new System.Windows.Forms.GroupBox();
            this.lbl_Along = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox48 = new System.Windows.Forms.GroupBox();
            this.txtTipMass = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.lbl_IS_FLEXIBLE = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.button31 = new System.Windows.Forms.Button();
            this.label62 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.button32 = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.numericUpDown4 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox40 = new System.Windows.Forms.GroupBox();
            this.groupBox41 = new System.Windows.Forms.GroupBox();
            this.button33 = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox42 = new System.Windows.Forms.GroupBox();
            this.button34 = new System.Windows.Forms.Button();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.numericUpDown7 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox43 = new System.Windows.Forms.GroupBox();
            this.button35 = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox44 = new System.Windows.Forms.GroupBox();
            this.groupBox45 = new System.Windows.Forms.GroupBox();
            this.button36 = new System.Windows.Forms.Button();
            this.label70 = new System.Windows.Forms.Label();
            this.numericUpDown9 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox46 = new System.Windows.Forms.GroupBox();
            this.button37 = new System.Windows.Forms.Button();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.numericUpDown10 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.numericUpDown11 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox47 = new System.Windows.Forms.GroupBox();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.numericUpDown12 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.numericUpDown13 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.label75 = new System.Windows.Forms.Label();
            this.menuResetValue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToOriginalboneNameValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_reset_generic = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.numericUpDown27 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.numericUpDown28 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown16 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_IS_RIGID = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDown17 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.numericUpDown18 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.numericUpDown19 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.numericUpDown20 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.numericUpDown21 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.numericUpDown26 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox49 = new System.Windows.Forms.GroupBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.numericUpDown29 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.numericUpDown30 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.btnApplyJigglebones = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label79 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.btn_ResetAll = new System.Windows.Forms.Button();
            this.chk_Auto_Apply = new System.Windows.Forms.CheckBox();
            this.chk_Always_On_Top = new System.Windows.Forms.CheckBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.menuResetAllValues = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.hlmv_refresh_delay = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new DeviceCtrlLibrary.NumericUpDown_CustomFormat();
            this.groupBox1.SuspendLayout();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYawConstraintMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYawConstraintMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYawDamping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYawStiffness)).BeginInit();
            this.groupBox27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYawFriction)).BeginInit();
            this.grp_HAS_BASE_SPRING.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseLeftFriction)).BeginInit();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseLeftConstraintMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseLeftConstraintMin)).BeginInit();
            this.groupBox22.SuspendLayout();
            this.groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseForwardFriction)).BeginInit();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseForwardConstraintMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseForwardConstraintMin)).BeginInit();
            this.groupBox25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseBaseMass)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseUpFriction)).BeginInit();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseUpConstraintMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseUpConstraintMin)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseDamping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseStiffness)).BeginInit();
            this.grp_Along.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlongDamping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlongStiffness)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngleConstraint)).BeginInit();
            this.groupBox26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).BeginInit();
            this.groupBox29.SuspendLayout();
            this.groupBox31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPitchConstraintMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPitchConstraintMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPitchDamping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPitchStiffness)).BeginInit();
            this.groupBox30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPitchFriction)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoingDampingRate)).BeginInit();
            this.groupBox32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoingImpactAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoingImpactSpeed)).BeginInit();
            this.groupBox33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoingAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoingFrequency)).BeginInit();
            this.grp_IS_BOING.SuspendLayout();
            this.menuQCEditor.SuspendLayout();
            this.groupBox35.SuspendLayout();
            this.grp_IS_FLEXIBLE.SuspendLayout();
            this.groupBox48.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipMass)).BeginInit();
            this.groupBox37.SuspendLayout();
            this.groupBox38.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox39.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.groupBox40.SuspendLayout();
            this.groupBox41.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.groupBox42.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            this.groupBox43.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            this.groupBox44.SuspendLayout();
            this.groupBox45.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            this.groupBox46.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            this.groupBox47.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            this.menuResetValue.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown28)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown26)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.groupBox49.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown30)).BeginInit();
            this.panel12.SuspendLayout();
            this.menuResetAllValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstJiggleType
            // 
            this.lstJiggleType.FormattingEnabled = true;
            this.lstJiggleType.Items.AddRange(new object[] {
            "none",
            "is_flexible",
            "is_rigid",
            "is_boing"});
            this.lstJiggleType.Location = new System.Drawing.Point(1487, 574);
            this.lstJiggleType.Name = "lstJiggleType";
            this.lstJiggleType.Size = new System.Drawing.Size(99, 21);
            this.lstJiggleType.TabIndex = 1;
            this.lstJiggleType.SelectedIndexChanged += new System.EventHandler(this.lstJiggleType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupBox28);
            this.groupBox1.Controls.Add(this.btnYawDamping);
            this.groupBox1.Controls.Add(this.btnYawStiffness);
            this.groupBox1.Controls.Add(this.txtYawDamping);
            this.groupBox1.Controls.Add(this.lblYawStiffness);
            this.groupBox1.Controls.Add(this.lblYawDamping);
            this.groupBox1.Controls.Add(this.txtYawStiffness);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.label34);
            this.groupBox28.Controls.Add(this.label35);
            this.groupBox28.Controls.Add(this.txtYawConstraintMax);
            this.groupBox28.Controls.Add(this.txtYawConstraintMin);
            this.groupBox28.Controls.Add(this.chkYawConstraint);
            this.groupBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox28.Location = new System.Drawing.Point(8, 65);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(179, 52);
            this.groupBox28.TabIndex = 37;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "     yaw_constraint";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(13, 25);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(27, 13);
            this.label34.TabIndex = 29;
            this.label34.Text = "Min:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(93, 25);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(30, 13);
            this.label35.TabIndex = 28;
            this.label35.Text = "Max:";
            // 
            // txtYawConstraintMax
            // 
            this.txtYawConstraintMax.BackColor = System.Drawing.SystemColors.Window;
            this.txtYawConstraintMax.DecimalPlaces = 5;
            this.txtYawConstraintMax.Location = new System.Drawing.Point(123, 23);
            this.txtYawConstraintMax.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtYawConstraintMax.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtYawConstraintMax.Name = "txtYawConstraintMax";
            this.txtYawConstraintMax.Size = new System.Drawing.Size(49, 20);
            this.txtYawConstraintMax.TabIndex = 27;
            this.txtYawConstraintMax.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtYawConstraintMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtYawConstraintMax.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // txtYawConstraintMin
            // 
            this.txtYawConstraintMin.BackColor = System.Drawing.SystemColors.Window;
            this.txtYawConstraintMin.DecimalPlaces = 5;
            this.txtYawConstraintMin.Location = new System.Drawing.Point(43, 23);
            this.txtYawConstraintMin.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtYawConstraintMin.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtYawConstraintMin.Name = "txtYawConstraintMin";
            this.txtYawConstraintMin.Size = new System.Drawing.Size(49, 20);
            this.txtYawConstraintMin.TabIndex = 25;
            this.txtYawConstraintMin.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtYawConstraintMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtYawConstraintMin.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // chkYawConstraint
            // 
            this.chkYawConstraint.AutoSize = true;
            this.chkYawConstraint.Location = new System.Drawing.Point(4, 1);
            this.chkYawConstraint.Name = "chkYawConstraint";
            this.chkYawConstraint.Size = new System.Drawing.Size(15, 14);
            this.chkYawConstraint.TabIndex = 18;
            this.chkYawConstraint.UseVisualStyleBackColor = true;
            this.chkYawConstraint.CheckedChanged += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // btnYawDamping
            // 
            this.btnYawDamping.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.btnYawDamping.Image = global::TFMV.Properties.Resources.btn_reset;
            this.btnYawDamping.Location = new System.Drawing.Point(5, 39);
            this.btnYawDamping.Name = "btnYawDamping";
            this.btnYawDamping.Size = new System.Drawing.Size(19, 19);
            this.btnYawDamping.TabIndex = 23;
            this.btnYawDamping.UseVisualStyleBackColor = true;
            this.btnYawDamping.Visible = false;
            // 
            // btnYawStiffness
            // 
            this.btnYawStiffness.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.btnYawStiffness.Image = global::TFMV.Properties.Resources.btn_reset;
            this.btnYawStiffness.Location = new System.Drawing.Point(5, 16);
            this.btnYawStiffness.Name = "btnYawStiffness";
            this.btnYawStiffness.Size = new System.Drawing.Size(19, 19);
            this.btnYawStiffness.TabIndex = 22;
            this.btnYawStiffness.UseVisualStyleBackColor = true;
            this.btnYawStiffness.Visible = false;
            // 
            // txtYawDamping
            // 
            this.txtYawDamping.BackColor = System.Drawing.SystemColors.Window;
            this.txtYawDamping.DecimalPlaces = 5;
            this.txtYawDamping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYawDamping.Location = new System.Drawing.Point(125, 38);
            this.txtYawDamping.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtYawDamping.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtYawDamping.Name = "txtYawDamping";
            this.txtYawDamping.Size = new System.Drawing.Size(60, 20);
            this.txtYawDamping.TabIndex = 14;
            this.txtYawDamping.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtYawDamping.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtYawDamping.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // lblYawStiffness
            // 
            this.lblYawStiffness.AutoSize = true;
            this.lblYawStiffness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYawStiffness.Location = new System.Drawing.Point(25, 18);
            this.lblYawStiffness.Name = "lblYawStiffness";
            this.lblYawStiffness.Size = new System.Drawing.Size(73, 13);
            this.lblYawStiffness.TabIndex = 12;
            this.lblYawStiffness.Text = "yaw_stiffness:";
            // 
            // lblYawDamping
            // 
            this.lblYawDamping.AutoSize = true;
            this.lblYawDamping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYawDamping.Location = new System.Drawing.Point(25, 41);
            this.lblYawDamping.Name = "lblYawDamping";
            this.lblYawDamping.Size = new System.Drawing.Size(75, 13);
            this.lblYawDamping.TabIndex = 13;
            this.lblYawDamping.Text = "yaw_damping:";
            // 
            // txtYawStiffness
            // 
            this.txtYawStiffness.BackColor = System.Drawing.SystemColors.Window;
            this.txtYawStiffness.DecimalPlaces = 5;
            this.txtYawStiffness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYawStiffness.Location = new System.Drawing.Point(125, 15);
            this.txtYawStiffness.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtYawStiffness.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtYawStiffness.Name = "txtYawStiffness";
            this.txtYawStiffness.Size = new System.Drawing.Size(60, 20);
            this.txtYawStiffness.TabIndex = 11;
            this.txtYawStiffness.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtYawStiffness.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtYawStiffness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtYawStiffness.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.numericUpDown14);
            this.groupBox27.Controls.Add(this.checkBox1);
            this.groupBox27.Controls.Add(this.txtYawFriction);
            this.groupBox27.Controls.Add(this.chkYawFriction);
            this.groupBox27.Location = new System.Drawing.Point(21, 559);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(179, 69);
            this.groupBox27.TabIndex = 38;
            this.groupBox27.TabStop = false;
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.numericUpDown14.Enabled = false;
            this.numericUpDown14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown14.Location = new System.Drawing.Point(111, 40);
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown14.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(8, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "yaw_bounce:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtYawFriction
            // 
            this.txtYawFriction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtYawFriction.DecimalPlaces = 5;
            this.txtYawFriction.Enabled = false;
            this.txtYawFriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYawFriction.Location = new System.Drawing.Point(111, 14);
            this.txtYawFriction.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtYawFriction.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtYawFriction.Name = "txtYawFriction";
            this.txtYawFriction.Size = new System.Drawing.Size(60, 20);
            this.txtYawFriction.TabIndex = 21;
            this.txtYawFriction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtYawFriction.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // chkYawFriction
            // 
            this.chkYawFriction.AutoSize = true;
            this.chkYawFriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYawFriction.Location = new System.Drawing.Point(8, 16);
            this.chkYawFriction.Name = "chkYawFriction";
            this.chkYawFriction.Size = new System.Drawing.Size(85, 17);
            this.chkYawFriction.TabIndex = 20;
            this.chkYawFriction.Text = "yaw_friction:";
            this.chkYawFriction.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1537, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Jiggle Type:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // grp_HAS_BASE_SPRING
            // 
            this.grp_HAS_BASE_SPRING.BackColor = System.Drawing.SystemColors.Control;
            this.grp_HAS_BASE_SPRING.Controls.Add(this.button17);
            this.grp_HAS_BASE_SPRING.Controls.Add(this.button16);
            this.grp_HAS_BASE_SPRING.Controls.Add(this.button26);
            this.grp_HAS_BASE_SPRING.Controls.Add(this.label57);
            this.grp_HAS_BASE_SPRING.Controls.Add(this.label56);
            this.grp_HAS_BASE_SPRING.Controls.Add(this.label55);
            this.grp_HAS_BASE_SPRING.Controls.Add(this.groupBox19);
            this.grp_HAS_BASE_SPRING.Controls.Add(this.lbl_HAS_BASE_SPRING);
            this.grp_HAS_BASE_SPRING.Controls.Add(this.groupBox22);
            this.grp_HAS_BASE_SPRING.Controls.Add(this.groupBox25);
            this.grp_HAS_BASE_SPRING.Controls.Add(this.groupBox6);
            this.grp_HAS_BASE_SPRING.Controls.Add(this.groupBox5);
            this.grp_HAS_BASE_SPRING.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_HAS_BASE_SPRING.Location = new System.Drawing.Point(1297, 647);
            this.grp_HAS_BASE_SPRING.Name = "grp_HAS_BASE_SPRING";
            this.grp_HAS_BASE_SPRING.Size = new System.Drawing.Size(212, 551);
            this.grp_HAS_BASE_SPRING.TabIndex = 19;
            this.grp_HAS_BASE_SPRING.TabStop = false;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button17.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button17.Location = new System.Drawing.Point(19, 303);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(19, 19);
            this.button17.TabIndex = 76;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Visible = false;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button16.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button16.Location = new System.Drawing.Point(19, 438);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(19, 19);
            this.button16.TabIndex = 77;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Visible = false;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button26.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button26.Location = new System.Drawing.Point(19, 168);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(19, 19);
            this.button26.TabIndex = 78;
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Visible = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // label57
            // 
            this.label57.BackColor = System.Drawing.Color.DarkGray;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label57.Location = new System.Drawing.Point(9, 413);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(194, 23);
            this.label57.TabIndex = 75;
            this.label57.Text = "FORWARD";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label56
            // 
            this.label56.BackColor = System.Drawing.Color.DarkGray;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label56.Location = new System.Drawing.Point(9, 277);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(194, 23);
            this.label56.TabIndex = 74;
            this.label56.Text = "UP";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.Color.DarkGray;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label55.Location = new System.Drawing.Point(9, 141);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(194, 23);
            this.label55.TabIndex = 73;
            this.label55.Text = "LEFT";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox19
            // 
            this.groupBox19.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox19.Controls.Add(this.groupBox20);
            this.groupBox19.Controls.Add(this.groupBox21);
            this.groupBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox19.Location = new System.Drawing.Point(9, 153);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(194, 118);
            this.groupBox19.TabIndex = 36;
            this.groupBox19.TabStop = false;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.button15);
            this.groupBox20.Controls.Add(this.label33);
            this.groupBox20.Controls.Add(this.txtBaseLeftFriction);
            this.groupBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox20.Location = new System.Drawing.Point(8, 69);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(179, 42);
            this.groupBox20.TabIndex = 36;
            this.groupBox20.TabStop = false;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button15.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button15.Location = new System.Drawing.Point(4, 13);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(19, 19);
            this.button15.TabIndex = 27;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(23, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(61, 13);
            this.label33.TabIndex = 26;
            this.label33.Text = "left_friction:";
            // 
            // txtBaseLeftFriction
            // 
            this.txtBaseLeftFriction.BackColor = System.Drawing.Color.White;
            this.txtBaseLeftFriction.DecimalPlaces = 5;
            this.txtBaseLeftFriction.Location = new System.Drawing.Point(112, 14);
            this.txtBaseLeftFriction.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseLeftFriction.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseLeftFriction.Name = "txtBaseLeftFriction";
            this.txtBaseLeftFriction.Size = new System.Drawing.Size(60, 20);
            this.txtBaseLeftFriction.TabIndex = 21;
            this.txtBaseLeftFriction.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseLeftFriction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseLeftFriction.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label24);
            this.groupBox21.Controls.Add(this.label25);
            this.groupBox21.Controls.Add(this.txtBaseLeftConstraintMax);
            this.groupBox21.Controls.Add(this.txtBaseLeftConstraintMin);
            this.groupBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox21.Location = new System.Drawing.Point(8, 18);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(179, 52);
            this.groupBox21.TabIndex = 35;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "      left_constraint";
            this.groupBox21.Enter += new System.EventHandler(this.groupBox21_Enter);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 13);
            this.label24.TabIndex = 29;
            this.label24.Text = "Min:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(89, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "Max:";
            // 
            // txtBaseLeftConstraintMax
            // 
            this.txtBaseLeftConstraintMax.BackColor = System.Drawing.Color.White;
            this.txtBaseLeftConstraintMax.DecimalPlaces = 5;
            this.txtBaseLeftConstraintMax.Location = new System.Drawing.Point(120, 23);
            this.txtBaseLeftConstraintMax.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseLeftConstraintMax.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseLeftConstraintMax.Name = "txtBaseLeftConstraintMax";
            this.txtBaseLeftConstraintMax.Size = new System.Drawing.Size(49, 20);
            this.txtBaseLeftConstraintMax.TabIndex = 27;
            this.txtBaseLeftConstraintMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtBaseLeftConstraintMax.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseLeftConstraintMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseLeftConstraintMax.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // txtBaseLeftConstraintMin
            // 
            this.txtBaseLeftConstraintMin.BackColor = System.Drawing.Color.White;
            this.txtBaseLeftConstraintMin.DecimalPlaces = 5;
            this.txtBaseLeftConstraintMin.Location = new System.Drawing.Point(39, 23);
            this.txtBaseLeftConstraintMin.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseLeftConstraintMin.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseLeftConstraintMin.Name = "txtBaseLeftConstraintMin";
            this.txtBaseLeftConstraintMin.Size = new System.Drawing.Size(49, 20);
            this.txtBaseLeftConstraintMin.TabIndex = 25;
            this.txtBaseLeftConstraintMin.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseLeftConstraintMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseLeftConstraintMin.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // lbl_HAS_BASE_SPRING
            // 
            this.lbl_HAS_BASE_SPRING.BackColor = System.Drawing.Color.Gray;
            this.lbl_HAS_BASE_SPRING.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_HAS_BASE_SPRING.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_HAS_BASE_SPRING.Location = new System.Drawing.Point(0, 0);
            this.lbl_HAS_BASE_SPRING.Name = "lbl_HAS_BASE_SPRING";
            this.lbl_HAS_BASE_SPRING.Size = new System.Drawing.Size(212, 23);
            this.lbl_HAS_BASE_SPRING.TabIndex = 71;
            this.lbl_HAS_BASE_SPRING.Text = "HAS_BASE_SPRING";
            this.lbl_HAS_BASE_SPRING.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox22
            // 
            this.groupBox22.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox22.Controls.Add(this.groupBox23);
            this.groupBox22.Controls.Add(this.groupBox24);
            this.groupBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox22.Location = new System.Drawing.Point(9, 425);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(194, 118);
            this.groupBox22.TabIndex = 40;
            this.groupBox22.TabStop = false;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.button13);
            this.groupBox23.Controls.Add(this.label26);
            this.groupBox23.Controls.Add(this.txtBaseForwardFriction);
            this.groupBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox23.Location = new System.Drawing.Point(8, 69);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(179, 42);
            this.groupBox23.TabIndex = 36;
            this.groupBox23.TabStop = false;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button13.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button13.Location = new System.Drawing.Point(4, 13);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(19, 19);
            this.button13.TabIndex = 27;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(23, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 13);
            this.label26.TabIndex = 26;
            this.label26.Text = "forward_friction:";
            // 
            // txtBaseForwardFriction
            // 
            this.txtBaseForwardFriction.BackColor = System.Drawing.Color.White;
            this.txtBaseForwardFriction.DecimalPlaces = 5;
            this.txtBaseForwardFriction.Location = new System.Drawing.Point(112, 14);
            this.txtBaseForwardFriction.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseForwardFriction.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseForwardFriction.Name = "txtBaseForwardFriction";
            this.txtBaseForwardFriction.Size = new System.Drawing.Size(60, 20);
            this.txtBaseForwardFriction.TabIndex = 21;
            this.txtBaseForwardFriction.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseForwardFriction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseForwardFriction.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.label27);
            this.groupBox24.Controls.Add(this.label31);
            this.groupBox24.Controls.Add(this.txtBaseForwardConstraintMax);
            this.groupBox24.Controls.Add(this.txtBaseForwardConstraintMin);
            this.groupBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox24.Location = new System.Drawing.Point(8, 18);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(179, 52);
            this.groupBox24.TabIndex = 35;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "      forward_constraint";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(27, 13);
            this.label27.TabIndex = 29;
            this.label27.Text = "Min:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(89, 25);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(30, 13);
            this.label31.TabIndex = 28;
            this.label31.Text = "Max:";
            // 
            // txtBaseForwardConstraintMax
            // 
            this.txtBaseForwardConstraintMax.BackColor = System.Drawing.Color.White;
            this.txtBaseForwardConstraintMax.DecimalPlaces = 5;
            this.txtBaseForwardConstraintMax.Location = new System.Drawing.Point(120, 23);
            this.txtBaseForwardConstraintMax.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseForwardConstraintMax.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseForwardConstraintMax.Name = "txtBaseForwardConstraintMax";
            this.txtBaseForwardConstraintMax.Size = new System.Drawing.Size(49, 20);
            this.txtBaseForwardConstraintMax.TabIndex = 27;
            this.txtBaseForwardConstraintMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtBaseForwardConstraintMax.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseForwardConstraintMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseForwardConstraintMax.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // txtBaseForwardConstraintMin
            // 
            this.txtBaseForwardConstraintMin.BackColor = System.Drawing.Color.White;
            this.txtBaseForwardConstraintMin.DecimalPlaces = 5;
            this.txtBaseForwardConstraintMin.Location = new System.Drawing.Point(39, 23);
            this.txtBaseForwardConstraintMin.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseForwardConstraintMin.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseForwardConstraintMin.Name = "txtBaseForwardConstraintMin";
            this.txtBaseForwardConstraintMin.Size = new System.Drawing.Size(49, 20);
            this.txtBaseForwardConstraintMin.TabIndex = 25;
            this.txtBaseForwardConstraintMin.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseForwardConstraintMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseForwardConstraintMin.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // groupBox25
            // 
            this.groupBox25.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox25.Controls.Add(this.btn_resetBaseMass);
            this.groupBox25.Controls.Add(this.label40);
            this.groupBox25.Controls.Add(this.txtBaseBaseMass);
            this.groupBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox25.Location = new System.Drawing.Point(9, 93);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(194, 42);
            this.groupBox25.TabIndex = 39;
            this.groupBox25.TabStop = false;
            // 
            // btn_resetBaseMass
            // 
            this.btn_resetBaseMass.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.btn_resetBaseMass.Image = global::TFMV.Properties.Resources.btn_reset;
            this.btn_resetBaseMass.Location = new System.Drawing.Point(5, 15);
            this.btn_resetBaseMass.Name = "btn_resetBaseMass";
            this.btn_resetBaseMass.Size = new System.Drawing.Size(19, 19);
            this.btn_resetBaseMass.TabIndex = 24;
            this.btn_resetBaseMass.UseVisualStyleBackColor = true;
            this.btn_resetBaseMass.Visible = false;
            this.btn_resetBaseMass.Click += new System.EventHandler(this.btn_reset_generic_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(27, 17);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(63, 13);
            this.label40.TabIndex = 23;
            this.label40.Text = "base_mass:";
            // 
            // txtBaseBaseMass
            // 
            this.txtBaseBaseMass.DecimalPlaces = 5;
            this.txtBaseBaseMass.Location = new System.Drawing.Point(125, 14);
            this.txtBaseBaseMass.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseBaseMass.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseBaseMass.Name = "txtBaseBaseMass";
            this.txtBaseBaseMass.Size = new System.Drawing.Size(60, 20);
            this.txtBaseBaseMass.TabIndex = 19;
            this.txtBaseBaseMass.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseBaseMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseBaseMass.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.groupBox17);
            this.groupBox6.Controls.Add(this.groupBox18);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(9, 288);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(194, 118);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.button14);
            this.groupBox17.Controls.Add(this.label32);
            this.groupBox17.Controls.Add(this.txtBaseUpFriction);
            this.groupBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox17.Location = new System.Drawing.Point(8, 69);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(179, 42);
            this.groupBox17.TabIndex = 36;
            this.groupBox17.TabStop = false;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button14.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button14.Location = new System.Drawing.Point(4, 13);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(19, 19);
            this.button14.TabIndex = 27;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Visible = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(23, 16);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 13);
            this.label32.TabIndex = 26;
            this.label32.Text = "up_friction:";
            // 
            // txtBaseUpFriction
            // 
            this.txtBaseUpFriction.BackColor = System.Drawing.Color.White;
            this.txtBaseUpFriction.DecimalPlaces = 5;
            this.txtBaseUpFriction.Location = new System.Drawing.Point(112, 14);
            this.txtBaseUpFriction.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseUpFriction.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseUpFriction.Name = "txtBaseUpFriction";
            this.txtBaseUpFriction.Size = new System.Drawing.Size(60, 20);
            this.txtBaseUpFriction.TabIndex = 21;
            this.txtBaseUpFriction.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseUpFriction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseUpFriction.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.label10);
            this.groupBox18.Controls.Add(this.label11);
            this.groupBox18.Controls.Add(this.txtBaseUpConstraintMax);
            this.groupBox18.Controls.Add(this.txtBaseUpConstraintMin);
            this.groupBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox18.Location = new System.Drawing.Point(8, 19);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(179, 52);
            this.groupBox18.TabIndex = 35;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "      up_constraint";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Min:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Max:";
            // 
            // txtBaseUpConstraintMax
            // 
            this.txtBaseUpConstraintMax.BackColor = System.Drawing.Color.White;
            this.txtBaseUpConstraintMax.DecimalPlaces = 5;
            this.txtBaseUpConstraintMax.Location = new System.Drawing.Point(120, 23);
            this.txtBaseUpConstraintMax.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseUpConstraintMax.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseUpConstraintMax.Name = "txtBaseUpConstraintMax";
            this.txtBaseUpConstraintMax.Size = new System.Drawing.Size(49, 20);
            this.txtBaseUpConstraintMax.TabIndex = 27;
            this.txtBaseUpConstraintMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtBaseUpConstraintMax.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseUpConstraintMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseUpConstraintMax.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // txtBaseUpConstraintMin
            // 
            this.txtBaseUpConstraintMin.BackColor = System.Drawing.Color.White;
            this.txtBaseUpConstraintMin.DecimalPlaces = 5;
            this.txtBaseUpConstraintMin.Location = new System.Drawing.Point(39, 23);
            this.txtBaseUpConstraintMin.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseUpConstraintMin.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseUpConstraintMin.Name = "txtBaseUpConstraintMin";
            this.txtBaseUpConstraintMin.Size = new System.Drawing.Size(49, 20);
            this.txtBaseUpConstraintMin.TabIndex = 25;
            this.txtBaseUpConstraintMin.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseUpConstraintMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseUpConstraintMin.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.btn_ResetBaseDamping);
            this.groupBox5.Controls.Add(this.btn_ResetBaseStiffness);
            this.groupBox5.Controls.Add(this.txtBaseDamping);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtBaseStiffness);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(9, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 68);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // btn_ResetBaseDamping
            // 
            this.btn_ResetBaseDamping.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.btn_ResetBaseDamping.Image = global::TFMV.Properties.Resources.btn_reset;
            this.btn_ResetBaseDamping.Location = new System.Drawing.Point(5, 37);
            this.btn_ResetBaseDamping.Name = "btn_ResetBaseDamping";
            this.btn_ResetBaseDamping.Size = new System.Drawing.Size(19, 19);
            this.btn_ResetBaseDamping.TabIndex = 23;
            this.btn_ResetBaseDamping.UseVisualStyleBackColor = true;
            this.btn_ResetBaseDamping.Visible = false;
            this.btn_ResetBaseDamping.Click += new System.EventHandler(this.btn_reset_generic_Click);
            // 
            // btn_ResetBaseStiffness
            // 
            this.btn_ResetBaseStiffness.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.btn_ResetBaseStiffness.Image = global::TFMV.Properties.Resources.btn_reset;
            this.btn_ResetBaseStiffness.Location = new System.Drawing.Point(5, 14);
            this.btn_ResetBaseStiffness.Name = "btn_ResetBaseStiffness";
            this.btn_ResetBaseStiffness.Size = new System.Drawing.Size(19, 19);
            this.btn_ResetBaseStiffness.TabIndex = 22;
            this.btn_ResetBaseStiffness.UseVisualStyleBackColor = true;
            this.btn_ResetBaseStiffness.Visible = false;
            this.btn_ResetBaseStiffness.Click += new System.EventHandler(this.btn_reset_generic_Click);
            // 
            // txtBaseDamping
            // 
            this.txtBaseDamping.BackColor = System.Drawing.SystemColors.Window;
            this.txtBaseDamping.DecimalPlaces = 5;
            this.txtBaseDamping.Location = new System.Drawing.Point(125, 38);
            this.txtBaseDamping.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseDamping.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseDamping.Name = "txtBaseDamping";
            this.txtBaseDamping.Size = new System.Drawing.Size(60, 20);
            this.txtBaseDamping.TabIndex = 14;
            this.txtBaseDamping.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseDamping.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseDamping.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "stiffness:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "damping:";
            // 
            // txtBaseStiffness
            // 
            this.txtBaseStiffness.BackColor = System.Drawing.SystemColors.Window;
            this.txtBaseStiffness.DecimalPlaces = 5;
            this.txtBaseStiffness.Location = new System.Drawing.Point(125, 15);
            this.txtBaseStiffness.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBaseStiffness.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBaseStiffness.Name = "txtBaseStiffness";
            this.txtBaseStiffness.Size = new System.Drawing.Size(60, 20);
            this.txtBaseStiffness.TabIndex = 11;
            this.txtBaseStiffness.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBaseStiffness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBaseStiffness.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "along_damping:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "along_stiffness:";
            // 
            // grp_Along
            // 
            this.grp_Along.BackColor = System.Drawing.SystemColors.Control;
            this.grp_Along.Controls.Add(this.button5);
            this.grp_Along.Controls.Add(this.button6);
            this.grp_Along.Controls.Add(this.txtAlongDamping);
            this.grp_Along.Controls.Add(this.label3);
            this.grp_Along.Controls.Add(this.label4);
            this.grp_Along.Controls.Add(this.txtAlongStiffness);
            this.grp_Along.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Along.Location = new System.Drawing.Point(9, 477);
            this.grp_Along.Name = "grp_Along";
            this.grp_Along.Size = new System.Drawing.Size(194, 66);
            this.grp_Along.TabIndex = 16;
            this.grp_Along.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button5.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button5.Location = new System.Drawing.Point(5, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(19, 19);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button6.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button6.Location = new System.Drawing.Point(5, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(19, 19);
            this.button6.TabIndex = 24;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // txtAlongDamping
            // 
            this.txtAlongDamping.BackColor = System.Drawing.Color.White;
            this.txtAlongDamping.DecimalPlaces = 5;
            this.txtAlongDamping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlongDamping.Location = new System.Drawing.Point(125, 38);
            this.txtAlongDamping.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtAlongDamping.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtAlongDamping.Name = "txtAlongDamping";
            this.txtAlongDamping.Size = new System.Drawing.Size(60, 20);
            this.txtAlongDamping.TabIndex = 14;
            this.txtAlongDamping.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtAlongDamping.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtAlongDamping.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // txtAlongStiffness
            // 
            this.txtAlongStiffness.BackColor = System.Drawing.Color.White;
            this.txtAlongStiffness.DecimalPlaces = 5;
            this.txtAlongStiffness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlongStiffness.Location = new System.Drawing.Point(125, 15);
            this.txtAlongStiffness.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtAlongStiffness.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtAlongStiffness.Name = "txtAlongStiffness";
            this.txtAlongStiffness.Size = new System.Drawing.Size(60, 20);
            this.txtAlongStiffness.TabIndex = 11;
            this.txtAlongStiffness.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtAlongStiffness.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtAlongStiffness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtAlongStiffness.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.txtAngleConstraint);
            this.groupBox7.Controls.Add(this.chkAngleConstraint);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox7.Location = new System.Drawing.Point(9, 127);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(194, 42);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            // 
            // txtAngleConstraint
            // 
            this.txtAngleConstraint.DecimalPlaces = 5;
            this.txtAngleConstraint.Location = new System.Drawing.Point(125, 14);
            this.txtAngleConstraint.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtAngleConstraint.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtAngleConstraint.Name = "txtAngleConstraint";
            this.txtAngleConstraint.Size = new System.Drawing.Size(60, 20);
            this.txtAngleConstraint.TabIndex = 19;
            this.txtAngleConstraint.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtAngleConstraint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtAngleConstraint.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // chkAngleConstraint
            // 
            this.chkAngleConstraint.AutoSize = true;
            this.chkAngleConstraint.Location = new System.Drawing.Point(8, 16);
            this.chkAngleConstraint.Name = "chkAngleConstraint";
            this.chkAngleConstraint.Size = new System.Drawing.Size(107, 17);
            this.chkAngleConstraint.TabIndex = 18;
            this.chkAngleConstraint.Text = "angle_constraint:";
            this.chkAngleConstraint.UseVisualStyleBackColor = true;
            this.chkAngleConstraint.CheckedChanged += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(1907, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 13);
            this.label28.TabIndex = 36;
            this.label28.Text = "Bone Name:";
            // 
            // groupBox26
            // 
            this.groupBox26.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox26.Controls.Add(this.button12);
            this.groupBox26.Controls.Add(this.label29);
            this.groupBox26.Controls.Add(this.txtLength);
            this.groupBox26.Controls.Add(this.chkAllowLengthFlex);
            this.groupBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox26.Location = new System.Drawing.Point(9, 25);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(194, 60);
            this.groupBox26.TabIndex = 37;
            this.groupBox26.TabStop = false;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button12.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button12.Location = new System.Drawing.Point(5, 14);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(19, 19);
            this.button12.TabIndex = 22;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(25, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(39, 13);
            this.label29.TabIndex = 12;
            this.label29.Text = "length:";
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.SystemColors.Window;
            this.txtLength.DecimalPlaces = 5;
            this.txtLength.Location = new System.Drawing.Point(125, 16);
            this.txtLength.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtLength.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(60, 20);
            this.txtLength.TabIndex = 11;
            this.txtLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtLength.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtLength.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // chkAllowLengthFlex
            // 
            this.chkAllowLengthFlex.AutoSize = true;
            this.chkAllowLengthFlex.Location = new System.Drawing.Point(8, 36);
            this.chkAllowLengthFlex.Name = "chkAllowLengthFlex";
            this.chkAllowLengthFlex.Size = new System.Drawing.Size(107, 17);
            this.chkAllowLengthFlex.TabIndex = 42;
            this.chkAllowLengthFlex.Text = "allow_length_flex";
            this.chkAllowLengthFlex.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button11.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button11.Location = new System.Drawing.Point(5, 14);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(19, 19);
            this.button11.TabIndex = 23;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(25, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 13);
            this.label30.TabIndex = 13;
            this.label30.Text = "tip_mass:";
            // 
            // groupBox29
            // 
            this.groupBox29.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox29.Controls.Add(this.groupBox31);
            this.groupBox29.Controls.Add(this.btnPitchDamping);
            this.groupBox29.Controls.Add(this.btnPitchStiffness);
            this.groupBox29.Controls.Add(this.txtPitchDamping);
            this.groupBox29.Controls.Add(this.lblPitchStiffness);
            this.groupBox29.Controls.Add(this.lblPitchDamping);
            this.groupBox29.Controls.Add(this.txtPitchStiffness);
            this.groupBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox29.Location = new System.Drawing.Point(9, 332);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(194, 125);
            this.groupBox29.TabIndex = 38;
            this.groupBox29.TabStop = false;
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.label36);
            this.groupBox31.Controls.Add(this.label37);
            this.groupBox31.Controls.Add(this.txtPitchConstraintMax);
            this.groupBox31.Controls.Add(this.txtPitchConstraintMin);
            this.groupBox31.Controls.Add(this.chkPitchConstraint);
            this.groupBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox31.Location = new System.Drawing.Point(8, 65);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(179, 52);
            this.groupBox31.TabIndex = 37;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "     pitch_constraint";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(13, 25);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(27, 13);
            this.label36.TabIndex = 29;
            this.label36.Text = "Min:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(93, 25);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(30, 13);
            this.label37.TabIndex = 28;
            this.label37.Text = "Max:";
            // 
            // txtPitchConstraintMax
            // 
            this.txtPitchConstraintMax.BackColor = System.Drawing.SystemColors.Window;
            this.txtPitchConstraintMax.DecimalPlaces = 5;
            this.txtPitchConstraintMax.Location = new System.Drawing.Point(123, 23);
            this.txtPitchConstraintMax.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtPitchConstraintMax.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtPitchConstraintMax.Name = "txtPitchConstraintMax";
            this.txtPitchConstraintMax.Size = new System.Drawing.Size(49, 20);
            this.txtPitchConstraintMax.TabIndex = 27;
            this.txtPitchConstraintMax.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtPitchConstraintMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtPitchConstraintMax.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // txtPitchConstraintMin
            // 
            this.txtPitchConstraintMin.BackColor = System.Drawing.SystemColors.Window;
            this.txtPitchConstraintMin.DecimalPlaces = 5;
            this.txtPitchConstraintMin.Location = new System.Drawing.Point(43, 23);
            this.txtPitchConstraintMin.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtPitchConstraintMin.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtPitchConstraintMin.Name = "txtPitchConstraintMin";
            this.txtPitchConstraintMin.Size = new System.Drawing.Size(49, 20);
            this.txtPitchConstraintMin.TabIndex = 25;
            this.txtPitchConstraintMin.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtPitchConstraintMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtPitchConstraintMin.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // chkPitchConstraint
            // 
            this.chkPitchConstraint.AutoSize = true;
            this.chkPitchConstraint.Location = new System.Drawing.Point(4, 1);
            this.chkPitchConstraint.Name = "chkPitchConstraint";
            this.chkPitchConstraint.Size = new System.Drawing.Size(15, 14);
            this.chkPitchConstraint.TabIndex = 18;
            this.chkPitchConstraint.UseVisualStyleBackColor = true;
            this.chkPitchConstraint.CheckedChanged += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // btnPitchDamping
            // 
            this.btnPitchDamping.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.btnPitchDamping.Image = global::TFMV.Properties.Resources.btn_reset;
            this.btnPitchDamping.Location = new System.Drawing.Point(5, 39);
            this.btnPitchDamping.Name = "btnPitchDamping";
            this.btnPitchDamping.Size = new System.Drawing.Size(19, 19);
            this.btnPitchDamping.TabIndex = 23;
            this.btnPitchDamping.UseVisualStyleBackColor = true;
            this.btnPitchDamping.Visible = false;
            // 
            // btnPitchStiffness
            // 
            this.btnPitchStiffness.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.btnPitchStiffness.Image = global::TFMV.Properties.Resources.btn_reset;
            this.btnPitchStiffness.Location = new System.Drawing.Point(5, 16);
            this.btnPitchStiffness.Name = "btnPitchStiffness";
            this.btnPitchStiffness.Size = new System.Drawing.Size(19, 19);
            this.btnPitchStiffness.TabIndex = 22;
            this.btnPitchStiffness.UseVisualStyleBackColor = true;
            this.btnPitchStiffness.Visible = false;
            // 
            // txtPitchDamping
            // 
            this.txtPitchDamping.BackColor = System.Drawing.SystemColors.Window;
            this.txtPitchDamping.DecimalPlaces = 5;
            this.txtPitchDamping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPitchDamping.Location = new System.Drawing.Point(124, 38);
            this.txtPitchDamping.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtPitchDamping.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtPitchDamping.Name = "txtPitchDamping";
            this.txtPitchDamping.Size = new System.Drawing.Size(60, 20);
            this.txtPitchDamping.TabIndex = 14;
            this.txtPitchDamping.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtPitchDamping.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtPitchDamping.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // lblPitchStiffness
            // 
            this.lblPitchStiffness.AutoSize = true;
            this.lblPitchStiffness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitchStiffness.Location = new System.Drawing.Point(25, 18);
            this.lblPitchStiffness.Name = "lblPitchStiffness";
            this.lblPitchStiffness.Size = new System.Drawing.Size(77, 13);
            this.lblPitchStiffness.TabIndex = 12;
            this.lblPitchStiffness.Text = "pitch_stiffness:";
            // 
            // lblPitchDamping
            // 
            this.lblPitchDamping.AutoSize = true;
            this.lblPitchDamping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitchDamping.Location = new System.Drawing.Point(25, 41);
            this.lblPitchDamping.Name = "lblPitchDamping";
            this.lblPitchDamping.Size = new System.Drawing.Size(79, 13);
            this.lblPitchDamping.TabIndex = 13;
            this.lblPitchDamping.Text = "pitch_damping:";
            // 
            // txtPitchStiffness
            // 
            this.txtPitchStiffness.BackColor = System.Drawing.SystemColors.Window;
            this.txtPitchStiffness.DecimalPlaces = 5;
            this.txtPitchStiffness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPitchStiffness.Location = new System.Drawing.Point(124, 15);
            this.txtPitchStiffness.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtPitchStiffness.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtPitchStiffness.Name = "txtPitchStiffness";
            this.txtPitchStiffness.Size = new System.Drawing.Size(60, 20);
            this.txtPitchStiffness.TabIndex = 11;
            this.txtPitchStiffness.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtPitchStiffness.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtPitchStiffness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtPitchStiffness.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.numericUpDown15);
            this.groupBox30.Controls.Add(this.checkBox2);
            this.groupBox30.Controls.Add(this.txtPitchFriction);
            this.groupBox30.Controls.Add(this.chkPitchFriction);
            this.groupBox30.Location = new System.Drawing.Point(29, 601);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(179, 69);
            this.groupBox30.TabIndex = 38;
            this.groupBox30.TabStop = false;
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.numericUpDown15.DecimalPlaces = 5;
            this.numericUpDown15.Enabled = false;
            this.numericUpDown15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown15.Location = new System.Drawing.Point(111, 40);
            this.numericUpDown15.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown15.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown15.TabIndex = 21;
            this.numericUpDown15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.numericUpDown15.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(7, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 17);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "pitch_bounce:";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // txtPitchFriction
            // 
            this.txtPitchFriction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.txtPitchFriction.DecimalPlaces = 5;
            this.txtPitchFriction.Enabled = false;
            this.txtPitchFriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPitchFriction.Location = new System.Drawing.Point(111, 14);
            this.txtPitchFriction.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtPitchFriction.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtPitchFriction.Name = "txtPitchFriction";
            this.txtPitchFriction.Size = new System.Drawing.Size(60, 20);
            this.txtPitchFriction.TabIndex = 21;
            this.txtPitchFriction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtPitchFriction.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // chkPitchFriction
            // 
            this.chkPitchFriction.AutoSize = true;
            this.chkPitchFriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPitchFriction.Location = new System.Drawing.Point(7, 16);
            this.chkPitchFriction.Name = "chkPitchFriction";
            this.chkPitchFriction.Size = new System.Drawing.Size(89, 17);
            this.chkPitchFriction.TabIndex = 20;
            this.chkPitchFriction.Text = "pitch_friction:";
            this.chkPitchFriction.UseVisualStyleBackColor = true;
            this.chkPitchFriction.CheckedChanged += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(1356, 606);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 39;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1434, 606);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkHasBaseSpring
            // 
            this.chkHasBaseSpring.AutoSize = true;
            this.chkHasBaseSpring.Location = new System.Drawing.Point(2101, 213);
            this.chkHasBaseSpring.Name = "chkHasBaseSpring";
            this.chkHasBaseSpring.Size = new System.Drawing.Size(15, 14);
            this.chkHasBaseSpring.TabIndex = 41;
            this.chkHasBaseSpring.UseVisualStyleBackColor = true;
            this.chkHasBaseSpring.CheckedChanged += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // btnApplyJigglebones_OLD
            // 
            this.btnApplyJigglebones_OLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyJigglebones_OLD.Location = new System.Drawing.Point(1375, 531);
            this.btnApplyJigglebones_OLD.Name = "btnApplyJigglebones_OLD";
            this.btnApplyJigglebones_OLD.Size = new System.Drawing.Size(84, 32);
            this.btnApplyJigglebones_OLD.TabIndex = 43;
            this.btnApplyJigglebones_OLD.Text = "Preview";
            this.btnApplyJigglebones_OLD.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.button21);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.txtBoingDampingRate);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 47);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button21.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button21.Location = new System.Drawing.Point(6, 17);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(19, 19);
            this.button21.TabIndex = 24;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Visible = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(25, 19);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(74, 13);
            this.label41.TabIndex = 23;
            this.label41.Text = "damping_rate:";
            // 
            // txtBoingDampingRate
            // 
            this.txtBoingDampingRate.DecimalPlaces = 5;
            this.txtBoingDampingRate.Location = new System.Drawing.Point(121, 16);
            this.txtBoingDampingRate.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBoingDampingRate.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBoingDampingRate.Name = "txtBoingDampingRate";
            this.txtBoingDampingRate.Size = new System.Drawing.Size(60, 20);
            this.txtBoingDampingRate.TabIndex = 19;
            this.txtBoingDampingRate.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBoingDampingRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBoingDampingRate.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // groupBox32
            // 
            this.groupBox32.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox32.Controls.Add(this.button22);
            this.groupBox32.Controls.Add(this.button23);
            this.groupBox32.Controls.Add(this.txtBoingImpactAngle);
            this.groupBox32.Controls.Add(this.label42);
            this.groupBox32.Controls.Add(this.label43);
            this.groupBox32.Controls.Add(this.txtBoingImpactSpeed);
            this.groupBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox32.Location = new System.Drawing.Point(9, 25);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(194, 68);
            this.groupBox32.TabIndex = 44;
            this.groupBox32.TabStop = false;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button22.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button22.Location = new System.Drawing.Point(5, 37);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(19, 19);
            this.button22.TabIndex = 23;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Visible = false;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button23.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button23.Location = new System.Drawing.Point(5, 14);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(19, 19);
            this.button23.TabIndex = 22;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Visible = false;
            // 
            // txtBoingImpactAngle
            // 
            this.txtBoingImpactAngle.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoingImpactAngle.DecimalPlaces = 5;
            this.txtBoingImpactAngle.Location = new System.Drawing.Point(121, 40);
            this.txtBoingImpactAngle.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBoingImpactAngle.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBoingImpactAngle.Name = "txtBoingImpactAngle";
            this.txtBoingImpactAngle.Size = new System.Drawing.Size(60, 20);
            this.txtBoingImpactAngle.TabIndex = 14;
            this.txtBoingImpactAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.txtBoingImpactAngle.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBoingImpactAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBoingImpactAngle.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(24, 16);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(76, 13);
            this.label42.TabIndex = 12;
            this.label42.Text = "impact_speed:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(24, 40);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(73, 13);
            this.label43.TabIndex = 13;
            this.label43.Text = "impact_angle:";
            // 
            // txtBoingImpactSpeed
            // 
            this.txtBoingImpactSpeed.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoingImpactSpeed.DecimalPlaces = 5;
            this.txtBoingImpactSpeed.Location = new System.Drawing.Point(121, 16);
            this.txtBoingImpactSpeed.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBoingImpactSpeed.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBoingImpactSpeed.Name = "txtBoingImpactSpeed";
            this.txtBoingImpactSpeed.Size = new System.Drawing.Size(60, 20);
            this.txtBoingImpactSpeed.TabIndex = 11;
            this.txtBoingImpactSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtBoingImpactSpeed.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBoingImpactSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBoingImpactSpeed.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // groupBox33
            // 
            this.groupBox33.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox33.Controls.Add(this.button24);
            this.groupBox33.Controls.Add(this.button25);
            this.groupBox33.Controls.Add(this.txtBoingAmplitude);
            this.groupBox33.Controls.Add(this.label44);
            this.groupBox33.Controls.Add(this.label45);
            this.groupBox33.Controls.Add(this.txtBoingFrequency);
            this.groupBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox33.Location = new System.Drawing.Point(9, 138);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(194, 68);
            this.groupBox33.TabIndex = 46;
            this.groupBox33.TabStop = false;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button24.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button24.Location = new System.Drawing.Point(5, 37);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(19, 19);
            this.button24.TabIndex = 23;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Visible = false;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button25.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button25.Location = new System.Drawing.Point(5, 14);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(19, 19);
            this.button25.TabIndex = 22;
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Visible = false;
            // 
            // txtBoingAmplitude
            // 
            this.txtBoingAmplitude.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoingAmplitude.DecimalPlaces = 5;
            this.txtBoingAmplitude.Location = new System.Drawing.Point(121, 40);
            this.txtBoingAmplitude.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBoingAmplitude.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBoingAmplitude.Name = "txtBoingAmplitude";
            this.txtBoingAmplitude.Size = new System.Drawing.Size(60, 20);
            this.txtBoingAmplitude.TabIndex = 14;
            this.txtBoingAmplitude.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBoingAmplitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBoingAmplitude.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(24, 16);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(57, 13);
            this.label44.TabIndex = 12;
            this.label44.Text = "frequency:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(24, 40);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(55, 13);
            this.label45.TabIndex = 13;
            this.label45.Text = "amplitude:";
            // 
            // txtBoingFrequency
            // 
            this.txtBoingFrequency.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoingFrequency.DecimalPlaces = 5;
            this.txtBoingFrequency.Location = new System.Drawing.Point(121, 16);
            this.txtBoingFrequency.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtBoingFrequency.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtBoingFrequency.Name = "txtBoingFrequency";
            this.txtBoingFrequency.Size = new System.Drawing.Size(60, 20);
            this.txtBoingFrequency.TabIndex = 11;
            this.txtBoingFrequency.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtBoingFrequency.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtBoingFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtBoingFrequency.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(1750, 239);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(64, 13);
            this.label46.TabIndex = 48;
            this.label46.Text = "Jiggle Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "none",
            "is_flexible",
            "is_rigid",
            "is_boing"});
            this.comboBox1.Location = new System.Drawing.Point(1853, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // lstPropertyGroupsMain
            // 
            this.lstPropertyGroupsMain.FormattingEnabled = true;
            this.lstPropertyGroupsMain.Location = new System.Drawing.Point(232, 22);
            this.lstPropertyGroupsMain.Name = "lstPropertyGroupsMain";
            this.lstPropertyGroupsMain.Size = new System.Drawing.Size(212, 34);
            this.lstPropertyGroupsMain.TabIndex = 49;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(9, 5);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(86, 15);
            this.label47.TabIndex = 51;
            this.label47.Text = "Bone Name:";
            // 
            // lstBoneName
            // 
            this.lstBoneName.FormattingEnabled = true;
            this.lstBoneName.Location = new System.Drawing.Point(12, 22);
            this.lstBoneName.Name = "lstBoneName";
            this.lstBoneName.Size = new System.Drawing.Size(212, 69);
            this.lstBoneName.TabIndex = 52;
            this.lstBoneName.SelectedIndexChanged += new System.EventHandler(this.lstBoneName_SelectedIndexChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label48.Location = new System.Drawing.Point(229, 5);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(114, 15);
            this.label48.TabIndex = 53;
            this.label48.Text = "Property Groups:";
            // 
            // lstPropertyGroupsSub
            // 
            this.lstPropertyGroupsSub.FormattingEnabled = true;
            this.lstPropertyGroupsSub.Location = new System.Drawing.Point(232, 57);
            this.lstPropertyGroupsSub.Name = "lstPropertyGroupsSub";
            this.lstPropertyGroupsSub.Size = new System.Drawing.Size(212, 34);
            this.lstPropertyGroupsSub.TabIndex = 55;
            // 
            // chk_isRigid
            // 
            this.chk_isRigid.AutoSize = true;
            this.chk_isRigid.BackColor = System.Drawing.SystemColors.Window;
            this.chk_isRigid.Location = new System.Drawing.Point(235, 23);
            this.chk_isRigid.Name = "chk_isRigid";
            this.chk_isRigid.Size = new System.Drawing.Size(58, 17);
            this.chk_isRigid.TabIndex = 56;
            this.chk_isRigid.Text = "is_rigid";
            this.chk_isRigid.UseVisualStyleBackColor = false;
            this.chk_isRigid.CheckedChanged += new System.EventHandler(this.chk_isRigid_CheckedChanged);
            // 
            // chk_isFlexible
            // 
            this.chk_isFlexible.AutoSize = true;
            this.chk_isFlexible.BackColor = System.Drawing.SystemColors.Window;
            this.chk_isFlexible.Location = new System.Drawing.Point(235, 38);
            this.chk_isFlexible.Name = "chk_isFlexible";
            this.chk_isFlexible.Size = new System.Drawing.Size(71, 17);
            this.chk_isFlexible.TabIndex = 57;
            this.chk_isFlexible.Text = "is_flexible";
            this.chk_isFlexible.UseVisualStyleBackColor = false;
            this.chk_isFlexible.CheckedChanged += new System.EventHandler(this.chk_isFlexible_CheckedChanged);
            // 
            // chk_isBoing
            // 
            this.chk_isBoing.AutoSize = true;
            this.chk_isBoing.BackColor = System.Drawing.SystemColors.Window;
            this.chk_isBoing.Location = new System.Drawing.Point(235, 73);
            this.chk_isBoing.Name = "chk_isBoing";
            this.chk_isBoing.Size = new System.Drawing.Size(65, 17);
            this.chk_isBoing.TabIndex = 59;
            this.chk_isBoing.Text = "is_boing";
            this.chk_isBoing.UseVisualStyleBackColor = false;
            this.chk_isBoing.CheckedChanged += new System.EventHandler(this.chk_isBoing_CheckedChanged);
            // 
            // chk_hasBaseSpring
            // 
            this.chk_hasBaseSpring.AutoSize = true;
            this.chk_hasBaseSpring.BackColor = System.Drawing.SystemColors.Window;
            this.chk_hasBaseSpring.Location = new System.Drawing.Point(235, 58);
            this.chk_hasBaseSpring.Name = "chk_hasBaseSpring";
            this.chk_hasBaseSpring.Size = new System.Drawing.Size(106, 17);
            this.chk_hasBaseSpring.TabIndex = 58;
            this.chk_hasBaseSpring.Text = "has_base_spring";
            this.chk_hasBaseSpring.UseVisualStyleBackColor = false;
            this.chk_hasBaseSpring.CheckedChanged += new System.EventHandler(this.chk_hasBaseSpring_CheckedChanged);
            // 
            // grp_IS_BOING
            // 
            this.grp_IS_BOING.BackColor = System.Drawing.SystemColors.Control;
            this.grp_IS_BOING.Controls.Add(this.groupBox32);
            this.grp_IS_BOING.Controls.Add(this.groupBox4);
            this.grp_IS_BOING.Controls.Add(this.groupBox33);
            this.grp_IS_BOING.Controls.Add(this.lbl_IS_BOING);
            this.grp_IS_BOING.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_IS_BOING.Location = new System.Drawing.Point(807, 664);
            this.grp_IS_BOING.Name = "grp_IS_BOING";
            this.grp_IS_BOING.Size = new System.Drawing.Size(212, 551);
            this.grp_IS_BOING.TabIndex = 60;
            this.grp_IS_BOING.TabStop = false;
            // 
            // lbl_IS_BOING
            // 
            this.lbl_IS_BOING.BackColor = System.Drawing.Color.Gray;
            this.lbl_IS_BOING.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_IS_BOING.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_IS_BOING.Location = new System.Drawing.Point(0, 0);
            this.lbl_IS_BOING.Name = "lbl_IS_BOING";
            this.lbl_IS_BOING.Size = new System.Drawing.Size(212, 23);
            this.lbl_IS_BOING.TabIndex = 78;
            this.lbl_IS_BOING.Text = "IS_BOING";
            this.lbl_IS_BOING.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_QC
            // 
            this.txt_QC.BackColor = System.Drawing.SystemColors.Window;
            this.txt_QC.ContextMenuStrip = this.menuQCEditor;
            this.txt_QC.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_QC.Location = new System.Drawing.Point(453, 22);
            this.txt_QC.Multiline = true;
            this.txt_QC.Name = "txt_QC";
            this.txt_QC.ReadOnly = true;
            this.txt_QC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_QC.Size = new System.Drawing.Size(306, 584);
            this.txt_QC.TabIndex = 61;
            this.txt_QC.TextChanged += new System.EventHandler(this.txt_QC_TextChanged);
            this.txt_QC.Enter += new System.EventHandler(this.txt_QC_Enter);
            // 
            // menuQCEditor
            // 
            this.menuQCEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtn_QC_Cut,
            this.menubtn_QC_Copy,
            this.menubtn_QC_Paste,
            this.menubtn_QC_Delete,
            this.toolStripSeparator1,
            this.menubtn_QC_Select_Current,
            this.menubtn_QC_Select_All});
            this.menuQCEditor.Name = "menuQCEditor";
            this.menuQCEditor.Size = new System.Drawing.Size(149, 142);
            // 
            // menubtn_QC_Cut
            // 
            this.menubtn_QC_Cut.Enabled = false;
            this.menubtn_QC_Cut.Name = "menubtn_QC_Cut";
            this.menubtn_QC_Cut.Size = new System.Drawing.Size(148, 22);
            this.menubtn_QC_Cut.Text = "Cut";
            this.menubtn_QC_Cut.Visible = false;
            // 
            // menubtn_QC_Copy
            // 
            this.menubtn_QC_Copy.Name = "menubtn_QC_Copy";
            this.menubtn_QC_Copy.Size = new System.Drawing.Size(148, 22);
            this.menubtn_QC_Copy.Text = "Copy";
            this.menubtn_QC_Copy.Click += new System.EventHandler(this.menubtn_QC_Copy_Click);
            // 
            // menubtn_QC_Paste
            // 
            this.menubtn_QC_Paste.Enabled = false;
            this.menubtn_QC_Paste.Name = "menubtn_QC_Paste";
            this.menubtn_QC_Paste.Size = new System.Drawing.Size(148, 22);
            this.menubtn_QC_Paste.Text = "Paste";
            this.menubtn_QC_Paste.Visible = false;
            // 
            // menubtn_QC_Delete
            // 
            this.menubtn_QC_Delete.Enabled = false;
            this.menubtn_QC_Delete.Name = "menubtn_QC_Delete";
            this.menubtn_QC_Delete.Size = new System.Drawing.Size(148, 22);
            this.menubtn_QC_Delete.Text = "Delete";
            this.menubtn_QC_Delete.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // menubtn_QC_Select_Current
            // 
            this.menubtn_QC_Select_Current.Name = "menubtn_QC_Select_Current";
            this.menubtn_QC_Select_Current.Size = new System.Drawing.Size(148, 22);
            this.menubtn_QC_Select_Current.Text = "Select Current";
            this.menubtn_QC_Select_Current.Click += new System.EventHandler(this.menubtn_QC_Select_Current_Click);
            // 
            // menubtn_QC_Select_All
            // 
            this.menubtn_QC_Select_All.Name = "menubtn_QC_Select_All";
            this.menubtn_QC_Select_All.Size = new System.Drawing.Size(148, 22);
            this.menubtn_QC_Select_All.Text = "Select All";
            this.menubtn_QC_Select_All.Click += new System.EventHandler(this.menubtn_QC_Select_All_Click);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label49.Location = new System.Drawing.Point(451, 5);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(72, 15);
            this.label49.TabIndex = 62;
            this.label49.Text = "QC String:";
            // 
            // btn_HideQC
            // 
            this.btn_HideQC.BackColor = System.Drawing.SystemColors.Control;
            this.btn_HideQC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HideQC.Location = new System.Drawing.Point(76, 835);
            this.btn_HideQC.Name = "btn_HideQC";
            this.btn_HideQC.Size = new System.Drawing.Size(75, 21);
            this.btn_HideQC.TabIndex = 63;
            this.btn_HideQC.Text = "Hide QC <";
            this.btn_HideQC.UseVisualStyleBackColor = false;
            this.btn_HideQC.Visible = false;
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.SystemColors.GrayText;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label50.ForeColor = System.Drawing.SystemColors.Control;
            this.label50.Location = new System.Drawing.Point(1605, 98);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(192, 23);
            this.label50.TabIndex = 64;
            this.label50.Text = "YAW";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(1907, 204);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(45, 13);
            this.label51.TabIndex = 68;
            this.label51.Text = "Presets:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Feather 1",
            "Feather 2",
            "Feather Tip",
            "Floating Pet",
            "Bird Base (keep upright)",
            "Up and down",
            "etc"});
            this.comboBox2.Location = new System.Drawing.Point(1958, 178);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 21);
            this.comboBox2.TabIndex = 67;
            // 
            // groupBox35
            // 
            this.groupBox35.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox35.Controls.Add(this.btn_QC_copy);
            this.groupBox35.Controls.Add(this.btn_QC_select_all);
            this.groupBox35.Controls.Add(this.btn_QC_select_current);
            this.groupBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox35.Location = new System.Drawing.Point(453, 600);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Size = new System.Drawing.Size(306, 48);
            this.groupBox35.TabIndex = 70;
            this.groupBox35.TabStop = false;
            // 
            // btn_QC_copy
            // 
            this.btn_QC_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QC_copy.Location = new System.Drawing.Point(211, 15);
            this.btn_QC_copy.Name = "btn_QC_copy";
            this.btn_QC_copy.Size = new System.Drawing.Size(82, 23);
            this.btn_QC_copy.TabIndex = 70;
            this.btn_QC_copy.Text = "Copy";
            this.btn_QC_copy.UseVisualStyleBackColor = true;
            this.btn_QC_copy.Click += new System.EventHandler(this.btn_QC_copy_Click);
            // 
            // btn_QC_select_all
            // 
            this.btn_QC_select_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QC_select_all.Location = new System.Drawing.Point(122, 15);
            this.btn_QC_select_all.Name = "btn_QC_select_all";
            this.btn_QC_select_all.Size = new System.Drawing.Size(82, 23);
            this.btn_QC_select_all.TabIndex = 70;
            this.btn_QC_select_all.Text = "Select All";
            this.btn_QC_select_all.UseVisualStyleBackColor = true;
            this.btn_QC_select_all.Click += new System.EventHandler(this.btn_QC_select_all_Click);
            // 
            // btn_QC_select_current
            // 
            this.btn_QC_select_current.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QC_select_current.Location = new System.Drawing.Point(13, 15);
            this.btn_QC_select_current.Name = "btn_QC_select_current";
            this.btn_QC_select_current.Size = new System.Drawing.Size(102, 23);
            this.btn_QC_select_current.TabIndex = 70;
            this.btn_QC_select_current.Text = "Select Current";
            this.btn_QC_select_current.UseVisualStyleBackColor = true;
            this.btn_QC_select_current.Click += new System.EventHandler(this.btn_QC_select_current_Click);
            // 
            // button30
            // 
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Location = new System.Drawing.Point(1100, 71);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(102, 23);
            this.button30.TabIndex = 72;
            this.button30.Text = "Load preset...";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Location = new System.Drawing.Point(1218, 67);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(82, 23);
            this.button29.TabIndex = 71;
            this.button29.Text = "Paste";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // label58
            // 
            this.label58.BackColor = System.Drawing.SystemColors.Control;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label58.Location = new System.Drawing.Point(15, 149);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(185, 23);
            this.label58.TabIndex = 74;
            this.label58.Text = "YAW";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grp_IS_FLEXIBLE
            // 
            this.grp_IS_FLEXIBLE.BackColor = System.Drawing.SystemColors.Control;
            this.grp_IS_FLEXIBLE.Controls.Add(this.lbl_Along);
            this.grp_IS_FLEXIBLE.Controls.Add(this.label2);
            this.grp_IS_FLEXIBLE.Controls.Add(this.label1);
            this.grp_IS_FLEXIBLE.Controls.Add(this.groupBox48);
            this.grp_IS_FLEXIBLE.Controls.Add(this.lbl_IS_FLEXIBLE);
            this.grp_IS_FLEXIBLE.Controls.Add(this.groupBox26);
            this.grp_IS_FLEXIBLE.Controls.Add(this.groupBox1);
            this.grp_IS_FLEXIBLE.Controls.Add(this.grp_Along);
            this.grp_IS_FLEXIBLE.Controls.Add(this.groupBox7);
            this.grp_IS_FLEXIBLE.Controls.Add(this.groupBox29);
            this.grp_IS_FLEXIBLE.Controls.Add(this.label58);
            this.grp_IS_FLEXIBLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_IS_FLEXIBLE.Location = new System.Drawing.Point(804, 26);
            this.grp_IS_FLEXIBLE.Name = "grp_IS_FLEXIBLE";
            this.grp_IS_FLEXIBLE.Size = new System.Drawing.Size(212, 551);
            this.grp_IS_FLEXIBLE.TabIndex = 75;
            this.grp_IS_FLEXIBLE.TabStop = false;
            // 
            // lbl_Along
            // 
            this.lbl_Along.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Along.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Along.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Along.Location = new System.Drawing.Point(9, 463);
            this.lbl_Along.Name = "lbl_Along";
            this.lbl_Along.Size = new System.Drawing.Size(194, 23);
            this.lbl_Along.TabIndex = 82;
            this.lbl_Along.Text = "ALONG";
            this.lbl_Along.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(9, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 81;
            this.label2.Text = "PITCH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(9, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 80;
            this.label1.Text = "YAW";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox48
            // 
            this.groupBox48.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox48.Controls.Add(this.label30);
            this.groupBox48.Controls.Add(this.txtTipMass);
            this.groupBox48.Controls.Add(this.button11);
            this.groupBox48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox48.Location = new System.Drawing.Point(9, 85);
            this.groupBox48.Name = "groupBox48";
            this.groupBox48.Size = new System.Drawing.Size(194, 42);
            this.groupBox48.TabIndex = 75;
            this.groupBox48.TabStop = false;
            // 
            // txtTipMass
            // 
            this.txtTipMass.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipMass.DecimalPlaces = 5;
            this.txtTipMass.Location = new System.Drawing.Point(125, 15);
            this.txtTipMass.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtTipMass.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.txtTipMass.Name = "txtTipMass";
            this.txtTipMass.Size = new System.Drawing.Size(60, 20);
            this.txtTipMass.TabIndex = 14;
            this.txtTipMass.ValueChanged += new System.EventHandler(this.numericUpDown_any_ValueChanged);
            this.txtTipMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeric_KeyPress);
            this.txtTipMass.Leave += new System.EventHandler(this.jigglePropertyChanged);
            // 
            // lbl_IS_FLEXIBLE
            // 
            this.lbl_IS_FLEXIBLE.BackColor = System.Drawing.Color.Gray;
            this.lbl_IS_FLEXIBLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_IS_FLEXIBLE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_IS_FLEXIBLE.Location = new System.Drawing.Point(0, 0);
            this.lbl_IS_FLEXIBLE.Name = "lbl_IS_FLEXIBLE";
            this.lbl_IS_FLEXIBLE.Size = new System.Drawing.Size(212, 23);
            this.lbl_IS_FLEXIBLE.TabIndex = 71;
            this.lbl_IS_FLEXIBLE.Text = "IS_FLEXIBLE";
            this.lbl_IS_FLEXIBLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label59
            // 
            this.label59.BackColor = System.Drawing.Color.Gray;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label59.Location = new System.Drawing.Point(1745, 772);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(195, 23);
            this.label59.TabIndex = 75;
            this.label59.Text = "FORWARD";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label60
            // 
            this.label60.BackColor = System.Drawing.Color.Gray;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label60.Location = new System.Drawing.Point(1745, 639);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(195, 23);
            this.label60.TabIndex = 74;
            this.label60.Text = "UP";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label61
            // 
            this.label61.BackColor = System.Drawing.Color.Gray;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label61.Location = new System.Drawing.Point(1743, 504);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(195, 23);
            this.label61.TabIndex = 73;
            this.label61.Text = "LEFT";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox37
            // 
            this.groupBox37.Controls.Add(this.groupBox38);
            this.groupBox37.Controls.Add(this.groupBox39);
            this.groupBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox37.Location = new System.Drawing.Point(1743, 514);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Size = new System.Drawing.Size(195, 120);
            this.groupBox37.TabIndex = 36;
            this.groupBox37.TabStop = false;
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.button31);
            this.groupBox38.Controls.Add(this.label62);
            this.groupBox38.Controls.Add(this.numericUpDown2);
            this.groupBox38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox38.Location = new System.Drawing.Point(9, 71);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(179, 42);
            this.groupBox38.TabIndex = 36;
            this.groupBox38.TabStop = false;
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button31.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button31.Location = new System.Drawing.Point(2, 13);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(19, 19);
            this.button31.TabIndex = 27;
            this.button31.UseVisualStyleBackColor = true;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(21, 16);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(61, 13);
            this.label62.TabIndex = 26;
            this.label62.Text = "left_friction:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.numericUpDown2.Location = new System.Drawing.Point(112, 14);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown2.TabIndex = 21;
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.button32);
            this.groupBox39.Controls.Add(this.label63);
            this.groupBox39.Controls.Add(this.label64);
            this.groupBox39.Controls.Add(this.numericUpDown3);
            this.groupBox39.Controls.Add(this.numericUpDown4);
            this.groupBox39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox39.Location = new System.Drawing.Point(9, 20);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Size = new System.Drawing.Size(179, 52);
            this.groupBox39.TabIndex = 35;
            this.groupBox39.TabStop = false;
            this.groupBox39.Text = "      left_constraint";
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button32.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button32.Location = new System.Drawing.Point(2, -3);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(19, 19);
            this.button32.TabIndex = 39;
            this.button32.UseVisualStyleBackColor = true;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(9, 25);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(27, 13);
            this.label63.TabIndex = 29;
            this.label63.Text = "Min:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(89, 25);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(30, 13);
            this.label64.TabIndex = 28;
            this.label64.Text = "Max:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.numericUpDown3.Location = new System.Drawing.Point(120, 23);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown3.TabIndex = 27;
            this.numericUpDown3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.numericUpDown4.Location = new System.Drawing.Point(39, 23);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown4.TabIndex = 25;
            // 
            // groupBox40
            // 
            this.groupBox40.Controls.Add(this.groupBox41);
            this.groupBox40.Controls.Add(this.groupBox42);
            this.groupBox40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox40.Location = new System.Drawing.Point(1743, 782);
            this.groupBox40.Name = "groupBox40";
            this.groupBox40.Size = new System.Drawing.Size(195, 120);
            this.groupBox40.TabIndex = 40;
            this.groupBox40.TabStop = false;
            // 
            // groupBox41
            // 
            this.groupBox41.Controls.Add(this.button33);
            this.groupBox41.Controls.Add(this.label66);
            this.groupBox41.Controls.Add(this.numericUpDown5);
            this.groupBox41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox41.Location = new System.Drawing.Point(9, 69);
            this.groupBox41.Name = "groupBox41";
            this.groupBox41.Size = new System.Drawing.Size(179, 42);
            this.groupBox41.TabIndex = 36;
            this.groupBox41.TabStop = false;
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button33.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button33.Location = new System.Drawing.Point(2, 13);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(19, 19);
            this.button33.TabIndex = 27;
            this.button33.UseVisualStyleBackColor = true;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(21, 16);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(82, 13);
            this.label66.TabIndex = 26;
            this.label66.Text = "forward_friction:";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.numericUpDown5.Location = new System.Drawing.Point(112, 14);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown5.TabIndex = 21;
            // 
            // groupBox42
            // 
            this.groupBox42.Controls.Add(this.button34);
            this.groupBox42.Controls.Add(this.label67);
            this.groupBox42.Controls.Add(this.label68);
            this.groupBox42.Controls.Add(this.numericUpDown6);
            this.groupBox42.Controls.Add(this.numericUpDown7);
            this.groupBox42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox42.Location = new System.Drawing.Point(9, 18);
            this.groupBox42.Name = "groupBox42";
            this.groupBox42.Size = new System.Drawing.Size(179, 52);
            this.groupBox42.TabIndex = 35;
            this.groupBox42.TabStop = false;
            this.groupBox42.Text = "      forward_constraint";
            // 
            // button34
            // 
            this.button34.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button34.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button34.Location = new System.Drawing.Point(2, -3);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(19, 19);
            this.button34.TabIndex = 38;
            this.button34.UseVisualStyleBackColor = true;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(9, 25);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(27, 13);
            this.label67.TabIndex = 29;
            this.label67.Text = "Min:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(89, 25);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(30, 13);
            this.label68.TabIndex = 28;
            this.label68.Text = "Max:";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.numericUpDown6.Location = new System.Drawing.Point(120, 23);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown6.TabIndex = 27;
            this.numericUpDown6.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.numericUpDown7.Location = new System.Drawing.Point(39, 23);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown7.TabIndex = 25;
            // 
            // groupBox43
            // 
            this.groupBox43.Controls.Add(this.button35);
            this.groupBox43.Controls.Add(this.label69);
            this.groupBox43.Controls.Add(this.numericUpDown8);
            this.groupBox43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox43.Location = new System.Drawing.Point(1745, 451);
            this.groupBox43.Name = "groupBox43";
            this.groupBox43.Size = new System.Drawing.Size(194, 47);
            this.groupBox43.TabIndex = 39;
            this.groupBox43.TabStop = false;
            // 
            // button35
            // 
            this.button35.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button35.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button35.Location = new System.Drawing.Point(6, 17);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(19, 19);
            this.button35.TabIndex = 24;
            this.button35.UseVisualStyleBackColor = true;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(25, 19);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(63, 13);
            this.label69.TabIndex = 23;
            this.label69.Text = "base_mass:";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(121, 16);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown8.TabIndex = 19;
            // 
            // groupBox44
            // 
            this.groupBox44.Controls.Add(this.groupBox45);
            this.groupBox44.Controls.Add(this.groupBox46);
            this.groupBox44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox44.Location = new System.Drawing.Point(1743, 647);
            this.groupBox44.Name = "groupBox44";
            this.groupBox44.Size = new System.Drawing.Size(195, 120);
            this.groupBox44.TabIndex = 37;
            this.groupBox44.TabStop = false;
            // 
            // groupBox45
            // 
            this.groupBox45.Controls.Add(this.button36);
            this.groupBox45.Controls.Add(this.label70);
            this.groupBox45.Controls.Add(this.numericUpDown9);
            this.groupBox45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox45.Location = new System.Drawing.Point(9, 71);
            this.groupBox45.Name = "groupBox45";
            this.groupBox45.Size = new System.Drawing.Size(179, 42);
            this.groupBox45.TabIndex = 36;
            this.groupBox45.TabStop = false;
            // 
            // button36
            // 
            this.button36.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button36.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button36.Location = new System.Drawing.Point(2, 14);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(19, 19);
            this.button36.TabIndex = 27;
            this.button36.UseVisualStyleBackColor = true;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(21, 16);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(59, 13);
            this.label70.TabIndex = 26;
            this.label70.Text = "up_friction:";
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.numericUpDown9.Location = new System.Drawing.Point(112, 14);
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown9.TabIndex = 21;
            // 
            // groupBox46
            // 
            this.groupBox46.Controls.Add(this.button37);
            this.groupBox46.Controls.Add(this.label71);
            this.groupBox46.Controls.Add(this.label72);
            this.groupBox46.Controls.Add(this.numericUpDown10);
            this.groupBox46.Controls.Add(this.numericUpDown11);
            this.groupBox46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox46.Location = new System.Drawing.Point(9, 20);
            this.groupBox46.Name = "groupBox46";
            this.groupBox46.Size = new System.Drawing.Size(179, 52);
            this.groupBox46.TabIndex = 35;
            this.groupBox46.TabStop = false;
            this.groupBox46.Text = "      up_constraint";
            // 
            // button37
            // 
            this.button37.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button37.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button37.Location = new System.Drawing.Point(2, -3);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(19, 19);
            this.button37.TabIndex = 38;
            this.button37.UseVisualStyleBackColor = true;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(9, 25);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(27, 13);
            this.label71.TabIndex = 29;
            this.label71.Text = "Min:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(89, 25);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(30, 13);
            this.label72.TabIndex = 28;
            this.label72.Text = "Max:";
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.numericUpDown10.Location = new System.Drawing.Point(120, 23);
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown10.TabIndex = 27;
            this.numericUpDown10.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.numericUpDown11.Location = new System.Drawing.Point(39, 23);
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown11.TabIndex = 25;
            // 
            // groupBox47
            // 
            this.groupBox47.Controls.Add(this.button38);
            this.groupBox47.Controls.Add(this.button39);
            this.groupBox47.Controls.Add(this.numericUpDown12);
            this.groupBox47.Controls.Add(this.label73);
            this.groupBox47.Controls.Add(this.label74);
            this.groupBox47.Controls.Add(this.numericUpDown13);
            this.groupBox47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox47.Location = new System.Drawing.Point(1745, 382);
            this.groupBox47.Name = "groupBox47";
            this.groupBox47.Size = new System.Drawing.Size(193, 68);
            this.groupBox47.TabIndex = 19;
            this.groupBox47.TabStop = false;
            // 
            // button38
            // 
            this.button38.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button38.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button38.Location = new System.Drawing.Point(2, 37);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(19, 19);
            this.button38.TabIndex = 23;
            this.button38.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button39.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button39.Location = new System.Drawing.Point(2, 14);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(19, 19);
            this.button39.TabIndex = 22;
            this.button39.UseVisualStyleBackColor = true;
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown12.Location = new System.Drawing.Point(121, 40);
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown12.TabIndex = 14;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(21, 16);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(48, 13);
            this.label73.TabIndex = 12;
            this.label73.Text = "stiffness:";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(21, 40);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(50, 13);
            this.label74.TabIndex = 13;
            this.label74.Text = "damping:";
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown13.Location = new System.Drawing.Point(121, 16);
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown13.TabIndex = 11;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(1695, 348);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(292, 13);
            this.label75.TabIndex = 76;
            this.label75.Text = "No bone BONENAME found on model, change bone name?";
            // 
            // menuResetValue
            // 
            this.menuResetValue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToDefaultToolStripMenuItem,
            this.revertToOriginalboneNameValueToolStripMenuItem});
            this.menuResetValue.Name = "menuResetValue";
            this.menuResetValue.Size = new System.Drawing.Size(275, 48);
            this.menuResetValue.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // resetToDefaultToolStripMenuItem
            // 
            this.resetToDefaultToolStripMenuItem.Name = "resetToDefaultToolStripMenuItem";
            this.resetToDefaultToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.resetToDefaultToolStripMenuItem.Text = "Reset to default value";
            this.resetToDefaultToolStripMenuItem.Click += new System.EventHandler(this.resetToDefaultToolStripMenuItem_Click);
            // 
            // revertToOriginalboneNameValueToolStripMenuItem
            // 
            this.revertToOriginalboneNameValueToolStripMenuItem.Name = "revertToOriginalboneNameValueToolStripMenuItem";
            this.revertToOriginalboneNameValueToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.revertToOriginalboneNameValueToolStripMenuItem.Text = "Revert to original <bone name> value";
            this.revertToOriginalboneNameValueToolStripMenuItem.Click += new System.EventHandler(this.revertToOriginalboneNameValueToolStripMenuItem_Click);
            // 
            // btn_reset_generic
            // 
            this.btn_reset_generic.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.btn_reset_generic.Image = global::TFMV.Properties.Resources.btn_reset;
            this.btn_reset_generic.Location = new System.Drawing.Point(2117, 280);
            this.btn_reset_generic.Name = "btn_reset_generic";
            this.btn_reset_generic.Size = new System.Drawing.Size(19, 19);
            this.btn_reset_generic.TabIndex = 40;
            this.btn_reset_generic.UseVisualStyleBackColor = true;
            this.btn_reset_generic.Click += new System.EventHandler(this.btn_reset_generic_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.groupBox16);
            this.groupBox2.Controls.Add(this.groupBox30);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox27);
            this.groupBox2.Controls.Add(this.lbl_IS_RIGID);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.groupBox14);
            this.groupBox2.Controls.Add(this.groupBox15);
            this.groupBox2.Controls.Add(this.label78);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1040, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 686);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.numericUpDown27);
            this.groupBox16.Controls.Add(this.label5);
            this.groupBox16.Controls.Add(this.checkBox8);
            this.groupBox16.Controls.Add(this.numericUpDown28);
            this.groupBox16.Controls.Add(this.checkBox9);
            this.groupBox16.Location = new System.Drawing.Point(18, 484);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(179, 69);
            this.groupBox16.TabIndex = 38;
            this.groupBox16.TabStop = false;
            // 
            // numericUpDown27
            // 
            this.numericUpDown27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.numericUpDown27.DecimalPlaces = 5;
            this.numericUpDown27.Enabled = false;
            this.numericUpDown27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown27.Location = new System.Drawing.Point(111, 40);
            this.numericUpDown27.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown27.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown27.Name = "numericUpDown27";
            this.numericUpDown27.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown27.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "these are from old is_flexible";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(7, 42);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(94, 17);
            this.checkBox8.TabIndex = 20;
            this.checkBox8.Text = "pitch_bounce:";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // numericUpDown28
            // 
            this.numericUpDown28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.numericUpDown28.DecimalPlaces = 5;
            this.numericUpDown28.Enabled = false;
            this.numericUpDown28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown28.Location = new System.Drawing.Point(111, 14);
            this.numericUpDown28.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown28.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown28.Name = "numericUpDown28";
            this.numericUpDown28.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown28.TabIndex = 21;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(7, 16);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(89, 17);
            this.checkBox9.TabIndex = 20;
            this.checkBox9.Text = "pitch_friction:";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DarkGray;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(9, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 23);
            this.label14.TabIndex = 81;
            this.label14.Text = "PITCH";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.DarkGray;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(9, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 23);
            this.label15.TabIndex = 80;
            this.label15.Text = "YAW";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.numericUpDown16);
            this.groupBox8.Controls.Add(this.button3);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox8.Location = new System.Drawing.Point(9, 68);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(194, 42);
            this.groupBox8.TabIndex = 75;
            this.groupBox8.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "tip_mass:";
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown16.DecimalPlaces = 5;
            this.numericUpDown16.Location = new System.Drawing.Point(125, 16);
            this.numericUpDown16.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown16.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown16.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button3.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button3.Location = new System.Drawing.Point(5, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(19, 19);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // lbl_IS_RIGID
            // 
            this.lbl_IS_RIGID.BackColor = System.Drawing.Color.Gray;
            this.lbl_IS_RIGID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_IS_RIGID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_IS_RIGID.Location = new System.Drawing.Point(0, 0);
            this.lbl_IS_RIGID.Name = "lbl_IS_RIGID";
            this.lbl_IS_RIGID.Size = new System.Drawing.Size(212, 23);
            this.lbl_IS_RIGID.TabIndex = 71;
            this.lbl_IS_RIGID.Text = "IS_RIGID";
            this.lbl_IS_RIGID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.numericUpDown17);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox9.Location = new System.Drawing.Point(9, 25);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(194, 42);
            this.groupBox9.TabIndex = 37;
            this.groupBox9.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.button4.Image = global::TFMV.Properties.Resources.btn_reset;
            this.button4.Location = new System.Drawing.Point(5, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(19, 19);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "length:";
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown17.DecimalPlaces = 5;
            this.numericUpDown17.Location = new System.Drawing.Point(125, 14);
            this.numericUpDown17.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown17.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown17.TabIndex = 11;
            this.numericUpDown17.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.groupBox12);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(9, 171);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(194, 146);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.numericUpDown18);
            this.groupBox11.Controls.Add(this.checkBox4);
            this.groupBox11.Controls.Add(this.numericUpDown19);
            this.groupBox11.Controls.Add(this.checkBox5);
            this.groupBox11.Location = new System.Drawing.Point(8, 69);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(179, 69);
            this.groupBox11.TabIndex = 38;
            this.groupBox11.TabStop = false;
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.BackColor = System.Drawing.Color.White;
            this.numericUpDown18.DecimalPlaces = 5;
            this.numericUpDown18.Enabled = false;
            this.numericUpDown18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown18.Location = new System.Drawing.Point(111, 40);
            this.numericUpDown18.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown18.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown18.TabIndex = 23;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(8, 42);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(90, 17);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.Text = "yaw_bounce:";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.BackColor = System.Drawing.Color.White;
            this.numericUpDown19.DecimalPlaces = 5;
            this.numericUpDown19.Enabled = false;
            this.numericUpDown19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown19.Location = new System.Drawing.Point(111, 14);
            this.numericUpDown19.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown19.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown19.TabIndex = 21;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(8, 16);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(85, 17);
            this.checkBox5.TabIndex = 20;
            this.checkBox5.Text = "yaw_friction:";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label19);
            this.groupBox12.Controls.Add(this.label20);
            this.groupBox12.Controls.Add(this.numericUpDown20);
            this.groupBox12.Controls.Add(this.numericUpDown21);
            this.groupBox12.Controls.Add(this.checkBox6);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(8, 18);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(179, 52);
            this.groupBox12.TabIndex = 37;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "     yaw_constraint";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Min:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(93, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Max:";
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.BackColor = System.Drawing.Color.White;
            this.numericUpDown20.DecimalPlaces = 5;
            this.numericUpDown20.Location = new System.Drawing.Point(123, 23);
            this.numericUpDown20.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown20.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown20.TabIndex = 27;
            // 
            // numericUpDown21
            // 
            this.numericUpDown21.BackColor = System.Drawing.Color.White;
            this.numericUpDown21.DecimalPlaces = 5;
            this.numericUpDown21.Location = new System.Drawing.Point(43, 23);
            this.numericUpDown21.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown21.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown21.Name = "numericUpDown21";
            this.numericUpDown21.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown21.TabIndex = 25;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(4, 1);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox14.Controls.Add(this.numericUpDown26);
            this.groupBox14.Controls.Add(this.checkBox7);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox14.Location = new System.Drawing.Point(9, 110);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(194, 42);
            this.groupBox14.TabIndex = 20;
            this.groupBox14.TabStop = false;
            // 
            // numericUpDown26
            // 
            this.numericUpDown26.DecimalPlaces = 5;
            this.numericUpDown26.Location = new System.Drawing.Point(125, 14);
            this.numericUpDown26.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown26.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown26.Name = "numericUpDown26";
            this.numericUpDown26.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown26.TabIndex = 19;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(8, 16);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(107, 17);
            this.checkBox7.TabIndex = 18;
            this.checkBox7.Text = "angle_constraint:";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox15.Controls.Add(this.groupBox49);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(9, 336);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(194, 146);
            this.groupBox15.TabIndex = 38;
            this.groupBox15.TabStop = false;
            // 
            // groupBox49
            // 
            this.groupBox49.Controls.Add(this.label54);
            this.groupBox49.Controls.Add(this.label65);
            this.groupBox49.Controls.Add(this.numericUpDown29);
            this.groupBox49.Controls.Add(this.numericUpDown30);
            this.groupBox49.Controls.Add(this.checkBox10);
            this.groupBox49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox49.Location = new System.Drawing.Point(8, 18);
            this.groupBox49.Name = "groupBox49";
            this.groupBox49.Size = new System.Drawing.Size(179, 52);
            this.groupBox49.TabIndex = 37;
            this.groupBox49.TabStop = false;
            this.groupBox49.Text = "     pitch_constraint";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(13, 25);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(27, 13);
            this.label54.TabIndex = 29;
            this.label54.Text = "Min:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(93, 25);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(30, 13);
            this.label65.TabIndex = 28;
            this.label65.Text = "Max:";
            // 
            // numericUpDown29
            // 
            this.numericUpDown29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.numericUpDown29.DecimalPlaces = 5;
            this.numericUpDown29.Location = new System.Drawing.Point(123, 23);
            this.numericUpDown29.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown29.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown29.Name = "numericUpDown29";
            this.numericUpDown29.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown29.TabIndex = 27;
            // 
            // numericUpDown30
            // 
            this.numericUpDown30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.numericUpDown30.DecimalPlaces = 5;
            this.numericUpDown30.Location = new System.Drawing.Point(43, 23);
            this.numericUpDown30.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown30.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericUpDown30.Name = "numericUpDown30";
            this.numericUpDown30.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown30.TabIndex = 25;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(4, 1);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 14);
            this.checkBox10.TabIndex = 18;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // label78
            // 
            this.label78.BackColor = System.Drawing.SystemColors.Control;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label78.Location = new System.Drawing.Point(15, 132);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(185, 23);
            this.label78.TabIndex = 74;
            this.label78.Text = "YAW";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1339, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 81;
            this.label13.Text = "yaw_stiffness:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1339, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 84;
            this.label17.Text = "yaw_damping:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1340, 339);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 13);
            this.label21.TabIndex = 82;
            this.label21.Text = "pitch_stiffness:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1340, 362);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 85;
            this.label22.Text = "pitch_damping:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1339, 403);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 13);
            this.label23.TabIndex = 83;
            this.label23.Text = "along_stiffness:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(1339, 424);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(82, 13);
            this.label52.TabIndex = 86;
            this.label52.Text = "along_damping:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1342, 189);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(107, 17);
            this.checkBox3.TabIndex = 87;
            this.checkBox3.Text = "allow_length_flex";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(1276, 148);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(288, 16);
            this.label76.TabIndex = 88;
            this.label76.Text = "disable these and change label text to \"is_rigid\"";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(1022, 40);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(230, 16);
            this.label77.TabIndex = 88;
            this.label77.Text = "dont use this in beta. too much hassle.";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(1481, 489);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 23);
            this.button9.TabIndex = 70;
            this.button9.Text = "Preview";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btnApplyJigglebones
            // 
            this.btnApplyJigglebones.BackColor = System.Drawing.Color.Gainsboro;
            this.btnApplyJigglebones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyJigglebones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyJigglebones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApplyJigglebones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApplyJigglebones.Location = new System.Drawing.Point(16, 664);
            this.btnApplyJigglebones.Name = "btnApplyJigglebones";
            this.btnApplyJigglebones.Size = new System.Drawing.Size(146, 37);
            this.btnApplyJigglebones.TabIndex = 89;
            this.btnApplyJigglebones.Text = "Apply";
            this.toolTip1.SetToolTip(this.btnApplyJigglebones, "Apply jiggle bone parameter changes to model, for current session.");
            this.btnApplyJigglebones.UseVisualStyleBackColor = false;
            this.btnApplyJigglebones.Click += new System.EventHandler(this.btnApplyJigglebones_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkGray;
            this.panel12.Controls.Add(this.label79);
            this.panel12.Controls.Add(this.label53);
            this.panel12.Controls.Add(this.btn_ResetAll);
            this.panel12.Controls.Add(this.chk_Auto_Apply);
            this.panel12.Controls.Add(this.chk_Always_On_Top);
            this.panel12.Controls.Add(this.btn_Close);
            this.panel12.Location = new System.Drawing.Point(-1, 655);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(777, 127);
            this.panel12.TabIndex = 90;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(14, 99);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(281, 13);
            this.label79.TabIndex = 90;
            this.label79.Text = "Tip: You can use the scroll wheel to change values faster.";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(14, 55);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(654, 26);
            this.label53.TabIndex = 90;
            this.label53.Text = resources.GetString("label53.Text");
            // 
            // btn_ResetAll
            // 
            this.btn_ResetAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ResetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ResetAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ResetAll.Location = new System.Drawing.Point(615, 9);
            this.btn_ResetAll.Name = "btn_ResetAll";
            this.btn_ResetAll.Size = new System.Drawing.Size(146, 37);
            this.btn_ResetAll.TabIndex = 89;
            this.btn_ResetAll.Text = "Reset";
            this.toolTip1.SetToolTip(this.btn_ResetAll, "Reset jiggle bone parameters to their default value, or to what they were when th" +
        "e model was initially loaded.");
            this.btn_ResetAll.UseVisualStyleBackColor = false;
            this.btn_ResetAll.Click += new System.EventHandler(this.btn_ResetAll_Click);
            // 
            // chk_Auto_Apply
            // 
            this.chk_Auto_Apply.AutoSize = true;
            this.chk_Auto_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Auto_Apply.Location = new System.Drawing.Point(536, 93);
            this.chk_Auto_Apply.Name = "chk_Auto_Apply";
            this.chk_Auto_Apply.Size = new System.Drawing.Size(93, 19);
            this.chk_Auto_Apply.TabIndex = 18;
            this.chk_Auto_Apply.Text = "Auto-Apply";
            this.toolTip1.SetToolTip(this.chk_Auto_Apply, "Refresh HLMV whenever a change is made to any jiggle bone parameters.");
            this.chk_Auto_Apply.UseVisualStyleBackColor = true;
            this.chk_Auto_Apply.Visible = false;
            this.chk_Auto_Apply.CheckedChanged += new System.EventHandler(this.chk_Always_On_Top_CheckedChanged);
            // 
            // chk_Always_On_Top
            // 
            this.chk_Always_On_Top.AutoSize = true;
            this.chk_Always_On_Top.Checked = true;
            this.chk_Always_On_Top.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Always_On_Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Always_On_Top.Location = new System.Drawing.Point(648, 93);
            this.chk_Always_On_Top.Name = "chk_Always_On_Top";
            this.chk_Always_On_Top.Size = new System.Drawing.Size(113, 19);
            this.chk_Always_On_Top.TabIndex = 18;
            this.chk_Always_On_Top.Text = "Always on top";
            this.toolTip1.SetToolTip(this.chk_Always_On_Top, "Make sure this window is always on top of HLMV.");
            this.chk_Always_On_Top.UseVisualStyleBackColor = true;
            this.chk_Always_On_Top.CheckedChanged += new System.EventHandler(this.chk_Always_On_Top_CheckedChanged);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Close.Location = new System.Drawing.Point(171, 9);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(146, 37);
            this.btn_Close.TabIndex = 89;
            this.btn_Close.Text = "Close";
            this.toolTip1.SetToolTip(this.btn_Close, "Close this window.");
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(137, 782);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(49, 13);
            this.label38.TabIndex = 90;
            this.label38.Text = "788, 749";
            // 
            // menuResetAllValues
            // 
            this.menuResetAllValues.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuResetAllValues.Name = "menuResetValue";
            this.menuResetAllValues.Size = new System.Drawing.Size(319, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(318, 22);
            this.toolStripMenuItem1.Text = "Reset all bones to default values";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(318, 22);
            this.toolStripMenuItem2.Text = "Revert all bones to original <mdl name> value";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(232, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 551);
            this.label6.TabIndex = 71;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightGray;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(12, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 551);
            this.label12.TabIndex = 71;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(213, 785);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(533, 143);
            this.label39.TabIndex = 90;
            this.label39.Text = resources.GetString("label39.Text");
            // 
            // hlmv_refresh_delay
            // 
            this.hlmv_refresh_delay.Interval = 1000;
            this.hlmv_refresh_delay.Tick += new System.EventHandler(this.hlmv_refresh_delay_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1853, 143);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 73;
            // 
            // AddJiggleBone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(769, 772);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.btnApplyJigglebones);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_reset_generic);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.txt_QC);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.groupBox37);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.groupBox40);
            this.Controls.Add(this.grp_IS_FLEXIBLE);
            this.Controls.Add(this.groupBox43);
            this.Controls.Add(this.groupBox44);
            this.Controls.Add(this.groupBox47);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox35);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.btn_HideQC);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.grp_IS_BOING);
            this.Controls.Add(this.chk_isBoing);
            this.Controls.Add(this.chk_hasBaseSpring);
            this.Controls.Add(this.chk_isFlexible);
            this.Controls.Add(this.chk_isRigid);
            this.Controls.Add(this.lstPropertyGroupsSub);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.lstBoneName);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.lstPropertyGroupsMain);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnApplyJigglebones_OLD);
            this.Controls.Add(this.chkHasBaseSpring);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.grp_HAS_BASE_SPRING);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstJiggleType);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddJiggleBone";
            this.Text = "Edit jiggle bone (BETA)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddJiggleBone_FormClosing);
            this.Load += new System.EventHandler(this.AddJiggleBone_Load);
            this.Shown += new System.EventHandler(this.AddJiggleBone_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYawConstraintMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYawConstraintMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYawDamping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYawStiffness)).EndInit();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYawFriction)).EndInit();
            this.grp_HAS_BASE_SPRING.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseLeftFriction)).EndInit();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseLeftConstraintMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseLeftConstraintMin)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseForwardFriction)).EndInit();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseForwardConstraintMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseForwardConstraintMin)).EndInit();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseBaseMass)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseUpFriction)).EndInit();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseUpConstraintMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseUpConstraintMin)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseDamping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseStiffness)).EndInit();
            this.grp_Along.ResumeLayout(false);
            this.grp_Along.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlongDamping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlongStiffness)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngleConstraint)).EndInit();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).EndInit();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPitchConstraintMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPitchConstraintMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPitchDamping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPitchStiffness)).EndInit();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPitchFriction)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoingDampingRate)).EndInit();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoingImpactAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoingImpactSpeed)).EndInit();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoingAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoingFrequency)).EndInit();
            this.grp_IS_BOING.ResumeLayout(false);
            this.menuQCEditor.ResumeLayout(false);
            this.groupBox35.ResumeLayout(false);
            this.grp_IS_FLEXIBLE.ResumeLayout(false);
            this.groupBox48.ResumeLayout(false);
            this.groupBox48.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipMass)).EndInit();
            this.groupBox37.ResumeLayout(false);
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.groupBox40.ResumeLayout(false);
            this.groupBox41.ResumeLayout(false);
            this.groupBox41.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.groupBox42.ResumeLayout(false);
            this.groupBox42.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            this.groupBox43.ResumeLayout(false);
            this.groupBox43.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            this.groupBox44.ResumeLayout(false);
            this.groupBox45.ResumeLayout(false);
            this.groupBox45.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            this.groupBox46.ResumeLayout(false);
            this.groupBox46.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            this.groupBox47.ResumeLayout(false);
            this.groupBox47.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            this.menuResetValue.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown28)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown26)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox49.ResumeLayout(false);
            this.groupBox49.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown30)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.menuResetAllValues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox lstJiggleType;
        private GroupBox groupBox1;
        private Button btnYawDamping;
        private Button btnYawStiffness;
        private Label lblYawStiffness;
        private Label lblYawDamping;
        private Label label7;
        private GroupBox grp_HAS_BASE_SPRING;
        private GroupBox groupBox25;
        private GroupBox groupBox6;
        private GroupBox groupBox17;
        private GroupBox groupBox18;
        private Label label10;
        private Label label11;
        private GroupBox groupBox19;
        private GroupBox groupBox20;
        private GroupBox groupBox21;
        private Label label24;
        private Label label25;
        private GroupBox groupBox5;
        private Button btn_ResetBaseDamping;
        private Button btn_ResetBaseStiffness;
        private Label label8;
        private Label label9;
        private Label label4;
        private Label label3;
        private GroupBox grp_Along;
        private Button button5;
        private Button button6;
        private GroupBox groupBox7;
        private CheckBox chkAngleConstraint;
        private Label label28;
        private GroupBox groupBox26;
        private Button button11;
        private Button button12;
        private Label label29;
        private Label label30;
        private GroupBox groupBox27;
        private CheckBox chkYawFriction;
        private GroupBox groupBox28;
        private Label label34;
        private Label label35;
        private CheckBox chkYawConstraint;
        private Button button14;
        private Label label32;
        private Button button15;
        private Label label33;
        private GroupBox groupBox29;
        private GroupBox groupBox30;
        private CheckBox chkPitchFriction;
        private GroupBox groupBox31;
        private Label label36;
        private Label label37;
        private CheckBox chkPitchConstraint;
        private Button btnPitchDamping;
        private Button btnPitchStiffness;
        private Label lblPitchStiffness;
        private Label lblPitchDamping;
        private Button btnOkay;
        private Button btnCancel;
        private GroupBox groupBox22;
        private GroupBox groupBox23;
        private Button button13;
        private Label label26;
        private GroupBox groupBox24;
        private Label label27;
        private Label label31;
        private CheckBox chkHasBaseSpring;
        private CheckBox chkAllowLengthFlex;
        private Button btnApplyJigglebones_OLD;
        private Button btn_resetBaseMass;
        private Label label40;
        private GroupBox groupBox4;
        private Button button21;
        private Label label41;
        private GroupBox groupBox32;
        private Button button22;
        private Button button23;
        private Label label42;
        private Label label43;
        private GroupBox groupBox33;
        private Button button24;
        private Button button25;
        private Label label44;
        private Label label45;
        private Label label46;
        private ComboBox comboBox1;
        private CheckedListBox lstPropertyGroupsMain;
        private Label label47;
        private ListBox lstBoneName;
        private Label label48;
        private CheckedListBox lstPropertyGroupsSub;
        private CheckBox chk_isRigid;
        private CheckBox chk_isFlexible;
        private CheckBox chk_isBoing;
        private CheckBox chk_hasBaseSpring;
        private GroupBox grp_IS_BOING;
        private TextBox txt_QC;
        private Label label49;
        private Button btn_HideQC;
        private Label label50;
        private Label label51;
        private ComboBox comboBox2;
        private GroupBox groupBox35;
        private Button button30;
        private Button button29;
        private Button btn_QC_select_current;
        private Label lbl_HAS_BASE_SPRING;
        private Label label57;
        private Label label56;
        private Label label55;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown1;
        private Label label58;
        private GroupBox grp_IS_FLEXIBLE;
        private Label label59;
        private Label label60;
        private Label label61;
        private GroupBox groupBox37;
        private GroupBox groupBox38;
        private Button button31;
        private Label label62;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown2;
        private GroupBox groupBox39;
        private Button button32;
        private Label label63;
        private Label label64;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown3;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown4;
        private Label lbl_IS_FLEXIBLE;
        private GroupBox groupBox40;
        private GroupBox groupBox41;
        private Button button33;
        private Label label66;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown5;
        private GroupBox groupBox42;
        private Button button34;
        private Label label67;
        private Label label68;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown6;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown7;
        private GroupBox groupBox43;
        private Button button35;
        private Label label69;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown8;
        private GroupBox groupBox44;
        private GroupBox groupBox45;
        private Button button36;
        private Label label70;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown9;
        private GroupBox groupBox46;
        private Button button37;
        private Label label71;
        private Label label72;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown10;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown11;
        private GroupBox groupBox47;
        private Button button38;
        private Button button39;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown12;
        private Label label73;
        private Label label74;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown13;
        private Label label75;
        private ContextMenuStrip menuResetValue;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtYawDamping;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtYawStiffness;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseBaseMass;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseUpFriction;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseUpConstraintMax;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseUpConstraintMin;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseLeftFriction;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseLeftConstraintMax;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseLeftConstraintMin;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseDamping;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseStiffness;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtAlongStiffness;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtAlongDamping;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtAngleConstraint;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtTipMass;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtLength;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtYawFriction;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtYawConstraintMax;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtYawConstraintMin;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtPitchFriction;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtPitchConstraintMax;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtPitchConstraintMin;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtPitchDamping;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtPitchStiffness;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseForwardFriction;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseForwardConstraintMax;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBaseForwardConstraintMin;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBoingDampingRate;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBoingImpactAngle;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBoingImpactSpeed;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBoingAmplitude;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat txtBoingFrequency;
        private ToolStripMenuItem resetToDefaultToolStripMenuItem;
        private ToolStripMenuItem revertToOriginalboneNameValueToolStripMenuItem;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown14;
        private CheckBox checkBox1;
        private Label lbl_IS_BOING;
        private Button btn_reset_generic;
        private Button button17;
        private Button button16;
        private Button button26;
        private Label label1;
        private GroupBox groupBox48;
        private Label label2;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown15;
        private CheckBox checkBox2;
        private GroupBox groupBox2;
        private Label label14;
        private Label label15;
        private GroupBox groupBox8;
        private Label label16;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown16;
        private Button button3;
        private Label lbl_IS_RIGID;
        private GroupBox groupBox9;
        private Button button4;
        private Label label18;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown17;
        private GroupBox groupBox10;
        private GroupBox groupBox11;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown18;
        private CheckBox checkBox4;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown19;
        private CheckBox checkBox5;
        private GroupBox groupBox12;
        private Label label19;
        private Label label20;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown20;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown21;
        private CheckBox checkBox6;
        private GroupBox groupBox14;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown26;
        private CheckBox checkBox7;
        private GroupBox groupBox15;
        private GroupBox groupBox16;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown27;
        private CheckBox checkBox8;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown28;
        private CheckBox checkBox9;
        private GroupBox groupBox49;
        private Label label54;
        private Label label65;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown29;
        private DeviceCtrlLibrary.NumericUpDown_CustomFormat numericUpDown30;
        private CheckBox checkBox10;
        private Label label78;
        private Label label13;
        private Label label17;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label52;
        private CheckBox checkBox3;
        private Label label76;
        private Label label77;
        private Button btn_QC_copy;
        private Button btn_QC_select_all;
        private Button button9;
        private Button btnApplyJigglebones;
        private Panel panel12;
        private Button btn_ResetAll;
        private CheckBox chk_Always_On_Top;
        private CheckBox chk_Auto_Apply;
        private Button btn_Close;
        private ContextMenuStrip menuResetAllValues;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label label5;
        private Label label6;
        private Label label12;
        private Label label38;
        private Label lbl_Along;
        private Label label39;
        private Label label53;
        private ToolTip toolTip1;
        private ContextMenuStrip menuQCEditor;
        private ToolStripMenuItem menubtn_QC_Cut;
        private ToolStripMenuItem menubtn_QC_Copy;
        private ToolStripMenuItem menubtn_QC_Paste;
        private ToolStripMenuItem menubtn_QC_Delete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menubtn_QC_Select_Current;
        private ToolStripMenuItem menubtn_QC_Select_All;
        private Label label79;
        private Timer hlmv_refresh_delay;
    }
}