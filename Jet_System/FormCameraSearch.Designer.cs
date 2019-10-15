namespace Jet_System
{
    partial class FormCameraSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCameraSearch));
            this.DisplayBefore = new Cognex.VisionPro.Display.CogDisplay();
            this.btnTriggerOnce = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxCameras = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnStopLive = new System.Windows.Forms.Button();
            this.btnLive = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtExposure = new System.Windows.Forms.TextBox();
            this.btnSetExposure = new System.Windows.Forms.Button();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.btnSetDO_T = new System.Windows.Forms.Button();
            this.btnSetDO = new System.Windows.Forms.Button();
            this.btnSetRaf = new System.Windows.Forms.Button();
            this.txt_DO_T_Gain = new System.Windows.Forms.TextBox();
            this.txt_DO_T_Exposure = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DO_Gain = new System.Windows.Forms.TextBox();
            this.txt_DO_Exposure = new System.Windows.Forms.TextBox();
            this.txtRAF_Gain = new System.Windows.Forms.TextBox();
            this.txtRAF_Exposure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetGain = new System.Windows.Forms.Button();
            this.txtGain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbxStartConnect = new System.Windows.Forms.CheckBox();
            this.cbxIO0 = new System.Windows.Forms.CheckBox();
            this.cbxIO1 = new System.Windows.Forms.CheckBox();
            this.cbxIO2 = new System.Windows.Forms.CheckBox();
            this.cbxIO3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBefore)).BeginInit();
            this.tblMain.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayBefore
            // 
            this.DisplayBefore.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.DisplayBefore.ColorMapLowerRoiLimit = 0D;
            this.DisplayBefore.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.DisplayBefore.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.DisplayBefore.ColorMapUpperRoiLimit = 1D;
            this.DisplayBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayBefore.Location = new System.Drawing.Point(3, 3);
            this.DisplayBefore.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.DisplayBefore.MouseWheelSensitivity = 1D;
            this.DisplayBefore.Name = "DisplayBefore";
            this.DisplayBefore.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("DisplayBefore.OcxState")));
            this.DisplayBefore.Size = new System.Drawing.Size(1058, 734);
            this.DisplayBefore.TabIndex = 7;
            // 
            // btnTriggerOnce
            // 
            this.btnTriggerOnce.Enabled = false;
            this.btnTriggerOnce.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTriggerOnce.Location = new System.Drawing.Point(7, 127);
            this.btnTriggerOnce.Name = "btnTriggerOnce";
            this.btnTriggerOnce.Size = new System.Drawing.Size(120, 40);
            this.btnTriggerOnce.TabIndex = 8;
            this.btnTriggerOnce.Text = "单次拍照";
            this.btnTriggerOnce.UseVisualStyleBackColor = true;
            this.btnTriggerOnce.Click += new System.EventHandler(this.btnTriggerOnce_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(6, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 40);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "相机搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxCameras
            // 
            this.cbxCameras.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxCameras.FormattingEnabled = true;
            this.cbxCameras.Location = new System.Drawing.Point(156, 20);
            this.cbxCameras.Name = "cbxCameras";
            this.cbxCameras.Size = new System.Drawing.Size(152, 27);
            this.cbxCameras.TabIndex = 10;
            this.cbxCameras.SelectedIndexChanged += new System.EventHandler(this.cbxCameras_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.Location = new System.Drawing.Point(188, 63);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 40);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "连接相机";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnStopLive
            // 
            this.btnStopLive.Enabled = false;
            this.btnStopLive.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopLive.Location = new System.Drawing.Point(188, 187);
            this.btnStopLive.Name = "btnStopLive";
            this.btnStopLive.Size = new System.Drawing.Size(120, 40);
            this.btnStopLive.TabIndex = 12;
            this.btnStopLive.Text = "停止";
            this.btnStopLive.UseVisualStyleBackColor = true;
            this.btnStopLive.Click += new System.EventHandler(this.btnStopLive_Click);
            // 
            // btnLive
            // 
            this.btnLive.Enabled = false;
            this.btnLive.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLive.Location = new System.Drawing.Point(188, 127);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(120, 40);
            this.btnLive.TabIndex = 13;
            this.btnLive.Text = "实时";
            this.btnLive.UseVisualStyleBackColor = true;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Enabled = false;
            this.btnComplete.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnComplete.Location = new System.Drawing.Point(10, 674);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(120, 40);
            this.btnComplete.TabIndex = 14;
            this.btnComplete.Text = "完成";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtExposure
            // 
            this.txtExposure.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtExposure.Location = new System.Drawing.Point(92, 254);
            this.txtExposure.Name = "txtExposure";
            this.txtExposure.Size = new System.Drawing.Size(100, 29);
            this.txtExposure.TabIndex = 15;
            // 
            // btnSetExposure
            // 
            this.btnSetExposure.Enabled = false;
            this.btnSetExposure.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetExposure.Location = new System.Drawing.Point(199, 246);
            this.btnSetExposure.Name = "btnSetExposure";
            this.btnSetExposure.Size = new System.Drawing.Size(100, 40);
            this.btnSetExposure.TabIndex = 16;
            this.btnSetExposure.Text = "设置曝光";
            this.btnSetExposure.UseVisualStyleBackColor = true;
            this.btnSetExposure.Visible = false;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.05685F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.94314F));
            this.tblMain.Controls.Add(this.DisplayBefore, 0, 0);
            this.tblMain.Controls.Add(this.groupBoxParameters, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.91576F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.084243F));
            this.tblMain.Size = new System.Drawing.Size(1382, 788);
            this.tblMain.TabIndex = 17;
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.cbxIO3);
            this.groupBoxParameters.Controls.Add(this.cbxIO2);
            this.groupBoxParameters.Controls.Add(this.cbxIO1);
            this.groupBoxParameters.Controls.Add(this.cbxIO0);
            this.groupBoxParameters.Controls.Add(this.btnSetDO_T);
            this.groupBoxParameters.Controls.Add(this.btnSetDO);
            this.groupBoxParameters.Controls.Add(this.btnSetRaf);
            this.groupBoxParameters.Controls.Add(this.txt_DO_T_Gain);
            this.groupBoxParameters.Controls.Add(this.txt_DO_T_Exposure);
            this.groupBoxParameters.Controls.Add(this.label7);
            this.groupBoxParameters.Controls.Add(this.txt_DO_Gain);
            this.groupBoxParameters.Controls.Add(this.txt_DO_Exposure);
            this.groupBoxParameters.Controls.Add(this.txtRAF_Gain);
            this.groupBoxParameters.Controls.Add(this.txtRAF_Exposure);
            this.groupBoxParameters.Controls.Add(this.label6);
            this.groupBoxParameters.Controls.Add(this.label5);
            this.groupBoxParameters.Controls.Add(this.label4);
            this.groupBoxParameters.Controls.Add(this.label3);
            this.groupBoxParameters.Controls.Add(this.label2);
            this.groupBoxParameters.Controls.Add(this.btnSetGain);
            this.groupBoxParameters.Controls.Add(this.txtGain);
            this.groupBoxParameters.Controls.Add(this.label1);
            this.groupBoxParameters.Controls.Add(this.chbxStartConnect);
            this.groupBoxParameters.Controls.Add(this.btnSetExposure);
            this.groupBoxParameters.Controls.Add(this.btnSearch);
            this.groupBoxParameters.Controls.Add(this.cbxCameras);
            this.groupBoxParameters.Controls.Add(this.btnTriggerOnce);
            this.groupBoxParameters.Controls.Add(this.txtExposure);
            this.groupBoxParameters.Controls.Add(this.btnOpen);
            this.groupBoxParameters.Controls.Add(this.btnComplete);
            this.groupBoxParameters.Controls.Add(this.btnLive);
            this.groupBoxParameters.Controls.Add(this.btnStopLive);
            this.groupBoxParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxParameters.Location = new System.Drawing.Point(1067, 3);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(312, 734);
            this.groupBoxParameters.TabIndex = 8;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "参数";
            // 
            // btnSetDO_T
            // 
            this.btnSetDO_T.Enabled = false;
            this.btnSetDO_T.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetDO_T.Location = new System.Drawing.Point(243, 485);
            this.btnSetDO_T.Name = "btnSetDO_T";
            this.btnSetDO_T.Size = new System.Drawing.Size(58, 40);
            this.btnSetDO_T.TabIndex = 37;
            this.btnSetDO_T.Text = "设置";
            this.btnSetDO_T.UseVisualStyleBackColor = true;
            this.btnSetDO_T.Click += new System.EventHandler(this.btnSetDO_T_Click);
            // 
            // btnSetDO
            // 
            this.btnSetDO.Enabled = false;
            this.btnSetDO.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetDO.Location = new System.Drawing.Point(241, 429);
            this.btnSetDO.Name = "btnSetDO";
            this.btnSetDO.Size = new System.Drawing.Size(58, 40);
            this.btnSetDO.TabIndex = 36;
            this.btnSetDO.Text = "设置";
            this.btnSetDO.UseVisualStyleBackColor = true;
            this.btnSetDO.Click += new System.EventHandler(this.btnSetDO_Click);
            // 
            // btnSetRaf
            // 
            this.btnSetRaf.Enabled = false;
            this.btnSetRaf.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetRaf.Location = new System.Drawing.Point(241, 375);
            this.btnSetRaf.Name = "btnSetRaf";
            this.btnSetRaf.Size = new System.Drawing.Size(58, 40);
            this.btnSetRaf.TabIndex = 35;
            this.btnSetRaf.Text = "设置";
            this.btnSetRaf.UseVisualStyleBackColor = true;
            this.btnSetRaf.Click += new System.EventHandler(this.btnSetRaf_Click);
            // 
            // txt_DO_T_Gain
            // 
            this.txt_DO_T_Gain.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_DO_T_Gain.Location = new System.Drawing.Point(154, 493);
            this.txt_DO_T_Gain.Name = "txt_DO_T_Gain";
            this.txt_DO_T_Gain.ReadOnly = true;
            this.txt_DO_T_Gain.Size = new System.Drawing.Size(60, 29);
            this.txt_DO_T_Gain.TabIndex = 34;
            // 
            // txt_DO_T_Exposure
            // 
            this.txt_DO_T_Exposure.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_DO_T_Exposure.Location = new System.Drawing.Point(66, 493);
            this.txt_DO_T_Exposure.Name = "txt_DO_T_Exposure";
            this.txt_DO_T_Exposure.ReadOnly = true;
            this.txt_DO_T_Exposure.Size = new System.Drawing.Size(60, 29);
            this.txt_DO_T_Exposure.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label7.Location = new System.Drawing.Point(6, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "DO_T：";
            // 
            // txt_DO_Gain
            // 
            this.txt_DO_Gain.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_DO_Gain.Location = new System.Drawing.Point(154, 437);
            this.txt_DO_Gain.Name = "txt_DO_Gain";
            this.txt_DO_Gain.ReadOnly = true;
            this.txt_DO_Gain.Size = new System.Drawing.Size(60, 29);
            this.txt_DO_Gain.TabIndex = 31;
            // 
            // txt_DO_Exposure
            // 
            this.txt_DO_Exposure.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_DO_Exposure.Location = new System.Drawing.Point(66, 437);
            this.txt_DO_Exposure.Name = "txt_DO_Exposure";
            this.txt_DO_Exposure.ReadOnly = true;
            this.txt_DO_Exposure.Size = new System.Drawing.Size(60, 29);
            this.txt_DO_Exposure.TabIndex = 30;
            // 
            // txtRAF_Gain
            // 
            this.txtRAF_Gain.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRAF_Gain.Location = new System.Drawing.Point(154, 383);
            this.txtRAF_Gain.Name = "txtRAF_Gain";
            this.txtRAF_Gain.ReadOnly = true;
            this.txtRAF_Gain.Size = new System.Drawing.Size(60, 29);
            this.txtRAF_Gain.TabIndex = 29;
            // 
            // txtRAF_Exposure
            // 
            this.txtRAF_Exposure.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRAF_Exposure.Location = new System.Drawing.Point(67, 382);
            this.txtRAF_Exposure.Name = "txtRAF_Exposure";
            this.txtRAF_Exposure.ReadOnly = true;
            this.txtRAF_Exposure.Size = new System.Drawing.Size(60, 29);
            this.txtRAF_Exposure.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label6.Location = new System.Drawing.Point(150, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "增益：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label5.Location = new System.Drawing.Point(78, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "曝光：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label4.Location = new System.Drawing.Point(6, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "DO：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label3.Location = new System.Drawing.Point(3, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "RAF：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label2.Location = new System.Drawing.Point(6, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "增益：";
            // 
            // btnSetGain
            // 
            this.btnSetGain.Enabled = false;
            this.btnSetGain.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetGain.Location = new System.Drawing.Point(202, 287);
            this.btnSetGain.Name = "btnSetGain";
            this.btnSetGain.Size = new System.Drawing.Size(97, 40);
            this.btnSetGain.TabIndex = 22;
            this.btnSetGain.Text = "设置";
            this.btnSetGain.UseVisualStyleBackColor = true;
            this.btnSetGain.Click += new System.EventHandler(this.btnSetGain_Click);
            // 
            // txtGain
            // 
            this.txtGain.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGain.Location = new System.Drawing.Point(92, 295);
            this.txtGain.Name = "txtGain";
            this.txtGain.Size = new System.Drawing.Size(100, 29);
            this.txtGain.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label1.Location = new System.Drawing.Point(6, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "曝光：";
            // 
            // chbxStartConnect
            // 
            this.chbxStartConnect.AutoSize = true;
            this.chbxStartConnect.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chbxStartConnect.Location = new System.Drawing.Point(188, 684);
            this.chbxStartConnect.Name = "chbxStartConnect";
            this.chbxStartConnect.Size = new System.Drawing.Size(104, 23);
            this.chbxStartConnect.TabIndex = 19;
            this.chbxStartConnect.Text = "开机连接";
            this.chbxStartConnect.UseVisualStyleBackColor = true;
            this.chbxStartConnect.Visible = false;
            // 
            // cbxIO0
            // 
            this.cbxIO0.AutoSize = true;
            this.cbxIO0.Location = new System.Drawing.Point(37, 567);
            this.cbxIO0.Name = "cbxIO0";
            this.cbxIO0.Size = new System.Drawing.Size(42, 16);
            this.cbxIO0.TabIndex = 38;
            this.cbxIO0.Text = "0口";
            this.cbxIO0.UseVisualStyleBackColor = true;
            this.cbxIO0.CheckedChanged += new System.EventHandler(this.cbxIO1_CheckedChanged);
            // 
            // cbxIO1
            // 
            this.cbxIO1.AutoSize = true;
            this.cbxIO1.Location = new System.Drawing.Point(156, 567);
            this.cbxIO1.Name = "cbxIO1";
            this.cbxIO1.Size = new System.Drawing.Size(42, 16);
            this.cbxIO1.TabIndex = 39;
            this.cbxIO1.Text = "1口";
            this.cbxIO1.UseVisualStyleBackColor = true;
            this.cbxIO1.CheckedChanged += new System.EventHandler(this.cbxIO1_CheckedChanged);
            // 
            // cbxIO2
            // 
            this.cbxIO2.AutoSize = true;
            this.cbxIO2.Location = new System.Drawing.Point(37, 612);
            this.cbxIO2.Name = "cbxIO2";
            this.cbxIO2.Size = new System.Drawing.Size(42, 16);
            this.cbxIO2.TabIndex = 40;
            this.cbxIO2.Text = "2口";
            this.cbxIO2.UseVisualStyleBackColor = true;
            this.cbxIO2.CheckedChanged += new System.EventHandler(this.cbxIO1_CheckedChanged);
            // 
            // cbxIO3
            // 
            this.cbxIO3.AutoSize = true;
            this.cbxIO3.Location = new System.Drawing.Point(156, 612);
            this.cbxIO3.Name = "cbxIO3";
            this.cbxIO3.Size = new System.Drawing.Size(42, 16);
            this.cbxIO3.TabIndex = 41;
            this.cbxIO3.Text = "3口";
            this.cbxIO3.UseVisualStyleBackColor = true;
            this.cbxIO3.CheckedChanged += new System.EventHandler(this.cbxIO1_CheckedChanged);
            // 
            // FormCameraSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 788);
            this.Controls.Add(this.tblMain);
            this.Name = "FormCameraSearch";
            this.Text = "相机搜索";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formest_FormClosing);
            this.Load += new System.EventHandler(this.FormCameraSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBefore)).EndInit();
            this.tblMain.ResumeLayout(false);
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Cognex.VisionPro.Display.CogDisplay DisplayBefore;
        private System.Windows.Forms.Button btnTriggerOnce;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxCameras;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnStopLive;
        private System.Windows.Forms.Button btnLive;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtExposure;
        private System.Windows.Forms.Button btnSetExposure;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.CheckBox chbxStartConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetGain;
        private System.Windows.Forms.TextBox txtGain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetDO_T;
        private System.Windows.Forms.Button btnSetDO;
        private System.Windows.Forms.Button btnSetRaf;
        private System.Windows.Forms.TextBox txt_DO_T_Gain;
        private System.Windows.Forms.TextBox txt_DO_T_Exposure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DO_Gain;
        private System.Windows.Forms.TextBox txt_DO_Exposure;
        private System.Windows.Forms.TextBox txtRAF_Gain;
        private System.Windows.Forms.TextBox txtRAF_Exposure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxIO3;
        private System.Windows.Forms.CheckBox cbxIO2;
        private System.Windows.Forms.CheckBox cbxIO1;
        private System.Windows.Forms.CheckBox cbxIO0;
    }
}