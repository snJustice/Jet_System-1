using Cognex.VisionPro;

namespace Jet_System
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            RowImageSave.Dispose();
            ResultImageSave.Dispose();
            cancel.Dispose();
            ImageProcess_Task.Dispose();

            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mDisplay2Row = new Cognex.VisionPro.Display.CogDisplay();
            this.btnRunOnce = new System.Windows.Forms.Button();
            this.btnCurrentImageRun = new System.Windows.Forms.Button();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblParametersAndResultShow = new System.Windows.Forms.TableLayoutPanel();
            this.group_main = new System.Windows.Forms.GroupBox();
            this.tblMain2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tab_Beam_Touch_Window_L_L = new System.Windows.Forms.TabPage();
            this.tbll_bll = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Beam_Touch_Window_L_L = new System.Windows.Forms.DataGridView();
            this.tab_Beam_Touch_Window_L_R = new System.Windows.Forms.TabPage();
            this.tbll_lr = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Beam_Touch_Window_L_R = new System.Windows.Forms.DataGridView();
            this.tab_Beam_Tip_To_Window_L = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Beam_Tip_To_Window_L = new System.Windows.Forms.DataGridView();
            this.tab_Beam_Touch_Window_R_L = new System.Windows.Forms.TabPage();
            this.tbll_l = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Beam_Touch_Window_R_L = new System.Windows.Forms.DataGridView();
            this.tab_Beam_Touch_Window_R_R = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Beam_Touch_Window_R_R = new System.Windows.Forms.DataGridView();
            this.tab_Beam_Tip_To_Window_R = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Beam_Tip_To_Window_R = new System.Windows.Forms.DataGridView();
            this.tab_Beam_Height_Difference = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Beam_Height_Difference = new System.Windows.Forms.DataGridView();
            this.tab_Shield_Flatness = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Shield_Flatness = new System.Windows.Forms.DataGridView();
            this.tab_Cross_Shield_TP = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Cross_Shield_TP = new System.Windows.Forms.DataGridView();
            this.tab_Wafer_Thickness = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Wafer_Thickness = new System.Windows.Forms.DataGridView();
            this.tab_Shield_Cross_Angle = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Shield_Cross_Angle = new System.Windows.Forms.DataGridView();
            this.tab_Beam_Height_L = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Beam_Height_L = new System.Windows.Forms.DataGridView();
            this.tab_Beam_Height_R = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_Beam_Height_R = new System.Windows.Forms.DataGridView();
            this.tab_Beam_Inner_L = new System.Windows.Forms.TabPage();
            this.dataGrid_Beam_Inner_L = new System.Windows.Forms.DataGridView();
            this.tab_Beam_Inner_R = new System.Windows.Forms.TabPage();
            this.dataGrid_Beam_Inner_R = new System.Windows.Forms.DataGridView();
            this.tab_TiePian = new System.Windows.Forms.TabPage();
            this.dataGrid_TiePian = new System.Windows.Forms.DataGridView();
            this.palSelectMeasure = new System.Windows.Forms.Panel();
            this.ra_TiePian = new System.Windows.Forms.RadioButton();
            this.ra_Beam_Inner_L = new System.Windows.Forms.RadioButton();
            this.ra_Beam_Inner_R = new System.Windows.Forms.RadioButton();
            this.ra_Beam_Height_L = new System.Windows.Forms.RadioButton();
            this.ra_Beam_Height_R = new System.Windows.Forms.RadioButton();
            this.ra_Shield_Cross_Angle = new System.Windows.Forms.RadioButton();
            this.ra_Wafer_Thickness = new System.Windows.Forms.RadioButton();
            this.ra_Cross_Shield_TP = new System.Windows.Forms.RadioButton();
            this.ra_Shield_Flatness = new System.Windows.Forms.RadioButton();
            this.ra_Beam_Height_Difference = new System.Windows.Forms.RadioButton();
            this.ra_Beam_Tip_To_Window_R = new System.Windows.Forms.RadioButton();
            this.ra_Beam_Touch_Window_R_R = new System.Windows.Forms.RadioButton();
            this.ra_Beam_Touch_Window_R_L = new System.Windows.Forms.RadioButton();
            this.ra_Beam_Tip_To_Window_L = new System.Windows.Forms.RadioButton();
            this.ra_Beam_Touch_Window_L_R = new System.Windows.Forms.RadioButton();
            this.ra_Beam_Touch_Window_L_L = new System.Windows.Forms.RadioButton();
            this.groupBoxTongji = new System.Windows.Forms.GroupBox();
            this.BtnWave = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbl_DO_OKNG = new System.Windows.Forms.Label();
            this.lbl_RAF_OKNG = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDO_Clear = new System.Windows.Forms.Button();
            this.lblFailNum_DO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPassNum_DO = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalNum_DO = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProgramSelect = new System.Windows.Forms.ComboBox();
            this.chbxSaveImage = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFailNum_RAF = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPassNum_RAF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalNum_RAF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblImageAndControl = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxHistoryData = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblStatusShow = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.groupBox_Image = new System.Windows.Forms.GroupBox();
            this.tabControlImage = new System.Windows.Forms.TabControl();
            this.tapaResultImage1 = new System.Windows.Forms.TabPage();
            this.mDisplay1Result = new Cognex.VisionPro.CogRecordDisplay();
            this.tapaResultImage2 = new System.Windows.Forms.TabPage();
            this.mDisplay2Result = new Cognex.VisionPro.CogRecordDisplay();
            this.tapaRowImage1 = new System.Windows.Forms.TabPage();
            this.mDisplay1Row = new Cognex.VisionPro.Display.CogDisplay();
            this.tapaRowImage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.相机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.程序参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_child_static_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_child_Camera_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_Display_max = new System.Windows.Forms.GroupBox();
            this.tbll_Max_TwoDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.mDisplay2ResultShow = new Cognex.VisionPro.CogRecordDisplay();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.mDisplay2RowShow = new Cognex.VisionPro.Display.CogDisplay();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mDisplay1ResultShow = new Cognex.VisionPro.CogRecordDisplay();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mDisplay1RowShow = new Cognex.VisionPro.Display.CogDisplay();
            this.tabControl_Main_all = new System.Windows.Forms.TabControl();
            this.tab_Measure = new System.Windows.Forms.TabPage();
            this.tab_Display = new System.Windows.Forms.TabPage();
            this.tbll_Display_max = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_message = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.Label_max = new System.Windows.Forms.Label();
            this.tab_RAF = new System.Windows.Forms.TabPage();
            this.cogtool_RAF = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
            this.tab_DO = new System.Windows.Forms.TabPage();
            this.cogtool_DO = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
            this.light_History = new Net.FlyingWind.Tools.LightIndicator();
            this.userControlSetMaxAndMin1 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin2 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin3 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin4 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin5 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin6 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin7 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin8 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin9 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin10 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin11 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin12 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.userControlSetMaxAndMin13 = new Jet_System.CustomerUserControl.UserControlSetMaxAndMin();
            this.customerLights1 = new Jet_System.CustomerUserControl.CustomerLights();
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay2Row)).BeginInit();
            this.tblMain.SuspendLayout();
            this.tblParametersAndResultShow.SuspendLayout();
            this.group_main.SuspendLayout();
            this.tblMain2.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tab_Beam_Touch_Window_L_L.SuspendLayout();
            this.tbll_bll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Touch_Window_L_L)).BeginInit();
            this.tab_Beam_Touch_Window_L_R.SuspendLayout();
            this.tbll_lr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Touch_Window_L_R)).BeginInit();
            this.tab_Beam_Tip_To_Window_L.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Tip_To_Window_L)).BeginInit();
            this.tab_Beam_Touch_Window_R_L.SuspendLayout();
            this.tbll_l.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Touch_Window_R_L)).BeginInit();
            this.tab_Beam_Touch_Window_R_R.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Touch_Window_R_R)).BeginInit();
            this.tab_Beam_Tip_To_Window_R.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Tip_To_Window_R)).BeginInit();
            this.tab_Beam_Height_Difference.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Height_Difference)).BeginInit();
            this.tab_Shield_Flatness.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Shield_Flatness)).BeginInit();
            this.tab_Cross_Shield_TP.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Cross_Shield_TP)).BeginInit();
            this.tab_Wafer_Thickness.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Wafer_Thickness)).BeginInit();
            this.tab_Shield_Cross_Angle.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Shield_Cross_Angle)).BeginInit();
            this.tab_Beam_Height_L.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Height_L)).BeginInit();
            this.tab_Beam_Height_R.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Height_R)).BeginInit();
            this.tab_Beam_Inner_L.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Inner_L)).BeginInit();
            this.tab_Beam_Inner_R.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Inner_R)).BeginInit();
            this.tab_TiePian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_TiePian)).BeginInit();
            this.palSelectMeasure.SuspendLayout();
            this.groupBoxTongji.SuspendLayout();
            this.tblImageAndControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Image.SuspendLayout();
            this.tabControlImage.SuspendLayout();
            this.tapaResultImage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay1Result)).BeginInit();
            this.tapaResultImage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay2Result)).BeginInit();
            this.tapaRowImage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay1Row)).BeginInit();
            this.tapaRowImage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox_Display_max.SuspendLayout();
            this.tbll_Max_TwoDisplay.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay2ResultShow)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay2RowShow)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay1ResultShow)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay1RowShow)).BeginInit();
            this.tabControl_Main_all.SuspendLayout();
            this.tab_Measure.SuspendLayout();
            this.tab_Display.SuspendLayout();
            this.tbll_Display_max.SuspendLayout();
            this.groupBox_message.SuspendLayout();
            this.tab_RAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogtool_RAF)).BeginInit();
            this.tab_DO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogtool_DO)).BeginInit();
            this.SuspendLayout();
            // 
            // mDisplay2Row
            // 
            this.mDisplay2Row.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.mDisplay2Row.ColorMapLowerRoiLimit = 0D;
            this.mDisplay2Row.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.mDisplay2Row.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.mDisplay2Row.ColorMapUpperRoiLimit = 1D;
            this.mDisplay2Row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDisplay2Row.Location = new System.Drawing.Point(0, 0);
            this.mDisplay2Row.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.mDisplay2Row.MouseWheelSensitivity = 1D;
            this.mDisplay2Row.Name = "mDisplay2Row";
            this.mDisplay2Row.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mDisplay2Row.OcxState")));
            this.mDisplay2Row.Size = new System.Drawing.Size(335, 327);
            this.mDisplay2Row.TabIndex = 5;
            // 
            // btnRunOnce
            // 
            this.btnRunOnce.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRunOnce.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRunOnce.Location = new System.Drawing.Point(43, 20);
            this.btnRunOnce.Name = "btnRunOnce";
            this.btnRunOnce.Size = new System.Drawing.Size(143, 44);
            this.btnRunOnce.TabIndex = 6;
            this.btnRunOnce.Text = "触发";
            this.btnRunOnce.UseVisualStyleBackColor = false;
            this.btnRunOnce.Click += new System.EventHandler(this.btnRunOnce_Click);
            // 
            // btnCurrentImageRun
            // 
            this.btnCurrentImageRun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCurrentImageRun.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCurrentImageRun.Location = new System.Drawing.Point(43, 123);
            this.btnCurrentImageRun.Name = "btnCurrentImageRun";
            this.btnCurrentImageRun.Size = new System.Drawing.Size(143, 48);
            this.btnCurrentImageRun.TabIndex = 7;
            this.btnCurrentImageRun.Text = "运行";
            this.btnCurrentImageRun.UseVisualStyleBackColor = false;
            this.btnCurrentImageRun.Click += new System.EventHandler(this.btnCurrentImageRun_Click);
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.67162F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.32838F));
            this.tblMain.Controls.Add(this.tblParametersAndResultShow, 1, 0);
            this.tblMain.Controls.Add(this.tblImageAndControl, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(3, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 765F));
            this.tblMain.Size = new System.Drawing.Size(1356, 765);
            this.tblMain.TabIndex = 9;
            // 
            // tblParametersAndResultShow
            // 
            this.tblParametersAndResultShow.ColumnCount = 1;
            this.tblParametersAndResultShow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblParametersAndResultShow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblParametersAndResultShow.Controls.Add(this.group_main, 0, 1);
            this.tblParametersAndResultShow.Controls.Add(this.groupBoxTongji, 0, 0);
            this.tblParametersAndResultShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblParametersAndResultShow.Location = new System.Drawing.Point(364, 3);
            this.tblParametersAndResultShow.Name = "tblParametersAndResultShow";
            this.tblParametersAndResultShow.RowCount = 2;
            this.tblParametersAndResultShow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblParametersAndResultShow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblParametersAndResultShow.Size = new System.Drawing.Size(989, 759);
            this.tblParametersAndResultShow.TabIndex = 1;
            // 
            // group_main
            // 
            this.group_main.Controls.Add(this.tblMain2);
            this.group_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_main.Location = new System.Drawing.Point(3, 154);
            this.group_main.Name = "group_main";
            this.group_main.Size = new System.Drawing.Size(983, 602);
            this.group_main.TabIndex = 11;
            this.group_main.TabStop = false;
            this.group_main.Text = "参数";
            // 
            // tblMain2
            // 
            this.tblMain2.ColumnCount = 2;
            this.tblMain2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.93313F));
            this.tblMain2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.06687F));
            this.tblMain2.Controls.Add(this.tabControl_Main, 1, 0);
            this.tblMain2.Controls.Add(this.palSelectMeasure, 0, 0);
            this.tblMain2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain2.Location = new System.Drawing.Point(3, 17);
            this.tblMain2.Name = "tblMain2";
            this.tblMain2.RowCount = 1;
            this.tblMain2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain2.Size = new System.Drawing.Size(977, 582);
            this.tblMain2.TabIndex = 2;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tab_Beam_Touch_Window_L_L);
            this.tabControl_Main.Controls.Add(this.tab_Beam_Touch_Window_L_R);
            this.tabControl_Main.Controls.Add(this.tab_Beam_Tip_To_Window_L);
            this.tabControl_Main.Controls.Add(this.tab_Beam_Touch_Window_R_L);
            this.tabControl_Main.Controls.Add(this.tab_Beam_Touch_Window_R_R);
            this.tabControl_Main.Controls.Add(this.tab_Beam_Tip_To_Window_R);
            this.tabControl_Main.Controls.Add(this.tab_Beam_Height_Difference);
            this.tabControl_Main.Controls.Add(this.tab_Shield_Flatness);
            this.tabControl_Main.Controls.Add(this.tab_Cross_Shield_TP);
            this.tabControl_Main.Controls.Add(this.tab_Wafer_Thickness);
            this.tabControl_Main.Controls.Add(this.tab_Shield_Cross_Angle);
            this.tabControl_Main.Controls.Add(this.tab_Beam_Height_L);
            this.tabControl_Main.Controls.Add(this.tab_Beam_Height_R);
            this.tabControl_Main.Controls.Add(this.tab_Beam_Inner_L);
            this.tabControl_Main.Controls.Add(this.tab_Beam_Inner_R);
            this.tabControl_Main.Controls.Add(this.tab_TiePian);
            this.tabControl_Main.Font = new System.Drawing.Font("宋体", 9F);
            this.tabControl_Main.Location = new System.Drawing.Point(178, 3);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(796, 500);
            this.tabControl_Main.TabIndex = 1;
            this.tabControl_Main.SelectedIndexChanged += new System.EventHandler(this.tabControl_Main_SelectedIndexChanged);
            // 
            // tab_Beam_Touch_Window_L_L
            // 
            this.tab_Beam_Touch_Window_L_L.BackColor = System.Drawing.Color.White;
            this.tab_Beam_Touch_Window_L_L.Controls.Add(this.tbll_bll);
            this.tab_Beam_Touch_Window_L_L.Location = new System.Drawing.Point(4, 22);
            this.tab_Beam_Touch_Window_L_L.Name = "tab_Beam_Touch_Window_L_L";
            this.tab_Beam_Touch_Window_L_L.Size = new System.Drawing.Size(788, 474);
            this.tab_Beam_Touch_Window_L_L.TabIndex = 6;
            this.tab_Beam_Touch_Window_L_L.Text = "Beam_Touch_Window_L_L";
            // 
            // tbll_bll
            // 
            this.tbll_bll.ColumnCount = 2;
            this.tbll_bll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.84264F));
            this.tbll_bll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.15736F));
            this.tbll_bll.Controls.Add(this.dataGrid_Beam_Touch_Window_L_L, 0, 0);
            this.tbll_bll.Controls.Add(this.userControlSetMaxAndMin1, 1, 0);
            this.tbll_bll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbll_bll.Location = new System.Drawing.Point(0, 0);
            this.tbll_bll.Name = "tbll_bll";
            this.tbll_bll.RowCount = 1;
            this.tbll_bll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbll_bll.Size = new System.Drawing.Size(788, 474);
            this.tbll_bll.TabIndex = 1;
            // 
            // dataGrid_Beam_Touch_Window_L_L
            // 
            this.dataGrid_Beam_Touch_Window_L_L.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_Beam_Touch_Window_L_L.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Beam_Touch_Window_L_L.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Beam_Touch_Window_L_L.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Beam_Touch_Window_L_L.Name = "dataGrid_Beam_Touch_Window_L_L";
            this.dataGrid_Beam_Touch_Window_L_L.RowTemplate.Height = 23;
            this.dataGrid_Beam_Touch_Window_L_L.Size = new System.Drawing.Size(568, 446);
            this.dataGrid_Beam_Touch_Window_L_L.TabIndex = 0;
            this.dataGrid_Beam_Touch_Window_L_L.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Beam_Touch_Window_L_R
            // 
            this.tab_Beam_Touch_Window_L_R.Controls.Add(this.tbll_lr);
            this.tab_Beam_Touch_Window_L_R.Location = new System.Drawing.Point(4, 22);
            this.tab_Beam_Touch_Window_L_R.Name = "tab_Beam_Touch_Window_L_R";
            this.tab_Beam_Touch_Window_L_R.Size = new System.Drawing.Size(788, 474);
            this.tab_Beam_Touch_Window_L_R.TabIndex = 7;
            this.tab_Beam_Touch_Window_L_R.Text = "Beam_Touch_Window_L_R";
            this.tab_Beam_Touch_Window_L_R.UseVisualStyleBackColor = true;
            // 
            // tbll_lr
            // 
            this.tbll_lr.ColumnCount = 2;
            this.tbll_lr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.41624F));
            this.tbll_lr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.58376F));
            this.tbll_lr.Controls.Add(this.userControlSetMaxAndMin2, 1, 0);
            this.tbll_lr.Controls.Add(this.dataGrid_Beam_Touch_Window_L_R, 0, 0);
            this.tbll_lr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbll_lr.Location = new System.Drawing.Point(0, 0);
            this.tbll_lr.Name = "tbll_lr";
            this.tbll_lr.RowCount = 1;
            this.tbll_lr.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbll_lr.Size = new System.Drawing.Size(788, 474);
            this.tbll_lr.TabIndex = 2;
            // 
            // dataGrid_Beam_Touch_Window_L_R
            // 
            this.dataGrid_Beam_Touch_Window_L_R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Beam_Touch_Window_L_R.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Beam_Touch_Window_L_R.Name = "dataGrid_Beam_Touch_Window_L_R";
            this.dataGrid_Beam_Touch_Window_L_R.RowTemplate.Height = 23;
            this.dataGrid_Beam_Touch_Window_L_R.Size = new System.Drawing.Size(540, 362);
            this.dataGrid_Beam_Touch_Window_L_R.TabIndex = 1;
            this.dataGrid_Beam_Touch_Window_L_R.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Beam_Tip_To_Window_L
            // 
            this.tab_Beam_Tip_To_Window_L.Controls.Add(this.tableLayoutPanel2);
            this.tab_Beam_Tip_To_Window_L.Location = new System.Drawing.Point(4, 22);
            this.tab_Beam_Tip_To_Window_L.Name = "tab_Beam_Tip_To_Window_L";
            this.tab_Beam_Tip_To_Window_L.Size = new System.Drawing.Size(788, 474);
            this.tab_Beam_Tip_To_Window_L.TabIndex = 8;
            this.tab_Beam_Tip_To_Window_L.Text = "Beam_Tip_To_Window_L";
            this.tab_Beam_Tip_To_Window_L.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.96954F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.03046F));
            this.tableLayoutPanel2.Controls.Add(this.userControlSetMaxAndMin3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGrid_Beam_Tip_To_Window_L, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 474);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // dataGrid_Beam_Tip_To_Window_L
            // 
            this.dataGrid_Beam_Tip_To_Window_L.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Beam_Tip_To_Window_L.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Beam_Tip_To_Window_L.Name = "dataGrid_Beam_Tip_To_Window_L";
            this.dataGrid_Beam_Tip_To_Window_L.RowTemplate.Height = 23;
            this.dataGrid_Beam_Tip_To_Window_L.Size = new System.Drawing.Size(569, 468);
            this.dataGrid_Beam_Tip_To_Window_L.TabIndex = 2;
            this.dataGrid_Beam_Tip_To_Window_L.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Beam_Touch_Window_R_L
            // 
            this.tab_Beam_Touch_Window_R_L.Controls.Add(this.tbll_l);
            this.tab_Beam_Touch_Window_R_L.Location = new System.Drawing.Point(4, 22);
            this.tab_Beam_Touch_Window_R_L.Name = "tab_Beam_Touch_Window_R_L";
            this.tab_Beam_Touch_Window_R_L.Size = new System.Drawing.Size(788, 474);
            this.tab_Beam_Touch_Window_R_L.TabIndex = 9;
            this.tab_Beam_Touch_Window_R_L.Text = "Beam_Touch_Window_R_L";
            this.tab_Beam_Touch_Window_R_L.UseVisualStyleBackColor = true;
            // 
            // tbll_l
            // 
            this.tbll_l.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tbll_l.ColumnCount = 2;
            this.tbll_l.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.47716F));
            this.tbll_l.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.52284F));
            this.tbll_l.Controls.Add(this.userControlSetMaxAndMin4, 1, 0);
            this.tbll_l.Controls.Add(this.dataGrid_Beam_Touch_Window_R_L, 0, 0);
            this.tbll_l.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbll_l.Location = new System.Drawing.Point(0, 0);
            this.tbll_l.Name = "tbll_l";
            this.tbll_l.RowCount = 1;
            this.tbll_l.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbll_l.Size = new System.Drawing.Size(788, 474);
            this.tbll_l.TabIndex = 3;
            // 
            // dataGrid_Beam_Touch_Window_R_L
            // 
            this.dataGrid_Beam_Touch_Window_R_L.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Beam_Touch_Window_R_L.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Beam_Touch_Window_R_L.Name = "dataGrid_Beam_Touch_Window_R_L";
            this.dataGrid_Beam_Touch_Window_R_L.RowTemplate.Height = 23;
            this.dataGrid_Beam_Touch_Window_R_L.Size = new System.Drawing.Size(573, 461);
            this.dataGrid_Beam_Touch_Window_R_L.TabIndex = 2;
            this.dataGrid_Beam_Touch_Window_R_L.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Beam_Touch_Window_R_R
            // 
            this.tab_Beam_Touch_Window_R_R.Controls.Add(this.tableLayoutPanel4);
            this.tab_Beam_Touch_Window_R_R.Location = new System.Drawing.Point(4, 22);
            this.tab_Beam_Touch_Window_R_R.Name = "tab_Beam_Touch_Window_R_R";
            this.tab_Beam_Touch_Window_R_R.Size = new System.Drawing.Size(788, 474);
            this.tab_Beam_Touch_Window_R_R.TabIndex = 10;
            this.tab_Beam_Touch_Window_R_R.Text = "Beam_Touch_Window_R_R";
            this.tab_Beam_Touch_Window_R_R.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.58883F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.41117F));
            this.tableLayoutPanel4.Controls.Add(this.userControlSetMaxAndMin5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.dataGrid_Beam_Touch_Window_R_R, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(788, 474);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // dataGrid_Beam_Touch_Window_R_R
            // 
            this.dataGrid_Beam_Touch_Window_R_R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Beam_Touch_Window_R_R.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Beam_Touch_Window_R_R.Name = "dataGrid_Beam_Touch_Window_R_R";
            this.dataGrid_Beam_Touch_Window_R_R.RowTemplate.Height = 23;
            this.dataGrid_Beam_Touch_Window_R_R.Size = new System.Drawing.Size(565, 468);
            this.dataGrid_Beam_Touch_Window_R_R.TabIndex = 2;
            this.dataGrid_Beam_Touch_Window_R_R.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Beam_Tip_To_Window_R
            // 
            this.tab_Beam_Tip_To_Window_R.Controls.Add(this.tableLayoutPanel5);
            this.tab_Beam_Tip_To_Window_R.Location = new System.Drawing.Point(4, 22);
            this.tab_Beam_Tip_To_Window_R.Name = "tab_Beam_Tip_To_Window_R";
            this.tab_Beam_Tip_To_Window_R.Size = new System.Drawing.Size(788, 474);
            this.tab_Beam_Tip_To_Window_R.TabIndex = 11;
            this.tab_Beam_Tip_To_Window_R.Text = "Beam_Tip_To_Window_R";
            this.tab_Beam_Tip_To_Window_R.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.08121F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.91878F));
            this.tableLayoutPanel5.Controls.Add(this.userControlSetMaxAndMin6, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dataGrid_Beam_Tip_To_Window_R, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(788, 474);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // dataGrid_Beam_Tip_To_Window_R
            // 
            this.dataGrid_Beam_Tip_To_Window_R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Beam_Tip_To_Window_R.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Beam_Tip_To_Window_R.Name = "dataGrid_Beam_Tip_To_Window_R";
            this.dataGrid_Beam_Tip_To_Window_R.RowTemplate.Height = 23;
            this.dataGrid_Beam_Tip_To_Window_R.Size = new System.Drawing.Size(98, 53);
            this.dataGrid_Beam_Tip_To_Window_R.TabIndex = 2;
            this.dataGrid_Beam_Tip_To_Window_R.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Beam_Height_Difference
            // 
            this.tab_Beam_Height_Difference.Controls.Add(this.tableLayoutPanel6);
            this.tab_Beam_Height_Difference.Location = new System.Drawing.Point(4, 22);
            this.tab_Beam_Height_Difference.Name = "tab_Beam_Height_Difference";
            this.tab_Beam_Height_Difference.Size = new System.Drawing.Size(788, 474);
            this.tab_Beam_Height_Difference.TabIndex = 12;
            this.tab_Beam_Height_Difference.Text = "Beam_Height_Difference";
            this.tab_Beam_Height_Difference.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.85786F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.14213F));
            this.tableLayoutPanel6.Controls.Add(this.userControlSetMaxAndMin7, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.dataGrid_Beam_Height_Difference, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(788, 474);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // dataGrid_Beam_Height_Difference
            // 
            this.dataGrid_Beam_Height_Difference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Beam_Height_Difference.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Beam_Height_Difference.Name = "dataGrid_Beam_Height_Difference";
            this.dataGrid_Beam_Height_Difference.RowTemplate.Height = 23;
            this.dataGrid_Beam_Height_Difference.Size = new System.Drawing.Size(100, 53);
            this.dataGrid_Beam_Height_Difference.TabIndex = 2;
            this.dataGrid_Beam_Height_Difference.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Shield_Flatness
            // 
            this.tab_Shield_Flatness.Controls.Add(this.tableLayoutPanel7);
            this.tab_Shield_Flatness.Location = new System.Drawing.Point(4, 22);
            this.tab_Shield_Flatness.Name = "tab_Shield_Flatness";
            this.tab_Shield_Flatness.Size = new System.Drawing.Size(788, 474);
            this.tab_Shield_Flatness.TabIndex = 13;
            this.tab_Shield_Flatness.Text = "Shield_Flatness";
            this.tab_Shield_Flatness.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.49239F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.50761F));
            this.tableLayoutPanel7.Controls.Add(this.userControlSetMaxAndMin8, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.dataGrid_Shield_Flatness, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(788, 474);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // dataGrid_Shield_Flatness
            // 
            this.dataGrid_Shield_Flatness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Shield_Flatness.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Shield_Flatness.Name = "dataGrid_Shield_Flatness";
            this.dataGrid_Shield_Flatness.RowTemplate.Height = 23;
            this.dataGrid_Shield_Flatness.Size = new System.Drawing.Size(101, 53);
            this.dataGrid_Shield_Flatness.TabIndex = 2;
            this.dataGrid_Shield_Flatness.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Cross_Shield_TP
            // 
            this.tab_Cross_Shield_TP.Controls.Add(this.tableLayoutPanel8);
            this.tab_Cross_Shield_TP.Location = new System.Drawing.Point(4, 22);
            this.tab_Cross_Shield_TP.Name = "tab_Cross_Shield_TP";
            this.tab_Cross_Shield_TP.Size = new System.Drawing.Size(788, 474);
            this.tab_Cross_Shield_TP.TabIndex = 14;
            this.tab_Cross_Shield_TP.Text = "Cross_Shield_TP";
            this.tab_Cross_Shield_TP.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.46193F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.53807F));
            this.tableLayoutPanel8.Controls.Add(this.userControlSetMaxAndMin9, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.dataGrid_Cross_Shield_TP, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(788, 474);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // dataGrid_Cross_Shield_TP
            // 
            this.dataGrid_Cross_Shield_TP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGrid_Cross_Shield_TP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Cross_Shield_TP.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Cross_Shield_TP.Name = "dataGrid_Cross_Shield_TP";
            this.dataGrid_Cross_Shield_TP.RowTemplate.Height = 23;
            this.dataGrid_Cross_Shield_TP.Size = new System.Drawing.Size(98, 53);
            this.dataGrid_Cross_Shield_TP.TabIndex = 2;
            this.dataGrid_Cross_Shield_TP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Wafer_Thickness
            // 
            this.tab_Wafer_Thickness.Controls.Add(this.tableLayoutPanel9);
            this.tab_Wafer_Thickness.Location = new System.Drawing.Point(4, 22);
            this.tab_Wafer_Thickness.Name = "tab_Wafer_Thickness";
            this.tab_Wafer_Thickness.Size = new System.Drawing.Size(788, 474);
            this.tab_Wafer_Thickness.TabIndex = 15;
            this.tab_Wafer_Thickness.Text = "Wafer_Thickness";
            this.tab_Wafer_Thickness.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.11167F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.88832F));
            this.tableLayoutPanel9.Controls.Add(this.userControlSetMaxAndMin10, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.dataGrid_Wafer_Thickness, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(788, 474);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // dataGrid_Wafer_Thickness
            // 
            this.dataGrid_Wafer_Thickness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Wafer_Thickness.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Wafer_Thickness.Name = "dataGrid_Wafer_Thickness";
            this.dataGrid_Wafer_Thickness.RowTemplate.Height = 23;
            this.dataGrid_Wafer_Thickness.Size = new System.Drawing.Size(100, 53);
            this.dataGrid_Wafer_Thickness.TabIndex = 2;
            this.dataGrid_Wafer_Thickness.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Shield_Cross_Angle
            // 
            this.tab_Shield_Cross_Angle.Controls.Add(this.tableLayoutPanel10);
            this.tab_Shield_Cross_Angle.Location = new System.Drawing.Point(4, 22);
            this.tab_Shield_Cross_Angle.Name = "tab_Shield_Cross_Angle";
            this.tab_Shield_Cross_Angle.Size = new System.Drawing.Size(788, 474);
            this.tab_Shield_Cross_Angle.TabIndex = 16;
            this.tab_Shield_Cross_Angle.Text = "Shield_Cross_Angle";
            this.tab_Shield_Cross_Angle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.84264F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.15736F));
            this.tableLayoutPanel10.Controls.Add(this.userControlSetMaxAndMin11, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.dataGrid_Shield_Cross_Angle, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(788, 474);
            this.tableLayoutPanel10.TabIndex = 4;
            // 
            // dataGrid_Shield_Cross_Angle
            // 
            this.dataGrid_Shield_Cross_Angle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Shield_Cross_Angle.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Shield_Cross_Angle.Name = "dataGrid_Shield_Cross_Angle";
            this.dataGrid_Shield_Cross_Angle.RowTemplate.Height = 23;
            this.dataGrid_Shield_Cross_Angle.Size = new System.Drawing.Size(98, 53);
            this.dataGrid_Shield_Cross_Angle.TabIndex = 3;
            this.dataGrid_Shield_Cross_Angle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Beam_Height_L
            // 
            this.tab_Beam_Height_L.Controls.Add(this.tableLayoutPanel11);
            this.tab_Beam_Height_L.Location = new System.Drawing.Point(4, 22);
            this.tab_Beam_Height_L.Name = "tab_Beam_Height_L";
            this.tab_Beam_Height_L.Size = new System.Drawing.Size(788, 474);
            this.tab_Beam_Height_L.TabIndex = 17;
            this.tab_Beam_Height_L.Text = "Beam_Height_L";
            this.tab_Beam_Height_L.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.63452F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.36548F));
            this.tableLayoutPanel11.Controls.Add(this.userControlSetMaxAndMin12, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.dataGrid_Beam_Height_L, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(788, 474);
            this.tableLayoutPanel11.TabIndex = 5;
            // 
            // dataGrid_Beam_Height_L
            // 
            this.dataGrid_Beam_Height_L.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Beam_Height_L.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Beam_Height_L.Name = "dataGrid_Beam_Height_L";
            this.dataGrid_Beam_Height_L.RowTemplate.Height = 23;
            this.dataGrid_Beam_Height_L.Size = new System.Drawing.Size(103, 53);
            this.dataGrid_Beam_Height_L.TabIndex = 4;
            this.dataGrid_Beam_Height_L.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Beam_Height_R
            // 
            this.tab_Beam_Height_R.Controls.Add(this.tableLayoutPanel12);
            this.tab_Beam_Height_R.Location = new System.Drawing.Point(4, 22);
            this.tab_Beam_Height_R.Name = "tab_Beam_Height_R";
            this.tab_Beam_Height_R.Size = new System.Drawing.Size(788, 474);
            this.tab_Beam_Height_R.TabIndex = 18;
            this.tab_Beam_Height_R.Text = "Beam_Height_R";
            this.tab_Beam_Height_R.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.84264F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.15736F));
            this.tableLayoutPanel12.Controls.Add(this.userControlSetMaxAndMin13, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.dataGrid_Beam_Height_R, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(788, 474);
            this.tableLayoutPanel12.TabIndex = 5;
            // 
            // dataGrid_Beam_Height_R
            // 
            this.dataGrid_Beam_Height_R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Beam_Height_R.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Beam_Height_R.Name = "dataGrid_Beam_Height_R";
            this.dataGrid_Beam_Height_R.RowTemplate.Height = 23;
            this.dataGrid_Beam_Height_R.Size = new System.Drawing.Size(98, 53);
            this.dataGrid_Beam_Height_R.TabIndex = 4;
            this.dataGrid_Beam_Height_R.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Beam_Inner_L
            // 
            this.tab_Beam_Inner_L.Controls.Add(this.dataGrid_Beam_Inner_L);
            this.tab_Beam_Inner_L.Location = new System.Drawing.Point(4, 22);
            this.tab_Beam_Inner_L.Name = "tab_Beam_Inner_L";
            this.tab_Beam_Inner_L.Size = new System.Drawing.Size(788, 474);
            this.tab_Beam_Inner_L.TabIndex = 19;
            this.tab_Beam_Inner_L.Text = "Beam_Inner_L";
            this.tab_Beam_Inner_L.UseVisualStyleBackColor = true;
            // 
            // dataGrid_Beam_Inner_L
            // 
            this.dataGrid_Beam_Inner_L.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Beam_Inner_L.Location = new System.Drawing.Point(4, 0);
            this.dataGrid_Beam_Inner_L.Name = "dataGrid_Beam_Inner_L";
            this.dataGrid_Beam_Inner_L.RowTemplate.Height = 23;
            this.dataGrid_Beam_Inner_L.Size = new System.Drawing.Size(568, 446);
            this.dataGrid_Beam_Inner_L.TabIndex = 1;
            this.dataGrid_Beam_Inner_L.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_Beam_Inner_R
            // 
            this.tab_Beam_Inner_R.Controls.Add(this.dataGrid_Beam_Inner_R);
            this.tab_Beam_Inner_R.Location = new System.Drawing.Point(4, 22);
            this.tab_Beam_Inner_R.Name = "tab_Beam_Inner_R";
            this.tab_Beam_Inner_R.Size = new System.Drawing.Size(788, 474);
            this.tab_Beam_Inner_R.TabIndex = 20;
            this.tab_Beam_Inner_R.Text = "Beam_Inner_R";
            this.tab_Beam_Inner_R.UseVisualStyleBackColor = true;
            // 
            // dataGrid_Beam_Inner_R
            // 
            this.dataGrid_Beam_Inner_R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Beam_Inner_R.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_Beam_Inner_R.Name = "dataGrid_Beam_Inner_R";
            this.dataGrid_Beam_Inner_R.RowTemplate.Height = 23;
            this.dataGrid_Beam_Inner_R.Size = new System.Drawing.Size(568, 446);
            this.dataGrid_Beam_Inner_R.TabIndex = 1;
            this.dataGrid_Beam_Inner_R.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // tab_TiePian
            // 
            this.tab_TiePian.Controls.Add(this.dataGrid_TiePian);
            this.tab_TiePian.Location = new System.Drawing.Point(4, 22);
            this.tab_TiePian.Name = "tab_TiePian";
            this.tab_TiePian.Size = new System.Drawing.Size(788, 474);
            this.tab_TiePian.TabIndex = 21;
            this.tab_TiePian.Text = "TiePian";
            this.tab_TiePian.UseVisualStyleBackColor = true;
            // 
            // dataGrid_TiePian
            // 
            this.dataGrid_TiePian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_TiePian.Location = new System.Drawing.Point(4, 3);
            this.dataGrid_TiePian.Name = "dataGrid_TiePian";
            this.dataGrid_TiePian.RowTemplate.Height = 23;
            this.dataGrid_TiePian.Size = new System.Drawing.Size(568, 446);
            this.dataGrid_TiePian.TabIndex = 2;
            this.dataGrid_TiePian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Beam_Touch_Window_L_L_CellClick);
            // 
            // palSelectMeasure
            // 
            this.palSelectMeasure.Controls.Add(this.ra_TiePian);
            this.palSelectMeasure.Controls.Add(this.ra_Beam_Inner_L);
            this.palSelectMeasure.Controls.Add(this.ra_Beam_Inner_R);
            this.palSelectMeasure.Controls.Add(this.ra_Beam_Height_L);
            this.palSelectMeasure.Controls.Add(this.ra_Beam_Height_R);
            this.palSelectMeasure.Controls.Add(this.ra_Shield_Cross_Angle);
            this.palSelectMeasure.Controls.Add(this.ra_Wafer_Thickness);
            this.palSelectMeasure.Controls.Add(this.ra_Cross_Shield_TP);
            this.palSelectMeasure.Controls.Add(this.ra_Shield_Flatness);
            this.palSelectMeasure.Controls.Add(this.ra_Beam_Height_Difference);
            this.palSelectMeasure.Controls.Add(this.ra_Beam_Tip_To_Window_R);
            this.palSelectMeasure.Controls.Add(this.ra_Beam_Touch_Window_R_R);
            this.palSelectMeasure.Controls.Add(this.ra_Beam_Touch_Window_R_L);
            this.palSelectMeasure.Controls.Add(this.ra_Beam_Tip_To_Window_L);
            this.palSelectMeasure.Controls.Add(this.ra_Beam_Touch_Window_L_R);
            this.palSelectMeasure.Controls.Add(this.ra_Beam_Touch_Window_L_L);
            this.palSelectMeasure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palSelectMeasure.Location = new System.Drawing.Point(3, 3);
            this.palSelectMeasure.Name = "palSelectMeasure";
            this.palSelectMeasure.Size = new System.Drawing.Size(169, 576);
            this.palSelectMeasure.TabIndex = 2;
            // 
            // ra_TiePian
            // 
            this.ra_TiePian.AutoSize = true;
            this.ra_TiePian.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_TiePian.Location = new System.Drawing.Point(0, 579);
            this.ra_TiePian.Name = "ra_TiePian";
            this.ra_TiePian.Size = new System.Drawing.Size(74, 18);
            this.ra_TiePian.TabIndex = 24;
            this.ra_TiePian.TabStop = true;
            this.ra_TiePian.Text = "TiePian";
            this.ra_TiePian.UseVisualStyleBackColor = true;
            this.ra_TiePian.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Beam_Inner_L
            // 
            this.ra_Beam_Inner_L.AutoSize = true;
            this.ra_Beam_Inner_L.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Beam_Inner_L.Location = new System.Drawing.Point(-2, 388);
            this.ra_Beam_Inner_L.Name = "ra_Beam_Inner_L";
            this.ra_Beam_Inner_L.Size = new System.Drawing.Size(109, 18);
            this.ra_Beam_Inner_L.TabIndex = 23;
            this.ra_Beam_Inner_L.TabStop = true;
            this.ra_Beam_Inner_L.Text = "Beam_Inner_L";
            this.ra_Beam_Inner_L.UseVisualStyleBackColor = true;
            this.ra_Beam_Inner_L.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Beam_Inner_R
            // 
            this.ra_Beam_Inner_R.AutoSize = true;
            this.ra_Beam_Inner_R.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Beam_Inner_R.Location = new System.Drawing.Point(-2, 350);
            this.ra_Beam_Inner_R.Name = "ra_Beam_Inner_R";
            this.ra_Beam_Inner_R.Size = new System.Drawing.Size(109, 18);
            this.ra_Beam_Inner_R.TabIndex = 22;
            this.ra_Beam_Inner_R.TabStop = true;
            this.ra_Beam_Inner_R.Text = "Beam_Inner_R";
            this.ra_Beam_Inner_R.UseVisualStyleBackColor = true;
            this.ra_Beam_Inner_R.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Beam_Height_L
            // 
            this.ra_Beam_Height_L.AutoSize = true;
            this.ra_Beam_Height_L.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Beam_Height_L.Location = new System.Drawing.Point(-2, 317);
            this.ra_Beam_Height_L.Name = "ra_Beam_Height_L";
            this.ra_Beam_Height_L.Size = new System.Drawing.Size(116, 18);
            this.ra_Beam_Height_L.TabIndex = 21;
            this.ra_Beam_Height_L.TabStop = true;
            this.ra_Beam_Height_L.Text = "Beam_Height_L";
            this.ra_Beam_Height_L.UseVisualStyleBackColor = true;
            this.ra_Beam_Height_L.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Beam_Height_R
            // 
            this.ra_Beam_Height_R.AutoSize = true;
            this.ra_Beam_Height_R.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Beam_Height_R.Location = new System.Drawing.Point(-2, 279);
            this.ra_Beam_Height_R.Name = "ra_Beam_Height_R";
            this.ra_Beam_Height_R.Size = new System.Drawing.Size(116, 18);
            this.ra_Beam_Height_R.TabIndex = 20;
            this.ra_Beam_Height_R.TabStop = true;
            this.ra_Beam_Height_R.Text = "Beam_Height_R";
            this.ra_Beam_Height_R.UseVisualStyleBackColor = true;
            this.ra_Beam_Height_R.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Shield_Cross_Angle
            // 
            this.ra_Shield_Cross_Angle.AutoSize = true;
            this.ra_Shield_Cross_Angle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Shield_Cross_Angle.Location = new System.Drawing.Point(0, 544);
            this.ra_Shield_Cross_Angle.Name = "ra_Shield_Cross_Angle";
            this.ra_Shield_Cross_Angle.Size = new System.Drawing.Size(151, 18);
            this.ra_Shield_Cross_Angle.TabIndex = 19;
            this.ra_Shield_Cross_Angle.TabStop = true;
            this.ra_Shield_Cross_Angle.Text = "Shield_Cross_Angle";
            this.ra_Shield_Cross_Angle.UseVisualStyleBackColor = true;
            this.ra_Shield_Cross_Angle.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Wafer_Thickness
            // 
            this.ra_Wafer_Thickness.AutoSize = true;
            this.ra_Wafer_Thickness.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Wafer_Thickness.Location = new System.Drawing.Point(0, 506);
            this.ra_Wafer_Thickness.Name = "ra_Wafer_Thickness";
            this.ra_Wafer_Thickness.Size = new System.Drawing.Size(130, 18);
            this.ra_Wafer_Thickness.TabIndex = 18;
            this.ra_Wafer_Thickness.TabStop = true;
            this.ra_Wafer_Thickness.Text = "Wafer_Thickness";
            this.ra_Wafer_Thickness.UseVisualStyleBackColor = true;
            this.ra_Wafer_Thickness.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Cross_Shield_TP
            // 
            this.ra_Cross_Shield_TP.AutoSize = true;
            this.ra_Cross_Shield_TP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Cross_Shield_TP.Location = new System.Drawing.Point(0, 468);
            this.ra_Cross_Shield_TP.Name = "ra_Cross_Shield_TP";
            this.ra_Cross_Shield_TP.Size = new System.Drawing.Size(130, 18);
            this.ra_Cross_Shield_TP.TabIndex = 17;
            this.ra_Cross_Shield_TP.TabStop = true;
            this.ra_Cross_Shield_TP.Text = "Cross_Shield_TP";
            this.ra_Cross_Shield_TP.UseVisualStyleBackColor = true;
            this.ra_Cross_Shield_TP.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Shield_Flatness
            // 
            this.ra_Shield_Flatness.AutoSize = true;
            this.ra_Shield_Flatness.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Shield_Flatness.Location = new System.Drawing.Point(0, 430);
            this.ra_Shield_Flatness.Name = "ra_Shield_Flatness";
            this.ra_Shield_Flatness.Size = new System.Drawing.Size(130, 18);
            this.ra_Shield_Flatness.TabIndex = 16;
            this.ra_Shield_Flatness.TabStop = true;
            this.ra_Shield_Flatness.Text = "Shield_Flatness";
            this.ra_Shield_Flatness.UseVisualStyleBackColor = true;
            this.ra_Shield_Flatness.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Beam_Height_Difference
            // 
            this.ra_Beam_Height_Difference.AutoSize = true;
            this.ra_Beam_Height_Difference.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Beam_Height_Difference.Location = new System.Drawing.Point(-2, 241);
            this.ra_Beam_Height_Difference.Name = "ra_Beam_Height_Difference";
            this.ra_Beam_Height_Difference.Size = new System.Drawing.Size(179, 18);
            this.ra_Beam_Height_Difference.TabIndex = 15;
            this.ra_Beam_Height_Difference.TabStop = true;
            this.ra_Beam_Height_Difference.Text = "Beam_Height_Difference";
            this.ra_Beam_Height_Difference.UseVisualStyleBackColor = true;
            this.ra_Beam_Height_Difference.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Beam_Tip_To_Window_R
            // 
            this.ra_Beam_Tip_To_Window_R.AutoSize = true;
            this.ra_Beam_Tip_To_Window_R.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Beam_Tip_To_Window_R.Location = new System.Drawing.Point(-2, 203);
            this.ra_Beam_Tip_To_Window_R.Name = "ra_Beam_Tip_To_Window_R";
            this.ra_Beam_Tip_To_Window_R.Size = new System.Drawing.Size(165, 18);
            this.ra_Beam_Tip_To_Window_R.TabIndex = 14;
            this.ra_Beam_Tip_To_Window_R.TabStop = true;
            this.ra_Beam_Tip_To_Window_R.Text = "Beam_Tip_To_Window_R";
            this.ra_Beam_Tip_To_Window_R.UseVisualStyleBackColor = true;
            this.ra_Beam_Tip_To_Window_R.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Beam_Touch_Window_R_R
            // 
            this.ra_Beam_Touch_Window_R_R.AutoSize = true;
            this.ra_Beam_Touch_Window_R_R.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Beam_Touch_Window_R_R.Location = new System.Drawing.Point(-2, 165);
            this.ra_Beam_Touch_Window_R_R.Name = "ra_Beam_Touch_Window_R_R";
            this.ra_Beam_Touch_Window_R_R.Size = new System.Drawing.Size(172, 18);
            this.ra_Beam_Touch_Window_R_R.TabIndex = 13;
            this.ra_Beam_Touch_Window_R_R.TabStop = true;
            this.ra_Beam_Touch_Window_R_R.Text = "Beam_Touch_Window_R_R";
            this.ra_Beam_Touch_Window_R_R.UseVisualStyleBackColor = true;
            this.ra_Beam_Touch_Window_R_R.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Beam_Touch_Window_R_L
            // 
            this.ra_Beam_Touch_Window_R_L.AutoSize = true;
            this.ra_Beam_Touch_Window_R_L.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Beam_Touch_Window_R_L.Location = new System.Drawing.Point(-2, 127);
            this.ra_Beam_Touch_Window_R_L.Name = "ra_Beam_Touch_Window_R_L";
            this.ra_Beam_Touch_Window_R_L.Size = new System.Drawing.Size(172, 18);
            this.ra_Beam_Touch_Window_R_L.TabIndex = 12;
            this.ra_Beam_Touch_Window_R_L.TabStop = true;
            this.ra_Beam_Touch_Window_R_L.Text = "Beam_Touch_Window_R_L";
            this.ra_Beam_Touch_Window_R_L.UseVisualStyleBackColor = true;
            this.ra_Beam_Touch_Window_R_L.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Beam_Tip_To_Window_L
            // 
            this.ra_Beam_Tip_To_Window_L.AutoSize = true;
            this.ra_Beam_Tip_To_Window_L.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Beam_Tip_To_Window_L.Location = new System.Drawing.Point(-2, 89);
            this.ra_Beam_Tip_To_Window_L.Name = "ra_Beam_Tip_To_Window_L";
            this.ra_Beam_Tip_To_Window_L.Size = new System.Drawing.Size(165, 18);
            this.ra_Beam_Tip_To_Window_L.TabIndex = 11;
            this.ra_Beam_Tip_To_Window_L.TabStop = true;
            this.ra_Beam_Tip_To_Window_L.Text = "Beam_Tip_To_Window_L";
            this.ra_Beam_Tip_To_Window_L.UseVisualStyleBackColor = true;
            this.ra_Beam_Tip_To_Window_L.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Beam_Touch_Window_L_R
            // 
            this.ra_Beam_Touch_Window_L_R.AutoSize = true;
            this.ra_Beam_Touch_Window_L_R.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Beam_Touch_Window_L_R.Location = new System.Drawing.Point(-2, 51);
            this.ra_Beam_Touch_Window_L_R.Name = "ra_Beam_Touch_Window_L_R";
            this.ra_Beam_Touch_Window_L_R.Size = new System.Drawing.Size(172, 18);
            this.ra_Beam_Touch_Window_L_R.TabIndex = 10;
            this.ra_Beam_Touch_Window_L_R.TabStop = true;
            this.ra_Beam_Touch_Window_L_R.Text = "Beam_Touch_Window_L_R";
            this.ra_Beam_Touch_Window_L_R.UseVisualStyleBackColor = true;
            this.ra_Beam_Touch_Window_L_R.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // ra_Beam_Touch_Window_L_L
            // 
            this.ra_Beam_Touch_Window_L_L.AutoSize = true;
            this.ra_Beam_Touch_Window_L_L.BackColor = System.Drawing.SystemColors.Control;
            this.ra_Beam_Touch_Window_L_L.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_Beam_Touch_Window_L_L.Location = new System.Drawing.Point(-2, 13);
            this.ra_Beam_Touch_Window_L_L.Name = "ra_Beam_Touch_Window_L_L";
            this.ra_Beam_Touch_Window_L_L.Size = new System.Drawing.Size(172, 18);
            this.ra_Beam_Touch_Window_L_L.TabIndex = 1;
            this.ra_Beam_Touch_Window_L_L.TabStop = true;
            this.ra_Beam_Touch_Window_L_L.Text = "Beam_Touch_Window_L_L";
            this.ra_Beam_Touch_Window_L_L.UseVisualStyleBackColor = false;
            this.ra_Beam_Touch_Window_L_L.CheckedChanged += new System.EventHandler(this.ra_Beam_Touch_Window_L_L_CheckedChanged);
            // 
            // groupBoxTongji
            // 
            this.groupBoxTongji.Controls.Add(this.BtnWave);
            this.groupBoxTongji.Controls.Add(this.btnSave);
            this.groupBoxTongji.Controls.Add(this.lbl_DO_OKNG);
            this.groupBoxTongji.Controls.Add(this.lbl_RAF_OKNG);
            this.groupBoxTongji.Controls.Add(this.label12);
            this.groupBoxTongji.Controls.Add(this.label11);
            this.groupBoxTongji.Controls.Add(this.btnDO_Clear);
            this.groupBoxTongji.Controls.Add(this.lblFailNum_DO);
            this.groupBoxTongji.Controls.Add(this.label6);
            this.groupBoxTongji.Controls.Add(this.lblPassNum_DO);
            this.groupBoxTongji.Controls.Add(this.label8);
            this.groupBoxTongji.Controls.Add(this.lblTotalNum_DO);
            this.groupBoxTongji.Controls.Add(this.label10);
            this.groupBoxTongji.Controls.Add(this.label2);
            this.groupBoxTongji.Controls.Add(this.cbxProgramSelect);
            this.groupBoxTongji.Controls.Add(this.chbxSaveImage);
            this.groupBoxTongji.Controls.Add(this.btnClear);
            this.groupBoxTongji.Controls.Add(this.lblFailNum_RAF);
            this.groupBoxTongji.Controls.Add(this.label5);
            this.groupBoxTongji.Controls.Add(this.lblPassNum_RAF);
            this.groupBoxTongji.Controls.Add(this.label3);
            this.groupBoxTongji.Controls.Add(this.lblTotalNum_RAF);
            this.groupBoxTongji.Controls.Add(this.label1);
            this.groupBoxTongji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTongji.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTongji.Name = "groupBoxTongji";
            this.groupBoxTongji.Size = new System.Drawing.Size(983, 145);
            this.groupBoxTongji.TabIndex = 12;
            this.groupBoxTongji.TabStop = false;
            this.groupBoxTongji.Text = "统计";
            // 
            // BtnWave
            // 
            this.BtnWave.Location = new System.Drawing.Point(742, 78);
            this.BtnWave.Name = "BtnWave";
            this.BtnWave.Size = new System.Drawing.Size(75, 23);
            this.BtnWave.TabIndex = 24;
            this.BtnWave.Text = "波动图";
            this.BtnWave.UseVisualStyleBackColor = true;
            this.BtnWave.Click += new System.EventHandler(this.BtnWave_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(823, 76);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl_DO_OKNG
            // 
            this.lbl_DO_OKNG.AutoSize = true;
            this.lbl_DO_OKNG.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DO_OKNG.Location = new System.Drawing.Point(391, 52);
            this.lbl_DO_OKNG.Name = "lbl_DO_OKNG";
            this.lbl_DO_OKNG.Size = new System.Drawing.Size(29, 19);
            this.lbl_DO_OKNG.TabIndex = 22;
            this.lbl_DO_OKNG.Text = "OK";
            // 
            // lbl_RAF_OKNG
            // 
            this.lbl_RAF_OKNG.AutoSize = true;
            this.lbl_RAF_OKNG.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_RAF_OKNG.Location = new System.Drawing.Point(5, 52);
            this.lbl_RAF_OKNG.Name = "lbl_RAF_OKNG";
            this.lbl_RAF_OKNG.Size = new System.Drawing.Size(29, 19);
            this.lbl_RAF_OKNG.TabIndex = 21;
            this.lbl_RAF_OKNG.Text = "OK";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(391, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "DO：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(4, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "RAF：";
            // 
            // btnDO_Clear
            // 
            this.btnDO_Clear.Location = new System.Drawing.Point(641, 34);
            this.btnDO_Clear.Name = "btnDO_Clear";
            this.btnDO_Clear.Size = new System.Drawing.Size(92, 50);
            this.btnDO_Clear.TabIndex = 18;
            this.btnDO_Clear.Text = "清零";
            this.btnDO_Clear.UseVisualStyleBackColor = true;
            this.btnDO_Clear.Click += new System.EventHandler(this.btnDO_Clear_Click);
            // 
            // lblFailNum_DO
            // 
            this.lblFailNum_DO.AutoSize = true;
            this.lblFailNum_DO.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFailNum_DO.Location = new System.Drawing.Point(549, 95);
            this.lblFailNum_DO.Name = "lblFailNum_DO";
            this.lblFailNum_DO.Size = new System.Drawing.Size(19, 20);
            this.lblFailNum_DO.TabIndex = 17;
            this.lblFailNum_DO.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(460, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fail：";
            // 
            // lblPassNum_DO
            // 
            this.lblPassNum_DO.AutoSize = true;
            this.lblPassNum_DO.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassNum_DO.Location = new System.Drawing.Point(549, 62);
            this.lblPassNum_DO.Name = "lblPassNum_DO";
            this.lblPassNum_DO.Size = new System.Drawing.Size(19, 20);
            this.lblPassNum_DO.TabIndex = 15;
            this.lblPassNum_DO.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(460, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pass：";
            // 
            // lblTotalNum_DO
            // 
            this.lblTotalNum_DO.AutoSize = true;
            this.lblTotalNum_DO.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalNum_DO.Location = new System.Drawing.Point(549, 32);
            this.lblTotalNum_DO.Name = "lblTotalNum_DO";
            this.lblTotalNum_DO.Size = new System.Drawing.Size(19, 20);
            this.lblTotalNum_DO.TabIndex = 13;
            this.lblTotalNum_DO.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(460, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(763, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "切换程序";
            // 
            // cbxProgramSelect
            // 
            this.cbxProgramSelect.FormattingEnabled = true;
            this.cbxProgramSelect.Items.AddRange(new object[] {
            "12PR-RAF",
            "8PR-DO"});
            this.cbxProgramSelect.Location = new System.Drawing.Point(767, 50);
            this.cbxProgramSelect.Name = "cbxProgramSelect";
            this.cbxProgramSelect.Size = new System.Drawing.Size(124, 20);
            this.cbxProgramSelect.TabIndex = 10;
            this.cbxProgramSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chbxSaveImage
            // 
            this.chbxSaveImage.AutoSize = true;
            this.chbxSaveImage.Location = new System.Drawing.Point(943, 52);
            this.chbxSaveImage.Name = "chbxSaveImage";
            this.chbxSaveImage.Size = new System.Drawing.Size(72, 16);
            this.chbxSaveImage.TabIndex = 9;
            this.chbxSaveImage.Text = "保存图像";
            this.chbxSaveImage.UseVisualStyleBackColor = true;
            this.chbxSaveImage.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(246, 34);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 50);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清零";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFailNum_RAF
            // 
            this.lblFailNum_RAF.AutoSize = true;
            this.lblFailNum_RAF.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFailNum_RAF.Location = new System.Drawing.Point(154, 95);
            this.lblFailNum_RAF.Name = "lblFailNum_RAF";
            this.lblFailNum_RAF.Size = new System.Drawing.Size(19, 20);
            this.lblFailNum_RAF.TabIndex = 6;
            this.lblFailNum_RAF.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(65, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fail：";
            // 
            // lblPassNum_RAF
            // 
            this.lblPassNum_RAF.AutoSize = true;
            this.lblPassNum_RAF.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassNum_RAF.Location = new System.Drawing.Point(154, 62);
            this.lblPassNum_RAF.Name = "lblPassNum_RAF";
            this.lblPassNum_RAF.Size = new System.Drawing.Size(19, 20);
            this.lblPassNum_RAF.TabIndex = 4;
            this.lblPassNum_RAF.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(65, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pass：";
            // 
            // lblTotalNum_RAF
            // 
            this.lblTotalNum_RAF.AutoSize = true;
            this.lblTotalNum_RAF.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalNum_RAF.Location = new System.Drawing.Point(154, 32);
            this.lblTotalNum_RAF.Name = "lblTotalNum_RAF";
            this.lblTotalNum_RAF.Size = new System.Drawing.Size(19, 20);
            this.lblTotalNum_RAF.TabIndex = 2;
            this.lblTotalNum_RAF.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total：";
            // 
            // tblImageAndControl
            // 
            this.tblImageAndControl.ColumnCount = 1;
            this.tblImageAndControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblImageAndControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblImageAndControl.Controls.Add(this.groupBox2, 0, 1);
            this.tblImageAndControl.Controls.Add(this.groupBox_Image, 0, 0);
            this.tblImageAndControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblImageAndControl.Location = new System.Drawing.Point(3, 3);
            this.tblImageAndControl.Name = "tblImageAndControl";
            this.tblImageAndControl.RowCount = 2;
            this.tblImageAndControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblImageAndControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblImageAndControl.Size = new System.Drawing.Size(355, 759);
            this.tblImageAndControl.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customerLights1);
            this.groupBox2.Controls.Add(this.light_History);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxHistoryData);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lblStatusShow);
            this.groupBox2.Controls.Add(this.txtTime);
            this.groupBox2.Controls.Add(this.btnRunOnce);
            this.groupBox2.Controls.Add(this.btnCurrentImageRun);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 374);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运行";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F);
            this.label4.Location = new System.Drawing.Point(39, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "缓存";
            // 
            // cbxHistoryData
            // 
            this.cbxHistoryData.FormattingEnabled = true;
            this.cbxHistoryData.Items.AddRange(new object[] {
            "12PR-RAF",
            "8PR-DO"});
            this.cbxHistoryData.Location = new System.Drawing.Point(203, 334);
            this.cbxHistoryData.Name = "cbxHistoryData";
            this.cbxHistoryData.Size = new System.Drawing.Size(124, 20);
            this.cbxHistoryData.TabIndex = 19;
            this.cbxHistoryData.SelectedIndexChanged += new System.EventHandler(this.cbxHistoryData_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 18;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 17;
            this.textBox1.Visible = false;
            // 
            // lblStatusShow
            // 
            this.lblStatusShow.AutoSize = true;
            this.lblStatusShow.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatusShow.Location = new System.Drawing.Point(39, 94);
            this.lblStatusShow.Name = "lblStatusShow";
            this.lblStatusShow.Size = new System.Drawing.Size(130, 24);
            this.lblStatusShow.TabIndex = 16;
            this.lblStatusShow.Text = "未开始检测";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(227, 29);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 9;
            // 
            // groupBox_Image
            // 
            this.groupBox_Image.Controls.Add(this.tabControlImage);
            this.groupBox_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Image.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Image.Name = "groupBox_Image";
            this.groupBox_Image.Size = new System.Drawing.Size(349, 373);
            this.groupBox_Image.TabIndex = 0;
            this.groupBox_Image.TabStop = false;
            this.groupBox_Image.Text = "图像";
            // 
            // tabControlImage
            // 
            this.tabControlImage.Controls.Add(this.tapaResultImage1);
            this.tabControlImage.Controls.Add(this.tapaResultImage2);
            this.tabControlImage.Controls.Add(this.tapaRowImage1);
            this.tabControlImage.Controls.Add(this.tapaRowImage2);
            this.tabControlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlImage.Location = new System.Drawing.Point(3, 17);
            this.tabControlImage.Name = "tabControlImage";
            this.tabControlImage.SelectedIndex = 0;
            this.tabControlImage.Size = new System.Drawing.Size(343, 353);
            this.tabControlImage.TabIndex = 0;
            // 
            // tapaResultImage1
            // 
            this.tapaResultImage1.Controls.Add(this.mDisplay1Result);
            this.tapaResultImage1.Location = new System.Drawing.Point(4, 22);
            this.tapaResultImage1.Name = "tapaResultImage1";
            this.tapaResultImage1.Padding = new System.Windows.Forms.Padding(3);
            this.tapaResultImage1.Size = new System.Drawing.Size(335, 327);
            this.tapaResultImage1.TabIndex = 0;
            this.tapaResultImage1.Text = "1号图像";
            this.tapaResultImage1.UseVisualStyleBackColor = true;
            // 
            // mDisplay1Result
            // 
            this.mDisplay1Result.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.mDisplay1Result.ColorMapLowerRoiLimit = 0D;
            this.mDisplay1Result.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.mDisplay1Result.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.mDisplay1Result.ColorMapUpperRoiLimit = 1D;
            this.mDisplay1Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDisplay1Result.Location = new System.Drawing.Point(3, 3);
            this.mDisplay1Result.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.mDisplay1Result.MouseWheelSensitivity = 1D;
            this.mDisplay1Result.Name = "mDisplay1Result";
            this.mDisplay1Result.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mDisplay1Result.OcxState")));
            this.mDisplay1Result.Size = new System.Drawing.Size(329, 321);
            this.mDisplay1Result.TabIndex = 1;
            // 
            // tapaResultImage2
            // 
            this.tapaResultImage2.Controls.Add(this.mDisplay2Result);
            this.tapaResultImage2.Location = new System.Drawing.Point(4, 22);
            this.tapaResultImage2.Name = "tapaResultImage2";
            this.tapaResultImage2.Padding = new System.Windows.Forms.Padding(3);
            this.tapaResultImage2.Size = new System.Drawing.Size(335, 327);
            this.tapaResultImage2.TabIndex = 1;
            this.tapaResultImage2.Text = "2号图像";
            this.tapaResultImage2.UseVisualStyleBackColor = true;
            // 
            // mDisplay2Result
            // 
            this.mDisplay2Result.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.mDisplay2Result.ColorMapLowerRoiLimit = 0D;
            this.mDisplay2Result.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.mDisplay2Result.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.mDisplay2Result.ColorMapUpperRoiLimit = 1D;
            this.mDisplay2Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDisplay2Result.Location = new System.Drawing.Point(3, 3);
            this.mDisplay2Result.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.mDisplay2Result.MouseWheelSensitivity = 1D;
            this.mDisplay2Result.Name = "mDisplay2Result";
            this.mDisplay2Result.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mDisplay2Result.OcxState")));
            this.mDisplay2Result.Size = new System.Drawing.Size(329, 321);
            this.mDisplay2Result.TabIndex = 2;
            // 
            // tapaRowImage1
            // 
            this.tapaRowImage1.Controls.Add(this.mDisplay1Row);
            this.tapaRowImage1.Location = new System.Drawing.Point(4, 22);
            this.tapaRowImage1.Name = "tapaRowImage1";
            this.tapaRowImage1.Size = new System.Drawing.Size(335, 327);
            this.tapaRowImage1.TabIndex = 2;
            this.tapaRowImage1.Text = "1号原始图像";
            this.tapaRowImage1.UseVisualStyleBackColor = true;
            // 
            // mDisplay1Row
            // 
            this.mDisplay1Row.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.mDisplay1Row.ColorMapLowerRoiLimit = 0D;
            this.mDisplay1Row.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.mDisplay1Row.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.mDisplay1Row.ColorMapUpperRoiLimit = 1D;
            this.mDisplay1Row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDisplay1Row.Location = new System.Drawing.Point(0, 0);
            this.mDisplay1Row.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.mDisplay1Row.MouseWheelSensitivity = 1D;
            this.mDisplay1Row.Name = "mDisplay1Row";
            this.mDisplay1Row.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mDisplay1Row.OcxState")));
            this.mDisplay1Row.Size = new System.Drawing.Size(335, 327);
            this.mDisplay1Row.TabIndex = 6;
            // 
            // tapaRowImage2
            // 
            this.tapaRowImage2.Controls.Add(this.mDisplay2Row);
            this.tapaRowImage2.Location = new System.Drawing.Point(4, 22);
            this.tapaRowImage2.Name = "tapaRowImage2";
            this.tapaRowImage2.Size = new System.Drawing.Size(335, 327);
            this.tapaRowImage2.TabIndex = 3;
            this.tapaRowImage2.Text = "2号原始图像";
            this.tapaRowImage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.相机ToolStripMenuItem,
            this.程序参数ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 相机ToolStripMenuItem
            // 
            this.相机ToolStripMenuItem.Name = "相机ToolStripMenuItem";
            this.相机ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.相机ToolStripMenuItem.Text = "相机参数";
            this.相机ToolStripMenuItem.Click += new System.EventHandler(this.相机ToolStripMenuItem_Click);
            // 
            // 程序参数ToolStripMenuItem
            // 
            this.程序参数ToolStripMenuItem.Name = "程序参数ToolStripMenuItem";
            this.程序参数ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.程序参数ToolStripMenuItem.Text = "程序参数";
            this.程序参数ToolStripMenuItem.Visible = false;
            this.程序参数ToolStripMenuItem.Click += new System.EventHandler(this.程序参数ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_child_static_message,
            this.status_child_Camera_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 822);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "status_information";
            // 
            // status_child_static_message
            // 
            this.status_child_static_message.Name = "status_child_static_message";
            this.status_child_static_message.Size = new System.Drawing.Size(107, 17);
            this.status_child_static_message.Text = "相机连接状态:      ";
            // 
            // status_child_Camera_status
            // 
            this.status_child_Camera_status.Name = "status_child_Camera_status";
            this.status_child_Camera_status.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox_Display_max
            // 
            this.groupBox_Display_max.Controls.Add(this.tbll_Max_TwoDisplay);
            this.groupBox_Display_max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Display_max.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Display_max.Name = "groupBox_Display_max";
            this.groupBox_Display_max.Size = new System.Drawing.Size(1123, 759);
            this.groupBox_Display_max.TabIndex = 12;
            this.groupBox_Display_max.TabStop = false;
            this.groupBox_Display_max.Text = "图像";
            // 
            // tbll_Max_TwoDisplay
            // 
            this.tbll_Max_TwoDisplay.ColumnCount = 2;
            this.tbll_Max_TwoDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.82274F));
            this.tbll_Max_TwoDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.17726F));
            this.tbll_Max_TwoDisplay.Controls.Add(this.tabControl2, 1, 0);
            this.tbll_Max_TwoDisplay.Controls.Add(this.tabControl1, 0, 0);
            this.tbll_Max_TwoDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbll_Max_TwoDisplay.Location = new System.Drawing.Point(3, 17);
            this.tbll_Max_TwoDisplay.Name = "tbll_Max_TwoDisplay";
            this.tbll_Max_TwoDisplay.RowCount = 1;
            this.tbll_Max_TwoDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbll_Max_TwoDisplay.Size = new System.Drawing.Size(1117, 739);
            this.tbll_Max_TwoDisplay.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(1050, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(64, 733);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.mDisplay2ResultShow);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(56, 707);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "2号图像";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // mDisplay2ResultShow
            // 
            this.mDisplay2ResultShow.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.mDisplay2ResultShow.ColorMapLowerRoiLimit = 0D;
            this.mDisplay2ResultShow.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.mDisplay2ResultShow.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.mDisplay2ResultShow.ColorMapUpperRoiLimit = 1D;
            this.mDisplay2ResultShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDisplay2ResultShow.Location = new System.Drawing.Point(3, 3);
            this.mDisplay2ResultShow.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.mDisplay2ResultShow.MouseWheelSensitivity = 1D;
            this.mDisplay2ResultShow.Name = "mDisplay2ResultShow";
            this.mDisplay2ResultShow.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mDisplay2ResultShow.OcxState")));
            this.mDisplay2ResultShow.Size = new System.Drawing.Size(50, 701);
            this.mDisplay2ResultShow.TabIndex = 2;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.mDisplay2RowShow);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(56, 707);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "2号原始图像";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // mDisplay2RowShow
            // 
            this.mDisplay2RowShow.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.mDisplay2RowShow.ColorMapLowerRoiLimit = 0D;
            this.mDisplay2RowShow.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.mDisplay2RowShow.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.mDisplay2RowShow.ColorMapUpperRoiLimit = 1D;
            this.mDisplay2RowShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDisplay2RowShow.Location = new System.Drawing.Point(0, 0);
            this.mDisplay2RowShow.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.mDisplay2RowShow.MouseWheelSensitivity = 1D;
            this.mDisplay2RowShow.Name = "mDisplay2RowShow";
            this.mDisplay2RowShow.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mDisplay2RowShow.OcxState")));
            this.mDisplay2RowShow.Size = new System.Drawing.Size(56, 707);
            this.mDisplay2RowShow.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 733);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mDisplay1ResultShow);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1033, 707);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1号图像";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mDisplay1ResultShow
            // 
            this.mDisplay1ResultShow.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.mDisplay1ResultShow.ColorMapLowerRoiLimit = 0D;
            this.mDisplay1ResultShow.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.mDisplay1ResultShow.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.mDisplay1ResultShow.ColorMapUpperRoiLimit = 1D;
            this.mDisplay1ResultShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDisplay1ResultShow.Location = new System.Drawing.Point(3, 3);
            this.mDisplay1ResultShow.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.mDisplay1ResultShow.MouseWheelSensitivity = 1D;
            this.mDisplay1ResultShow.Name = "mDisplay1ResultShow";
            this.mDisplay1ResultShow.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mDisplay1ResultShow.OcxState")));
            this.mDisplay1ResultShow.Size = new System.Drawing.Size(1027, 701);
            this.mDisplay1ResultShow.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mDisplay1RowShow);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1033, 707);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "1号原始图像";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // mDisplay1RowShow
            // 
            this.mDisplay1RowShow.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.mDisplay1RowShow.ColorMapLowerRoiLimit = 0D;
            this.mDisplay1RowShow.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.mDisplay1RowShow.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.mDisplay1RowShow.ColorMapUpperRoiLimit = 1D;
            this.mDisplay1RowShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDisplay1RowShow.Location = new System.Drawing.Point(0, 0);
            this.mDisplay1RowShow.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.mDisplay1RowShow.MouseWheelSensitivity = 1D;
            this.mDisplay1RowShow.Name = "mDisplay1RowShow";
            this.mDisplay1RowShow.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mDisplay1RowShow.OcxState")));
            this.mDisplay1RowShow.Size = new System.Drawing.Size(1033, 707);
            this.mDisplay1RowShow.TabIndex = 6;
            // 
            // tabControl_Main_all
            // 
            this.tabControl_Main_all.Controls.Add(this.tab_Measure);
            this.tabControl_Main_all.Controls.Add(this.tab_Display);
            this.tabControl_Main_all.Controls.Add(this.tab_RAF);
            this.tabControl_Main_all.Controls.Add(this.tab_DO);
            this.tabControl_Main_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main_all.Location = new System.Drawing.Point(0, 25);
            this.tabControl_Main_all.Name = "tabControl_Main_all";
            this.tabControl_Main_all.SelectedIndex = 0;
            this.tabControl_Main_all.Size = new System.Drawing.Size(1370, 797);
            this.tabControl_Main_all.TabIndex = 13;
            // 
            // tab_Measure
            // 
            this.tab_Measure.Controls.Add(this.tblMain);
            this.tab_Measure.Location = new System.Drawing.Point(4, 22);
            this.tab_Measure.Name = "tab_Measure";
            this.tab_Measure.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Measure.Size = new System.Drawing.Size(1362, 771);
            this.tab_Measure.TabIndex = 0;
            this.tab_Measure.Text = "检测";
            this.tab_Measure.UseVisualStyleBackColor = true;
            // 
            // tab_Display
            // 
            this.tab_Display.Controls.Add(this.tbll_Display_max);
            this.tab_Display.Location = new System.Drawing.Point(4, 22);
            this.tab_Display.Name = "tab_Display";
            this.tab_Display.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Display.Size = new System.Drawing.Size(1362, 771);
            this.tab_Display.TabIndex = 1;
            this.tab_Display.Text = "显示";
            this.tab_Display.UseVisualStyleBackColor = true;
            // 
            // tbll_Display_max
            // 
            this.tbll_Display_max.ColumnCount = 2;
            this.tbll_Display_max.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.25959F));
            this.tbll_Display_max.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.74041F));
            this.tbll_Display_max.Controls.Add(this.groupBox_Display_max, 0, 0);
            this.tbll_Display_max.Controls.Add(this.groupBox_message, 1, 0);
            this.tbll_Display_max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbll_Display_max.Location = new System.Drawing.Point(3, 3);
            this.tbll_Display_max.Name = "tbll_Display_max";
            this.tbll_Display_max.RowCount = 1;
            this.tbll_Display_max.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbll_Display_max.Size = new System.Drawing.Size(1356, 765);
            this.tbll_Display_max.TabIndex = 13;
            // 
            // groupBox_message
            // 
            this.groupBox_message.Controls.Add(this.lblStatus);
            this.groupBox_message.Controls.Add(this.txt_message);
            this.groupBox_message.Controls.Add(this.Label_max);
            this.groupBox_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_message.Location = new System.Drawing.Point(1132, 3);
            this.groupBox_message.Name = "groupBox_message";
            this.groupBox_message.Size = new System.Drawing.Size(221, 759);
            this.groupBox_message.TabIndex = 13;
            this.groupBox_message.TabStop = false;
            this.groupBox_message.Text = "信息";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.Location = new System.Drawing.Point(10, 102);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(130, 24);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "未开始检测";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(0, 165);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.ReadOnly = true;
            this.txt_message.Size = new System.Drawing.Size(191, 283);
            this.txt_message.TabIndex = 14;
            // 
            // Label_max
            // 
            this.Label_max.AutoSize = true;
            this.Label_max.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_max.Location = new System.Drawing.Point(6, 29);
            this.Label_max.Name = "Label_max";
            this.Label_max.Size = new System.Drawing.Size(123, 35);
            this.Label_max.TabIndex = 13;
            this.Label_max.Text = "label4";
            // 
            // tab_RAF
            // 
            this.tab_RAF.Controls.Add(this.cogtool_RAF);
            this.tab_RAF.Location = new System.Drawing.Point(4, 22);
            this.tab_RAF.Name = "tab_RAF";
            this.tab_RAF.Size = new System.Drawing.Size(1362, 771);
            this.tab_RAF.TabIndex = 2;
            this.tab_RAF.Text = "RAF_程序";
            this.tab_RAF.UseVisualStyleBackColor = true;
            // 
            // cogtool_RAF
            // 
            this.cogtool_RAF.AllowDrop = true;
            this.cogtool_RAF.ContextMenuCustomizer = null;
            this.cogtool_RAF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogtool_RAF.Location = new System.Drawing.Point(0, 0);
            this.cogtool_RAF.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogtool_RAF.Name = "cogtool_RAF";
            this.cogtool_RAF.ShowNodeToolTips = true;
            this.cogtool_RAF.Size = new System.Drawing.Size(1362, 771);
            this.cogtool_RAF.SuspendElectricRuns = false;
            this.cogtool_RAF.TabIndex = 3;
            // 
            // tab_DO
            // 
            this.tab_DO.Controls.Add(this.cogtool_DO);
            this.tab_DO.Location = new System.Drawing.Point(4, 22);
            this.tab_DO.Name = "tab_DO";
            this.tab_DO.Size = new System.Drawing.Size(1362, 771);
            this.tab_DO.TabIndex = 3;
            this.tab_DO.Text = "DO_程序";
            this.tab_DO.UseVisualStyleBackColor = true;
            // 
            // cogtool_DO
            // 
            this.cogtool_DO.AllowDrop = true;
            this.cogtool_DO.ContextMenuCustomizer = null;
            this.cogtool_DO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogtool_DO.Location = new System.Drawing.Point(0, 0);
            this.cogtool_DO.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogtool_DO.Name = "cogtool_DO";
            this.cogtool_DO.ShowNodeToolTips = true;
            this.cogtool_DO.Size = new System.Drawing.Size(1362, 771);
            this.cogtool_DO.SuspendElectricRuns = false;
            this.cogtool_DO.TabIndex = 2;
            // 
            // light_History
            // 
            this.light_History.LightColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Red,
        System.Drawing.Color.Red,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Aqua};
            this.light_History.LightOffCOlor = System.Drawing.Color.Black;
            this.light_History.LightOnColor = System.Drawing.Color.LimeGreen;
            this.light_History.LightStatus = 0;
            this.light_History.Location = new System.Drawing.Point(51, 205);
            this.light_History.MinimumSize = new System.Drawing.Size(70, 12);
            this.light_History.Name = "light_History";
            this.light_History.NumLight = 10;
            this.light_History.Size = new System.Drawing.Size(179, 15);
            this.light_History.TabIndex = 21;
            this.light_History.ToolTips = new string[] {
        "急停灯",
        "左转灯",
        "右转灯",
        "喇叭灯"};
            // 
            // userControlSetMaxAndMin1
            // 
            this.userControlSetMaxAndMin1.CurrentGrid = this.dataGrid_Beam_Touch_Window_L_L;
            this.userControlSetMaxAndMin1.Location = new System.Drawing.Point(578, 4);
            this.userControlSetMaxAndMin1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin1.Name = "userControlSetMaxAndMin1";
            this.userControlSetMaxAndMin1.Size = new System.Drawing.Size(164, 320);
            this.userControlSetMaxAndMin1.TabIndex = 1;
            this.userControlSetMaxAndMin1.Visible = false;
            // 
            // userControlSetMaxAndMin2
            // 
            this.userControlSetMaxAndMin2.CurrentGrid = this.dataGrid_Beam_Touch_Window_L_R;
            this.userControlSetMaxAndMin2.Location = new System.Drawing.Point(550, 4);
            this.userControlSetMaxAndMin2.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin2.Name = "userControlSetMaxAndMin2";
            this.userControlSetMaxAndMin2.Size = new System.Drawing.Size(37, 51);
            this.userControlSetMaxAndMin2.TabIndex = 1;
            this.userControlSetMaxAndMin2.Visible = false;
            // 
            // userControlSetMaxAndMin3
            // 
            this.userControlSetMaxAndMin3.CurrentGrid = this.dataGrid_Beam_Tip_To_Window_L;
            this.userControlSetMaxAndMin3.Location = new System.Drawing.Point(579, 4);
            this.userControlSetMaxAndMin3.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin3.Name = "userControlSetMaxAndMin3";
            this.userControlSetMaxAndMin3.Size = new System.Drawing.Size(32, 51);
            this.userControlSetMaxAndMin3.TabIndex = 1;
            this.userControlSetMaxAndMin3.Visible = false;
            // 
            // userControlSetMaxAndMin4
            // 
            this.userControlSetMaxAndMin4.CurrentGrid = this.dataGrid_Beam_Touch_Window_R_L;
            this.userControlSetMaxAndMin4.Location = new System.Drawing.Point(583, 4);
            this.userControlSetMaxAndMin4.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin4.Name = "userControlSetMaxAndMin4";
            this.userControlSetMaxAndMin4.Size = new System.Drawing.Size(31, 51);
            this.userControlSetMaxAndMin4.TabIndex = 1;
            this.userControlSetMaxAndMin4.Visible = false;
            // 
            // userControlSetMaxAndMin5
            // 
            this.userControlSetMaxAndMin5.CurrentGrid = this.dataGrid_Beam_Touch_Window_R_R;
            this.userControlSetMaxAndMin5.Location = new System.Drawing.Point(575, 4);
            this.userControlSetMaxAndMin5.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin5.Name = "userControlSetMaxAndMin5";
            this.userControlSetMaxAndMin5.Size = new System.Drawing.Size(32, 51);
            this.userControlSetMaxAndMin5.TabIndex = 1;
            this.userControlSetMaxAndMin5.Visible = false;
            // 
            // userControlSetMaxAndMin6
            // 
            this.userControlSetMaxAndMin6.CurrentGrid = this.dataGrid_Beam_Tip_To_Window_R;
            this.userControlSetMaxAndMin6.Location = new System.Drawing.Point(572, 4);
            this.userControlSetMaxAndMin6.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin6.Name = "userControlSetMaxAndMin6";
            this.userControlSetMaxAndMin6.Size = new System.Drawing.Size(33, 51);
            this.userControlSetMaxAndMin6.TabIndex = 1;
            this.userControlSetMaxAndMin6.Visible = false;
            // 
            // userControlSetMaxAndMin7
            // 
            this.userControlSetMaxAndMin7.CurrentGrid = this.dataGrid_Beam_Height_Difference;
            this.userControlSetMaxAndMin7.Location = new System.Drawing.Point(586, 4);
            this.userControlSetMaxAndMin7.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin7.Name = "userControlSetMaxAndMin7";
            this.userControlSetMaxAndMin7.Size = new System.Drawing.Size(31, 51);
            this.userControlSetMaxAndMin7.TabIndex = 1;
            this.userControlSetMaxAndMin7.Visible = false;
            // 
            // userControlSetMaxAndMin8
            // 
            this.userControlSetMaxAndMin8.CurrentGrid = this.dataGrid_Shield_Flatness;
            this.userControlSetMaxAndMin8.Location = new System.Drawing.Point(591, 4);
            this.userControlSetMaxAndMin8.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin8.Name = "userControlSetMaxAndMin8";
            this.userControlSetMaxAndMin8.Size = new System.Drawing.Size(29, 51);
            this.userControlSetMaxAndMin8.TabIndex = 1;
            this.userControlSetMaxAndMin8.Visible = false;
            // 
            // userControlSetMaxAndMin9
            // 
            this.userControlSetMaxAndMin9.CurrentGrid = this.dataGrid_Cross_Shield_TP;
            this.userControlSetMaxAndMin9.Location = new System.Drawing.Point(575, 4);
            this.userControlSetMaxAndMin9.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin9.Name = "userControlSetMaxAndMin9";
            this.userControlSetMaxAndMin9.Size = new System.Drawing.Size(32, 51);
            this.userControlSetMaxAndMin9.TabIndex = 1;
            this.userControlSetMaxAndMin9.Visible = false;
            // 
            // userControlSetMaxAndMin10
            // 
            this.userControlSetMaxAndMin10.CurrentGrid = this.dataGrid_Wafer_Thickness;
            this.userControlSetMaxAndMin10.Location = new System.Drawing.Point(588, 4);
            this.userControlSetMaxAndMin10.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin10.Name = "userControlSetMaxAndMin10";
            this.userControlSetMaxAndMin10.Size = new System.Drawing.Size(30, 51);
            this.userControlSetMaxAndMin10.TabIndex = 1;
            this.userControlSetMaxAndMin10.Visible = false;
            // 
            // userControlSetMaxAndMin11
            // 
            this.userControlSetMaxAndMin11.CurrentGrid = this.dataGrid_Shield_Cross_Angle;
            this.userControlSetMaxAndMin11.Location = new System.Drawing.Point(578, 4);
            this.userControlSetMaxAndMin11.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin11.Name = "userControlSetMaxAndMin11";
            this.userControlSetMaxAndMin11.Size = new System.Drawing.Size(32, 51);
            this.userControlSetMaxAndMin11.TabIndex = 1;
            this.userControlSetMaxAndMin11.Visible = false;
            // 
            // userControlSetMaxAndMin12
            // 
            this.userControlSetMaxAndMin12.CurrentGrid = this.dataGrid_Beam_Height_L;
            this.userControlSetMaxAndMin12.Location = new System.Drawing.Point(600, 4);
            this.userControlSetMaxAndMin12.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin12.Name = "userControlSetMaxAndMin12";
            this.userControlSetMaxAndMin12.Size = new System.Drawing.Size(28, 51);
            this.userControlSetMaxAndMin12.TabIndex = 1;
            this.userControlSetMaxAndMin12.Visible = false;
            // 
            // userControlSetMaxAndMin13
            // 
            this.userControlSetMaxAndMin13.CurrentGrid = this.dataGrid_Beam_Height_R;
            this.userControlSetMaxAndMin13.Location = new System.Drawing.Point(578, 4);
            this.userControlSetMaxAndMin13.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetMaxAndMin13.Name = "userControlSetMaxAndMin13";
            this.userControlSetMaxAndMin13.Size = new System.Drawing.Size(32, 51);
            this.userControlSetMaxAndMin13.TabIndex = 1;
            this.userControlSetMaxAndMin13.Visible = false;
            // 
            // customerLights1
            // 
            this.customerLights1.LightCount = 2;
            this.customerLights1.LightLength = 5;
            this.customerLights1.LightRadius = 20;
            this.customerLights1.Location = new System.Drawing.Point(27, 226);
            this.customerLights1.Name = "customerLights1";
            this.customerLights1.Size = new System.Drawing.Size(264, 62);
            this.customerLights1.TabIndex = 22;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 844);
            this.Controls.Add(this.tabControl_Main_all);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "华为5g检测";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay2Row)).EndInit();
            this.tblMain.ResumeLayout(false);
            this.tblParametersAndResultShow.ResumeLayout(false);
            this.group_main.ResumeLayout(false);
            this.tblMain2.ResumeLayout(false);
            this.tabControl_Main.ResumeLayout(false);
            this.tab_Beam_Touch_Window_L_L.ResumeLayout(false);
            this.tbll_bll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Touch_Window_L_L)).EndInit();
            this.tab_Beam_Touch_Window_L_R.ResumeLayout(false);
            this.tbll_lr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Touch_Window_L_R)).EndInit();
            this.tab_Beam_Tip_To_Window_L.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Tip_To_Window_L)).EndInit();
            this.tab_Beam_Touch_Window_R_L.ResumeLayout(false);
            this.tbll_l.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Touch_Window_R_L)).EndInit();
            this.tab_Beam_Touch_Window_R_R.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Touch_Window_R_R)).EndInit();
            this.tab_Beam_Tip_To_Window_R.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Tip_To_Window_R)).EndInit();
            this.tab_Beam_Height_Difference.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Height_Difference)).EndInit();
            this.tab_Shield_Flatness.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Shield_Flatness)).EndInit();
            this.tab_Cross_Shield_TP.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Cross_Shield_TP)).EndInit();
            this.tab_Wafer_Thickness.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Wafer_Thickness)).EndInit();
            this.tab_Shield_Cross_Angle.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Shield_Cross_Angle)).EndInit();
            this.tab_Beam_Height_L.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Height_L)).EndInit();
            this.tab_Beam_Height_R.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Height_R)).EndInit();
            this.tab_Beam_Inner_L.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Inner_L)).EndInit();
            this.tab_Beam_Inner_R.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Beam_Inner_R)).EndInit();
            this.tab_TiePian.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_TiePian)).EndInit();
            this.palSelectMeasure.ResumeLayout(false);
            this.palSelectMeasure.PerformLayout();
            this.groupBoxTongji.ResumeLayout(false);
            this.groupBoxTongji.PerformLayout();
            this.tblImageAndControl.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Image.ResumeLayout(false);
            this.tabControlImage.ResumeLayout(false);
            this.tapaResultImage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay1Result)).EndInit();
            this.tapaResultImage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay2Result)).EndInit();
            this.tapaRowImage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay1Row)).EndInit();
            this.tapaRowImage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_Display_max.ResumeLayout(false);
            this.tbll_Max_TwoDisplay.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay2ResultShow)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay2RowShow)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay1ResultShow)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDisplay1RowShow)).EndInit();
            this.tabControl_Main_all.ResumeLayout(false);
            this.tab_Measure.ResumeLayout(false);
            this.tab_Display.ResumeLayout(false);
            this.tbll_Display_max.ResumeLayout(false);
            this.groupBox_message.ResumeLayout(false);
            this.groupBox_message.PerformLayout();
            this.tab_RAF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogtool_RAF)).EndInit();
            this.tab_DO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogtool_DO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal Cognex.VisionPro.Display.CogDisplay mDisplay2Row;

       
        private System.Windows.Forms.Button btnRunOnce;
        private System.Windows.Forms.Button btnCurrentImageRun;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.GroupBox group_main;
        private System.Windows.Forms.TableLayoutPanel tblImageAndControl;
        private System.Windows.Forms.GroupBox groupBox_Image;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl_Main;
        internal Cognex.VisionPro.Display.CogDisplay mDisplay1Row;
        private System.Windows.Forms.TextBox txtTime;
        private CogRecordDisplay mDisplay1Result;
        private System.Windows.Forms.TabPage tab_Beam_Touch_Window_L_L;
        private System.Windows.Forms.DataGridView dataGrid_Beam_Touch_Window_L_L;
        private System.Windows.Forms.RadioButton ra_Beam_Touch_Window_L_R;
        private System.Windows.Forms.RadioButton ra_Beam_Touch_Window_L_L;
        private System.Windows.Forms.TableLayoutPanel tblMain2;
        private System.Windows.Forms.Panel palSelectMeasure;
        private System.Windows.Forms.RadioButton ra_Beam_Touch_Window_R_L;
        private System.Windows.Forms.RadioButton ra_Beam_Tip_To_Window_L;
        private System.Windows.Forms.TabPage tab_Beam_Touch_Window_L_R;
        private System.Windows.Forms.TabPage tab_Beam_Tip_To_Window_L;
        private System.Windows.Forms.TabPage tab_Beam_Touch_Window_R_L;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 相机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 程序参数ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_child_static_message;
        private System.Windows.Forms.ToolStripStatusLabel status_child_Camera_status;
        private System.Windows.Forms.TabControl tabControlImage;
        private System.Windows.Forms.TabPage tapaResultImage1;
        private System.Windows.Forms.TabPage tapaResultImage2;
        private CogRecordDisplay mDisplay2Result;
        private System.Windows.Forms.TabPage tapaRowImage1;
        private System.Windows.Forms.TabPage tapaRowImage2;
        private System.Windows.Forms.TableLayoutPanel tblParametersAndResultShow;
        private System.Windows.Forms.GroupBox groupBoxTongji;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFailNum_RAF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPassNum_RAF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalNum_RAF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbxSaveImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProgramSelect;
        private System.Windows.Forms.Button btnDO_Clear;
        private System.Windows.Forms.Label lblFailNum_DO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPassNum_DO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalNum_DO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton ra_Wafer_Thickness;
        private System.Windows.Forms.RadioButton ra_Cross_Shield_TP;
        private System.Windows.Forms.RadioButton ra_Shield_Flatness;
        private System.Windows.Forms.RadioButton ra_Beam_Height_Difference;
        private System.Windows.Forms.RadioButton ra_Beam_Tip_To_Window_R;
        private System.Windows.Forms.RadioButton ra_Beam_Touch_Window_R_R;
        private System.Windows.Forms.TabPage tab_Beam_Touch_Window_R_R;
        private System.Windows.Forms.TabPage tab_Beam_Tip_To_Window_R;
        private System.Windows.Forms.TabPage tab_Beam_Height_Difference;
        private System.Windows.Forms.TabPage tab_Shield_Flatness;
        private System.Windows.Forms.TabPage tab_Cross_Shield_TP;
        private System.Windows.Forms.TabPage tab_Wafer_Thickness;
        private System.Windows.Forms.DataGridView dataGrid_Beam_Touch_Window_L_R;
        private System.Windows.Forms.DataGridView dataGrid_Beam_Tip_To_Window_L;
        private System.Windows.Forms.DataGridView dataGrid_Beam_Touch_Window_R_L;
        private System.Windows.Forms.DataGridView dataGrid_Beam_Touch_Window_R_R;
        private System.Windows.Forms.DataGridView dataGrid_Beam_Tip_To_Window_R;
        private System.Windows.Forms.DataGridView dataGrid_Beam_Height_Difference;
        private System.Windows.Forms.DataGridView dataGrid_Shield_Flatness;
        private System.Windows.Forms.DataGridView dataGrid_Cross_Shield_TP;
        private System.Windows.Forms.DataGridView dataGrid_Wafer_Thickness;
        private System.Windows.Forms.RadioButton ra_Shield_Cross_Angle;
        private System.Windows.Forms.TabPage tab_Shield_Cross_Angle;
        private System.Windows.Forms.DataGridView dataGrid_Shield_Cross_Angle;
        private System.Windows.Forms.TabPage tab_Beam_Height_L;
        private System.Windows.Forms.DataGridView dataGrid_Beam_Height_L;
        private System.Windows.Forms.TabPage tab_Beam_Height_R;
        private System.Windows.Forms.DataGridView dataGrid_Beam_Height_R;
        private System.Windows.Forms.RadioButton ra_Beam_Height_L;
        private System.Windows.Forms.RadioButton ra_Beam_Height_R;
        private System.Windows.Forms.Label lbl_DO_OKNG;
        private System.Windows.Forms.Label lbl_RAF_OKNG;
        private System.Windows.Forms.GroupBox groupBox_Display_max;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private CogRecordDisplay mDisplay1ResultShow;
        private System.Windows.Forms.TabPage tabPage3;
        internal Cognex.VisionPro.Display.CogDisplay mDisplay1RowShow;
        private System.Windows.Forms.TabControl tabControl_Main_all;
        private System.Windows.Forms.TabPage tab_Measure;
        private System.Windows.Forms.TabPage tab_Display;
        private System.Windows.Forms.TableLayoutPanel tbll_bll;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin1;
        private System.Windows.Forms.TableLayoutPanel tbll_lr;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin3;
        private System.Windows.Forms.TableLayoutPanel tbll_l;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private CustomerUserControl.UserControlSetMaxAndMin userControlSetMaxAndMin13;
        private System.Windows.Forms.TableLayoutPanel tbll_Display_max;
        private System.Windows.Forms.Label Label_max;
        private System.Windows.Forms.GroupBox groupBox_message;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.TableLayoutPanel tbll_Max_TwoDisplay;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private CogRecordDisplay mDisplay2ResultShow;
        private System.Windows.Forms.TabPage tabPage8;
        internal Cognex.VisionPro.Display.CogDisplay mDisplay2RowShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tab_RAF;
        private System.Windows.Forms.TabPage tab_DO;
        private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogtool_DO;
        private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogtool_RAF;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton ra_Beam_Inner_L;
        private System.Windows.Forms.RadioButton ra_Beam_Inner_R;
        private System.Windows.Forms.TabPage tab_Beam_Inner_L;
        private System.Windows.Forms.DataGridView dataGrid_Beam_Inner_L;
        private System.Windows.Forms.TabPage tab_Beam_Inner_R;
        private System.Windows.Forms.DataGridView dataGrid_Beam_Inner_R;
        private System.Windows.Forms.Label lblStatusShow;
        private System.Windows.Forms.TabPage tab_TiePian;
        private System.Windows.Forms.DataGridView dataGrid_TiePian;
        private System.Windows.Forms.RadioButton ra_TiePian;
        private System.Windows.Forms.Button BtnWave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxHistoryData;
        private Net.FlyingWind.Tools.LightIndicator light_History;
        private CustomerUserControl.CustomerLights customerLights1;
    }
}

