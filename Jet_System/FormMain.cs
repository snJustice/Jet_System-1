
/*
Configure\RAF 
？？？？？？？？？？？？？bieba
15.56xiugaile sha 
 RAF
 efefefefefefeffe918
 Angle.csv
 Beam_Difference.csv
 Beam_L.csv
 Beam_R.csv
 Cross_Shield_Tp.csv
 Shield_Flatness.csv
 Wafer_Thickness.csv
 */

/*

DO


Configure\DO

Angle.csv
Beam_Difference.csv
Beam_L.csv
Beam_R.csv
Shield_Blade_Tp.csv
Shield_Flatness.csv
Shield_Plate_To_Tower.csv
*/




using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.Implementation;
using Cognex.VisionPro.ToolBlock;
using JC.Camera;
using Jet_System.Utils;
using Jet_System.Utils.CustomerCSV;
using Jet_System.Utils.ProgramConfig;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jet_System
{
    public partial class FormMain : Form
    {
        string[] filenames;//vpp root
        bool first_change = true;// first program index change ,do not showTable again
        ConcurrentDictionary<int, string> Current_File_Name = new ConcurrentDictionary<int, string>();// dictionary for save file paths 

        ProgramParameters programParameters = new ProgramParameters();//

        string  last_time="";     //check time ,update excel file name
        CameraBase Currnet_Camera;

       

        string DO_Result;//for twice exposure ,not use now
        bool First_ok;//for twice exposure ,not use now

        private readonly BlockingCollection<ImageIndexAndImage> RowImageSave = new BlockingCollection<ImageIndexAndImage>();
        private readonly BlockingCollection<ImageIndexAndImage> ResultImageSave = new BlockingCollection<ImageIndexAndImage>();


        private readonly BlockingCollection<ImageProcess> ImageProcess_Task = new BlockingCollection<ImageProcess>();

        CancellationTokenSource cancel = new CancellationTokenSource();
        IDisposable ScanPCI;
        PCI7230 Currnet_PCI;

        List<string> RAF_Configure_Path = new List<string>();
        List<string> DO_Configure_Path = new List<string>();


        public FormMain()
        {
            InitializeComponent();

            chbxSaveImage.Checked = true;
           
            
            /*
            RAF_Configure_Path.Add(@"Configure\12PR-RAF\Angle.csv");
            RAF_Configure_Path.Add(@"Configure\12PR-RAF\Beam_Difference.csv");
            RAF_Configure_Path.Add(@"Configure\12PR-RAF\Beam_L.csv");
            RAF_Configure_Path.Add(@"Configure\12PR-RAF\Beam_R.csv");
            RAF_Configure_Path.Add(@"Configure\12PR-RAF\Cross_Shield_Tp.csv");
            RAF_Configure_Path.Add(@"Configure\12PR-RAF\Shield_Flatness.csv");
            RAF_Configure_Path.Add(@"Configure\12PR-RAF\Wafer_Thickness.csv");

            RAF_Configure_Path.Add(@"Configure\12PR-RAF\Beam_Inner_L.csv");
            RAF_Configure_Path.Add(@"Configure\12PR-RAF\Beam_Inner_R.csv");



            DO_Configure_Path.Add(@"Configure\8PR-DO\Angle.csv");
            DO_Configure_Path.Add(@"Configure\8PR-DO\Beam_Difference.csv");
            DO_Configure_Path.Add(@"Configure\8PR-DO\Beam_L.csv");
            DO_Configure_Path.Add(@"Configure\8PR-DO\Beam_R.csv");
            DO_Configure_Path.Add(@"Configure\8PR-DO\Shield_Blade_Tp.csv");
            DO_Configure_Path.Add(@"Configure\8PR-DO\Shield_Flatness.csv");
            DO_Configure_Path.Add(@"Configure\8PR-DO\Shield_Plate_To_Tower.csv");
            DO_Configure_Path.Add(@"Configure\8PR-DO\Beam_Inner_L.csv");
            DO_Configure_Path.Add(@"Configure\8PR-DO\Beam_Inner_R.csv");
            */



        }

        #region FormInit
        private void Init()
        {
            SetImageAndMeasureDataPath();
            Read_Measure_Path();            
            Read_Vpp_Path();
            ClickTab();

            SetCurrentFileName();
            CheckImageAndCsvSavePath();
                       
            programParameters = ReadParameters();

            if (programParameters != null)
            {
                ShowRafNum(programParameters.RAF_ALL_NUM, programParameters.RAF_OK_NUM, programParameters.RAF_NG_NUM);
                ShowDONum(programParameters.DO_ALL_NUM, programParameters.DO_OK_NUM, programParameters.DO_NG_NUM);              
                FormInitConnectCamera(programParameters.IP);////////////////////////////////////////////////////相机ip
            }
            else
            {
                MessageBox.Show("未配置相机，请先转到相机配置");
            }
            CheckPCI();
            ScanIOSignals();
            ScanTime();
            if (programParameters.Current_Program == 0)
            {
                ShowResultTable(ref cogtool_RAF,false);
                mDisplay1Row.Image = cogtool_RAF.Subject.Inputs["Image"].Value as CogImage8Grey;
                ShowRAF_User_Message();
            }
            else
            {              
                ShowResultTable(ref cogtool_DO,false);
                mDisplay1Row.Image = cogtool_DO.Subject.Inputs["Image"].Value as CogImage8Grey;
                ShowDO_User_Message();
            }

            cbxProgramSelect.SelectedIndex = programParameters.Current_Program;
            
            ScanResultImage();
            ScanRowImage();

            ReadConfigure();


        }


        private void SetImageAndMeasureDataPath()
        {
            ImageAndMeasureDataSaveRoot temp = CustomerSerialize.XmlDeserialize<ImageAndMeasureDataSaveRoot>(@"Config\ImageAndMeasureDataSaveRoot.xml");
            SavePath.FileResult = temp.MeasureData;
            SavePath.ImageRootPath = temp.Image;
        }


        private void Read_Measure_Path()
        {
            string measure_path = @"Config\Measure_Config.txt";

            var fil = System.IO.File.ReadAllLines(measure_path);

            if (fil.Count() != 18)
            {
                MessageBox.Show(measure_path + "  不存在");
            }
            for (int i = 0; i < 9; i++)
            {
                RAF_Configure_Path.Add(fil[i]);
            }

            for (int i = 9; i < 18; i++)
            {
                DO_Configure_Path.Add(fil[i]);
            }
        }

        private void Read_Vpp_Path()
        {
            filenames = System.IO.File.ReadAllLines(@"Config\VPP_Config.txt");

            cogtool_RAF.Subject = CogSerializer.LoadObjectFromFile(filenames[0]) as CogToolBlock;
            cogtool_DO.Subject = CogSerializer.LoadObjectFromFile(filenames[1]) as CogToolBlock;
            cogtool_RAF.Subject.Ran += cogtool_RAF_Ran;
            cogtool_DO.Subject.Ran += cogtool_DO_Ran;
        }
       

        private ProgramParameters ReadParameters()
        {
            return CustomerSerialize.XmlDeserialize<ProgramParameters>(@"Config/VPP_Config.txt");
        }

        private void FormInitConnectCamera(string _cameraIP)
        {
            Currnet_Camera = new HikvisionCamera();
            Currnet_Camera.ImageEvent += ProcessImage;
            int count = 0;
            HostPinger pingCamera = new HostPinger(IPAddress.Parse(programParameters.IP));

            var xx = Observable.FromEvent<HostPinger>(handler => pingCamera.OnPing += handler,
                handler => pingCamera.OnPing -= handler).Subscribe(host => {
                    switch (host.Status)
                    {
                        case HostStatus.Alive://ping的状态正常时，开始连接
                            host.Stop();
                            Currnet_Camera.Open(programParameters.IP);
                            Currnet_Camera.IP = programParameters.IP;
                            this.PerformSafely(()=> {
                                status_child_Camera_status.Text = "相机已连接：" + programParameters.IP;
                            });
                            
                            break;
                        default:
                            count++;
                            if (count > 5)
                            {
                                host.Stop();
                                MessageBox.Show("相机连接超时");
                                this.PerformSafely(() => {
                                    status_child_Camera_status.Text = "相机未连接";
                                });
                               


                            }
                            break;
                    }

                }); ;

            pingCamera.PingInterval = 1000;

            pingCamera.Start();
        }


        private void CheckImageAndCsvSavePath()
        {
            CheckImageAndCsvSavePathChild(SavePath.ImageRootPath);
            CheckImageAndCsvSavePathChild(SavePath.Image1ResultOK);
            CheckImageAndCsvSavePathChild(SavePath.Image1ResultNG);
            CheckImageAndCsvSavePathChild(SavePath.Image1Row);
            CheckImageAndCsvSavePathChild(SavePath.Image2ResultOK);
            CheckImageAndCsvSavePathChild(SavePath.Image2ResultNG);
            CheckImageAndCsvSavePathChild(SavePath.Image2Row);


        }

        


        /// <summary>
        /// 0,RAF excel文件
        /// 1,1次曝光ok位置
        /// 2,1次曝光ng
        /// 3，1次曝光原图
        /// 4，2次曝光ok位置
        /// 5，2次曝光ng
        /// 6，2次曝光原图
        /// 7,DO excel 文件
        /// </summary>
        private void SetCurrentFileName()
        {
            if(!Directory.Exists(SavePath.FileResult + "/RAF"))
            {
                MessageBox.Show(SavePath.FileResult + "/ RAF   路劲不存在，请增加 ");
            }
            string file = SavePath.FileResult + "/RAF/" + DateTime.Now.ToString("yyyy-MM-dd")+".csv";

            Current_File_Name.AddOrUpdate(0,
                key=> file,
                (key,oldvalue)=>file);
           


            AddImagePathDirectonary(1, SavePath.Image1ResultOK);
            AddImagePathDirectonary(2, SavePath.Image1ResultNG);
            AddImagePathDirectonary(3, SavePath.Image1Row);
            AddImagePathDirectonary(4, SavePath.Image2ResultOK);
            AddImagePathDirectonary(5, SavePath.Image2ResultNG);
            AddImagePathDirectonary(6, SavePath.Image2Row);



            if (!Directory.Exists(SavePath.FileResult + "/DO"))
            {
                MessageBox.Show(SavePath.FileResult + "/ DO   路劲不存在，请增加 ");
            }
            file = SavePath.FileResult + "/DO/" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv";

            Current_File_Name.AddOrUpdate(7,
                key => file,
                (key, oldvalue) => file);

        }

        private void AddImagePathDirectonary(int index, string _filaeRootPath)
        {
            string file = _filaeRootPath + "/" + DateTime.Now.ToString("yyyy-MM-dd");
            Current_File_Name.AddOrUpdate(index,
               key => file,
               (key, oldvalue) => file);
        }
        

        #endregion

        #region Image Save


        private void CheckImageAndCsvSavePathChild(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

        }

        private void ScanRowImage()
        {
            Task.Factory.StartNew(()=> {
                while (true)
                {
                    foreach (var item in RowImageSave.GetConsumingEnumerable())
                    {
                        
                        if(!Directory.Exists(item.Path))
                        {
                            Directory.CreateDirectory(item.Path);
                        }
                        item.image.Save(item.Path + "/"+DateTime.Now.ToString("hh-mm-ss-ff")+".bmp");
                        
                    }

                    Task.Delay(TimeSpan.FromSeconds(200));
                }
            });
        }

        private void ScanResultImage()
        {
            Task.Factory.StartNew(() => {
                while (true)
                {
                    foreach (var item in ResultImageSave.GetConsumingEnumerable())
                    {

                        if (!Directory.Exists(item.Path))
                        {
                            Directory.CreateDirectory(item.Path);
                        }
                        item.image.Save(item.Path + "/" + DateTime.Now.ToString("hh-mm-ss-ff") + ".bmp");

                    }

                    Task.Delay(TimeSpan.FromSeconds(200));
                }
            });
        }

        #endregion

        #region Message Program Switch

        private void ShowDO_User_Message()
        {
            ra_Shield_Flatness.Text = "Shield_Plate_Flatness";
            ra_Cross_Shield_TP.Text = "Shield_Plate_To_Tower";
            ra_Wafer_Thickness.Text = "Shield_Blade_TP";
            ra_Shield_Cross_Angle.Text = "Angle";


            tab_Shield_Flatness.Text = "Shield_Plate_Flatness";
            tab_Cross_Shield_TP.Text = "Shield_Plate_To_Tower";
            tab_Wafer_Thickness.Text = "Shield_Blade_TP";
            tab_Shield_Cross_Angle.Text = "Angle";
        }

        private void ShowRAF_User_Message()
        {
            ra_Shield_Flatness.Text = "Shield_Flatness";
            ra_Cross_Shield_TP.Text = "Cross_Shield_TP";
            ra_Wafer_Thickness.Text = "Wafer_Thickness";
            ra_Shield_Cross_Angle.Text = "Shield_Cross_Angle";

            tab_Shield_Flatness.Text = "Shield_Flatness";
            tab_Cross_Shield_TP.Text = "Cross_Shield_TP";
            tab_Wafer_Thickness.Text = "Wafer_Thickness";
            tab_Shield_Cross_Angle.Text = "Shield_Cross_Angle";
        }

        #endregion

        #region Form Event


        private void FormMain_Load(object sender, EventArgs e)
        {
            Init();
           
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Currnet_Camera?.Close();
            ScanPCI?.Dispose();
            cancel.Cancel(); 

            Task.Delay(TimeSpan.FromMilliseconds(100));
            Currnet_PCI?.Release();
            RowImageSave.CompleteAdding();
            ResultImageSave.CompleteAdding();
            ImageProcess_Task.CompleteAdding();

            CustomerSerialize.XMLSerialize<ProgramParameters>(programParameters);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// Program switch
        {
            if(first_change)
            {
                first_change = false;
                return;
            }

            if (cbxProgramSelect.SelectedIndex == 0)
            {

                programParameters.Current_Program = 0;
                
                ShowRAF_User_Message();
                Tool_SetInputs(cogtool_DO.Subject.Inputs["Image"].Value as CogImage8Grey, cogtool_DO);
                SaveToolBlock(cogtool_DO, filenames[1]);      
                mDisplay1Row.Image = cogtool_RAF.Subject.Inputs["Image"].Value as CogImage8Grey;
                ShowResultTable(ref cogtool_RAF,false);
                ReadConfigure();
            }
            if (cbxProgramSelect.SelectedIndex == 1)
            {

                programParameters.Current_Program = 1;
                ShowDO_User_Message();
                Tool_SetInputs(cogtool_RAF.Subject.Inputs["Image"].Value as CogImage8Grey, cogtool_RAF);

                SaveToolBlock(cogtool_RAF, filenames[0]);
                mDisplay1Row.Image = cogtool_DO.Subject.Inputs["Image"].Value as CogImage8Grey;
                ShowResultTable(ref cogtool_DO, false);

                ReadConfigure();

            }


            MessageBox.Show("切换完成");
        }

        #endregion

        #region  Measure Selected Changed



        private void ra_Beam_Touch_Window_L_L_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton current = (RadioButton)sender;


            if (current.Checked)
            {
                tabControl_Main.SelectTab(current.Name.Replace("ra", "tab"));

            }
        }


        private void tabControl_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = (TabControl)sender;

            Console.WriteLine(temp.SelectedIndex + temp.SelectedTab.Name);

            var temp1 = this.FindControls<RadioButton>(temp.SelectedTab.Name.Replace("tab", "ra")).FirstOrDefault();
            temp1.Checked = true;


        }

        #endregion

        #region Menu Click Event

        private void 相机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCameraSearch camera = new FormCameraSearch();
            camera.programs = programParameters;
            if (Currnet_Camera != null)
            {

                Currnet_Camera.ImageEvent -= ProcessImage;
                camera.camera = Currnet_Camera;

            }
            

            string camera_msg = "";
            if (camera.ShowDialog(this) == DialogResult.OK)
            {
                Currnet_Camera = camera.camera;
                programParameters = camera.programs;


                

                Currnet_Camera.ImageEvent += ProcessImage;


            }


            if(Currnet_Camera.IsLink)
            {
                camera_msg = Currnet_Camera.IP + "已连接";
                Currnet_Camera.ImageEvent += ProcessImage;
            }
            else
            {
                camera_msg = "相机未连接";
            }
            status_child_Camera_status.Text = camera_msg;



        }

        private void 程序参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        #endregion

        #region Button Click Event

        //当前图像再次运行
        private void btnCurrentImageRun_Click(object sender, EventArgs e)
        {
            

            
        }

        //Trigger Once
        private void btnRunOnce_Click(object sender, EventArgs e)
        {
           
            First_Trigger();
            


        }

        private void btnRunOnce_D0_T_Click(object sender, EventArgs e)
        {
            
            
        }


        //Switch Current CogDisplay
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            //RunningOnce_First(mDisplay1Row.Image as CogImage8Grey);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            programParameters.RAF_ALL_NUM = 0;
            programParameters.RAF_OK_NUM = 0;
            programParameters.RAF_NG_NUM = 0;
            ShowRafNum(programParameters.RAF_ALL_NUM, programParameters.RAF_OK_NUM, programParameters.RAF_NG_NUM);
        }

        private void btnDO_Clear_Click(object sender, EventArgs e)
        {
            programParameters.DO_NG_NUM = 0;
            programParameters.DO_OK_NUM = 0;
            programParameters.DO_ALL_NUM = 0;
            ShowDONum(programParameters.DO_ALL_NUM, programParameters.DO_OK_NUM, programParameters.DO_NG_NUM);
        }

        private void SetLblNum(int _total, int _pass, int _fail)
        {
            lblFailNum_RAF.Text = _total.ToString();
            lblPassNum_RAF.Text = _pass.ToString();
            lblFailNum_RAF.Text = _fail.ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (programParameters.Current_Program == 0)
            {
                Tool_SetInputs(cogtool_RAF.Subject.Inputs["Image"].Value as CogImage8Grey, cogtool_RAF);
                SaveToolBlock(cogtool_RAF, filenames[0]);
            }
            if (programParameters.Current_Program == 1)
            {
                Tool_SetInputs(cogtool_DO.Subject.Inputs["Image"].Value as CogImage8Grey, cogtool_DO);
                SaveToolBlock(cogtool_DO, filenames[1]);
                //Tool_SetInputs(MainTool_DO_T.Inputs.Image, MainTool_DO_T);
                //MainTool_DO_T.Save();
            }

        }

        #endregion

        #region camera Running Function, Set Inputs,Save ToolBlock,Show Image

        void cogtool_RAF_Ran(object sender, EventArgs e)
        {
            
            mDisplay1Result.Image = cogtool_RAF.Subject.Inputs["Image"].Value as CogImage8Grey;
            var temp = cogtool_RAF.Subject.CreateLastRunRecord().SubRecords["OutputImage"];

            mDisplay1Result.Record = temp;
            mDisplay1ResultShow.Record = temp;


        

            mDisplay1Result.Fit(true);
            mDisplay1ResultShow.Fit(true);
        }

        void cogtool_DO_Ran(object sender, EventArgs e)
        {

            mDisplay1Result.Image = cogtool_DO.Subject.Inputs["Image"].Value as CogImage8Grey;

            var temp = cogtool_DO.Subject.CreateLastRunRecord().SubRecords["OutputImage"];

            mDisplay1Result.Record = temp;
            mDisplay1ResultShow.Record = temp;


            mDisplay1Result.Fit(true);
            mDisplay1ResultShow.Fit(true);
           
        }

        private void SaveToolBlock(Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 _tool, string _file)
        {
            CogSerializer.SaveObjectToFile(_tool.Subject, _file);
        }

        private void ProcessImage(object sender, ImageEventArgs e)
        {
            


            switch(e.Command)
            {

                case Command.Grab:
                   // RunningOnce_First(e.CameraImage);
                    ImageProcess_Task.Add(new ImageProcess { Image = e.CameraImage.Copy(),Program = programParameters.Current_Program ,RunTime = 1});
                    break;
                case Command.Grab2:
                    ImageProcess_Task.Add(new ImageProcess { Image = e.CameraImage.Copy(), Program = programParameters.Current_Program, RunTime = 2 });
                    //RunningOnce_Second(e.CameraImage);
                    break;
                default:
                    break;
            }

    
           

        }
        /*
        private void mBlobTool_Changed_First(object sender, CogChangedEventArgs e)
        {
            
            Cognex.VisionPro.ToolBlock.CogToolBlock temp = (Cognex.VisionPro.ToolBlock.CogToolBlock)sender;
            //if ((e.StateFlags & CogBlobTool.SfLastRunRecordEnable) != 0)
            {
                ICogRecord lastRunRecord = temp.CreateLastRunRecord();

                if (lastRunRecord != null &&
                  lastRunRecord.SubRecords.ContainsKey("OutputImage"))//OutImageInterface
                {
                    // Display the InputImage sub-record from the blob tool's last run 
                    // records.
                    var xxx = lastRunRecord.SubRecords["OutputImage"];
                    mDisplay1Result.Record = xxx;
                    mDisplay1ResultShow.Record = xxx;
                    mDisplay1Result.Fit(true);
                }

            }
        }

        //
        private void mBlobTool_Changed_Second(object sender, CogChangedEventArgs e)
        {

            Cognex.VisionPro.ToolBlock.CogToolBlock temp = (Cognex.VisionPro.ToolBlock.CogToolBlock)sender;
            //if ((e.StateFlags & CogBlobTool.SfLastRunRecordEnable) != 0)
            {
                ICogRecord lastRunRecord = temp.CreateLastRunRecord();

                if (lastRunRecord != null &&
                  lastRunRecord.SubRecords.ContainsKey("OutputImage"))//OutImageInterface
                {
                    // Display the InputImage sub-record from the blob tool's last run 
                    // records.
                    var xxx = lastRunRecord.SubRecords["OutputImage"];
                    mDisplay2Result.Record = xxx;
                    mDisplay2ResultShow.Record = xxx;
                    mDisplay2Result.Fit(true);
                }

            }
        }
        */
        private void Tool_SetInputs(CogImage8Grey _image, Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 _tool)
        {
            switch (_tool.Name.Replace("cogtool_",""))
            {
                case "RAF":
                    cogtool_RAF.Subject.Inputs["Image"].Value = _image.Copy();

                    cogtool_RAF.Subject.Inputs["Beam_Touch_Window_L_L"].Value = ((DataTable)dataGrid_Beam_Touch_Window_L_L.DataSource).Copy();


                    cogtool_RAF.Subject.Inputs["Beam_Touch_Window_L_R"].Value =  ((DataTable)dataGrid_Beam_Touch_Window_L_R.DataSource).Copy();
                    cogtool_RAF.Subject.Inputs["Beam_Tip_To_Window_L"].Value =((DataTable)dataGrid_Beam_Tip_To_Window_L.DataSource).Copy();
                    cogtool_RAF.Subject.Inputs["Beam_Touch_Window_R_L"].Value =  ((DataTable)dataGrid_Beam_Touch_Window_R_L.DataSource).Copy();
                    cogtool_RAF.Subject.Inputs["Beam_Touch_Window_R_R"].Value = ((DataTable)dataGrid_Beam_Touch_Window_R_R.DataSource).Copy();
                    cogtool_RAF.Subject.Inputs["Beam_Tip_To_Window_R"].Value =  ((DataTable)dataGrid_Beam_Tip_To_Window_R.DataSource).Copy();

                    cogtool_RAF.Subject.Inputs["Beam_Height_Difference"].Value =  ((DataTable)dataGrid_Beam_Height_Difference.DataSource).Copy();
                    cogtool_RAF.Subject.Inputs["Shield_Flatness"].Value = ((DataTable)dataGrid_Shield_Flatness.DataSource).Copy();
                    cogtool_RAF.Subject.Inputs["Cross_Shield_TP"].Value = ((DataTable)dataGrid_Cross_Shield_TP.DataSource).Copy();
                    cogtool_RAF.Subject.Inputs["Wafer_Thickness"].Value =  ((DataTable)dataGrid_Wafer_Thickness.DataSource).Copy();
                    cogtool_RAF.Subject.Inputs["Shield_Cross_Angle"].Value = ((DataTable)dataGrid_Shield_Cross_Angle.DataSource).Copy();
                    cogtool_RAF.Subject.Inputs["Beam_Height_L"].Value = ((DataTable)dataGrid_Beam_Height_L.DataSource).Copy();
                    cogtool_RAF.Subject.Inputs["Beam_Height_R"].Value =  ((DataTable)dataGrid_Beam_Height_R.DataSource).Copy();

                    cogtool_RAF.Subject.Inputs["Beam_Inner_L"].Value = ((DataTable)dataGrid_Beam_Inner_L.DataSource).Copy();
                    cogtool_RAF.Subject.Inputs["Beam_Inner_R"].Value = ((DataTable)dataGrid_Beam_Inner_R.DataSource).Copy();


                    break;
                case "DO":
                    cogtool_DO.Subject.Inputs["Image"].Value = _image.Copy();



                    cogtool_DO.Subject.Inputs["Beam_Touch_Window_L_L"].Value = ((DataTable)dataGrid_Beam_Touch_Window_L_L.DataSource).Copy();
                    cogtool_DO.Subject.Inputs["Beam_Touch_Window_L_R"].Value =  ((DataTable)dataGrid_Beam_Touch_Window_L_R.DataSource).Copy();
                    cogtool_DO.Subject.Inputs["Beam_Tip_To_Window_L"].Value =  ((DataTable)dataGrid_Beam_Tip_To_Window_L.DataSource).Copy();
                    cogtool_DO.Subject.Inputs["Beam_Touch_Window_R_L"].Value =  ((DataTable)dataGrid_Beam_Touch_Window_R_L.DataSource).Copy();
                    cogtool_DO.Subject.Inputs["Beam_Touch_Window_R_R"].Value =  ((DataTable)dataGrid_Beam_Touch_Window_R_R.DataSource).Copy();
                    cogtool_DO.Subject.Inputs["Beam_Tip_To_Window_R"].Value = ((DataTable)dataGrid_Beam_Tip_To_Window_R.DataSource).Copy();
                    cogtool_DO.Subject.Inputs["Beam_Height_Difference"].Value =  ((DataTable)dataGrid_Beam_Height_Difference.DataSource).Copy();

                    cogtool_DO.Subject.Inputs["Shield_Plate_Flatness"].Value = ((DataTable)dataGrid_Shield_Flatness.DataSource).Copy();
                    cogtool_DO.Subject.Inputs["Shield_Plate_To_Tower"].Value =  ((DataTable)dataGrid_Cross_Shield_TP.DataSource).Copy();


                    cogtool_DO.Subject.Inputs["Beam_Height_L"].Value =  ((DataTable)dataGrid_Beam_Height_L.DataSource).Copy();
                    cogtool_DO.Subject.Inputs["Beam_Height_R"].Value = ((DataTable)dataGrid_Beam_Height_R.DataSource).Copy();

                    cogtool_DO.Subject.Inputs["Beam_Inner_L"].Value = ((DataTable)dataGrid_Beam_Inner_L.DataSource).Copy();
                    cogtool_DO.Subject.Inputs["Beam_Inner_R"].Value = ((DataTable)dataGrid_Beam_Inner_R.DataSource).Copy();

                    cogtool_DO.Subject.Inputs["Shield_Blade_TP"].Value =  ((DataTable)dataGrid_Wafer_Thickness.DataSource).Copy();
                    cogtool_DO.Subject.Inputs["Angle"].Value = ((DataTable)dataGrid_Shield_Cross_Angle.DataSource).Copy();

                    break;
                case "DO_T":/*
                    MainTool_DO_T.Inputs.SetInputs(_image as CogImage8Grey,
                    new int[] { 1, 2 }, new List<ICogRegion>(),
                    
                    (DataTable)dataGrid_Shield_Cross_Angle.DataSource
                    );
                    MainTool_DO_T.SetInputs();*/
                    break;
                default:
                    break;
            }
        }



        private void RunningOnce_First(CogImage8Grey _image,int _program)
        {
            mDisplay1Row.Image = _image;
            mDisplay1RowShow.Image = _image;


            this.PerformSafely(()=> {
                lblStatus.Text = "开始检测....";
            });
            



            if (_program == 0)//RAF
            {

               

                RowImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[3], image = _image.ToBitmap() });

                Stopwatch ss = new Stopwatch();
                ss.Start();
                Tool_SetInputs(_image, cogtool_RAF);
                Currnet_PCI.Clear12Light();
                cogtool_RAF.Subject.Run();

                var result = (CogRunStatus)cogtool_RAF.Subject.RunStatus;
               
                if (result.Result != CogToolResultConstants.Accept)//check result
                {
                    ResultImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[2], image = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display) as Bitmap });
                    ss.Stop();
                    this.PerformSafely(() => {
             
                        txt_message.Text = result.Message;
                        Console.WriteLine(ss.ElapsedMilliseconds.ToString());
                        txtTime.Text = ss.ElapsedMilliseconds.ToString();

                        this.PerformSafely(() => {
                            lblStatus.Text = "检测失败，请再试一次";
                        });

                    });
                    return;
                }
                this.PerformSafely(()=> {
                    ShowResultTable(ref cogtool_RAF, true);
                });
                
                ss.Stop();             
                this.PerformSafely(() => {
                    //ResultImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[5], image = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display) });
                    Console.WriteLine(ss.ElapsedMilliseconds.ToString());
                    txtTime.Text = ss.ElapsedMilliseconds.ToString();
                });
            }

            else
            {
                //RowImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[6], image = mDisplay1Row.CreateContentBitmap(CogDisplayContentBitmapConstants.Custom) });
                RowImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[6], image = _image.ToBitmap() }) ;
                //mDisplay1Row.Image.
                
                CogStopwatch ss = new CogStopwatch();
                ss.Start();
               
                Tool_SetInputs(_image, cogtool_DO);
                Currnet_PCI.Clear124Light();
                cogtool_DO.Subject.Run();
                
                var result = (CogRunStatus)cogtool_DO.Subject.RunStatus;
                if (result.Result != CogToolResultConstants.Accept)//check result
                {
                   
                    ResultImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[5], image = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display) as Bitmap });
                    ss.Stop();
                    this.PerformSafely(() => {

                        Currnet_PCI.Open4Light();
                        Second_Trigger();
                        txt_message.Text = result.Message;
                        Console.WriteLine(ss.Milliseconds.ToString());
                        txtTime.Text = ss.Milliseconds.ToString();
                     


                       
                        this.PerformSafely(() => {
                            lblStatus.Text = "检测失败，请再试一次";
                        });

                    });
                    return;
                }

                this.PerformSafely(()=> {
                    Currnet_PCI.Open4Light();
                    Second_Trigger();

                    ShowResultTable(ref cogtool_DO, true);
                });
                
                ss.Stop();
                this.PerformSafely(() => {

                    Console.WriteLine(ss.Milliseconds.ToString());
                    txtTime.Text = ss.Milliseconds.ToString();

                });
                           
                  
          
            }
            
        }


        

        private void RunningOnce_Second(CogImage8Grey _image)
        {

            Currnet_PCI.Clear4Light();

            mDisplay2Row.Image = _image;
            mDisplay2RowShow.Image = _image;

            mDisplay2Result.Image = _image;
            mDisplay2ResultShow.Image = _image;


            /*
            CogStopwatch ss = new CogStopwatch();
            ss.Start();
            Tool_SetInputs(_image, cogtool_DO);
         

            Currnet_PCI.Clear4Light();
            var result = (CogRunStatus)cogtool_DO.Subject.RunStatus;
            if (result.Result != CogToolResultConstants.Accept)//check result
            {
                ss.Stop();
                this.PerformSafely(() => {
                    MessageBox.Show(result.Message);
                    txt_message.Text = result.Message;
                    Console.WriteLine(ss.Milliseconds.ToString());
                    txtTime.Text = ss.Milliseconds.ToString();
                });
                return;
            }

            

            ShowResultTable(ref cogtool_DO,true);
            ss.Stop();

            this.PerformSafely(() => {
                
                Console.WriteLine(ss.Milliseconds.ToString());
                txtTime.Text = ss.Milliseconds.ToString();
            });*/
        }

            

        private void ScanImageProcess()
        {
            Task.Factory.StartNew(()=> {

                while(true)
                {
                    var temp = ImageProcess_Task.Take(cancel.Token);
                    switch(temp.RunTime)
                    {
                        case 1:
                            RunningOnce_First(temp.Image as CogImage8Grey,temp.Program);
                            break;
                        case 2:
                            RunningOnce_Second(temp.Image as CogImage8Grey);
                            break;
                        default:
                            break;
                    }
                   
                }

            });
        }


        #endregion

        #region  FileName Change 
       


        /// <summary>
        /// 1.时间变化
        /// 2.被拷贝走的话，要在生成
        /// </summary>
        private void ScanTime()
        {

            Observable.Interval(TimeSpan.FromSeconds(1)).Subscribe(
                x => {
                    var current = DateTime.Now.ToString("yyyy-MM-dd");
                    if (last_time != current)
                    {
                        SetCurrentFileName();
                        last_time = current;
                    }
                });
        }


       





        #endregion

        #region PCI IO Signls,

        private void ScanIOSignals()
        {
            bool last_signal = false;
            bool current_signal = false;


            ScanPCI = Observable.Interval(TimeSpan.FromMilliseconds(100)).Buffer(1).Subscribe(
                x => {
                    current_signal  = Currnet_PCI.ReadI4();
               
                    //get io signal
                    if (current_signal == true && last_signal == false)
                    {

                        First_Trigger();
                    
                    }
                    else
                    {

                    }

                    last_signal = current_signal;

                }
                
                );

            
        }

        private void CheckPCI()
        {
            try
            {
                Currnet_PCI = new PCI7230();
                Currnet_PCI.Register();
                Currnet_PCI.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show("未检测到pci卡，请检查");
            }
        }



        private void First_Trigger()
        {
            if (programParameters.Current_Program == 0)
            {
                Currnet_PCI.Open12Light();
                Currnet_Camera.ShuterCur = (long)programParameters.RAF_Exposure;
                Currnet_Camera.GainCur = (long)programParameters.RAF_Gain;

                
            }
            else
            {
                Currnet_PCI.Open124Light();
                Currnet_Camera.ShuterCur = (long)programParameters.DO_Exposure1;
                Currnet_Camera.GainCur = (long)programParameters.DO_Gain1;

               

            }
            Currnet_Camera.OneShot(Command.Grab);
        }
        private void Second_Trigger()
        {
            if (programParameters.Current_Program == 1)
            {
                Currnet_PCI.Open4Light();
                
                Currnet_Camera.ShuterCur = (long)programParameters.DO_Exposure2;
                Currnet_Camera.GainCur = (long)programParameters.DO_Gain2;
                

                Currnet_Camera.OneShot(Command.Grab2);


            }
        }
        #endregion

        #region Get Excel Configure And Update table
        private void ReadConfigure()
        {

            /*
              RAF
 
 Angle.csv
 Beam_Difference.csv
 Beam_L.csv
 Beam_R.csv
 Cross_Shield_Tp.csv
 Shield_Flatness.csv
 Wafer_Thickness.csv*/

            if (programParameters.Current_Program == 0)
            {
                var temp = CustomerCsvHelper.ReadParameters(RAF_Configure_Path[0]);
                UpdateConfigure(temp,ref dataGrid_Shield_Cross_Angle);

                temp = CustomerCsvHelper.ReadParameters(RAF_Configure_Path[1]);
                UpdateConfigure(temp, ref dataGrid_Beam_Height_Difference);

                temp = CustomerCsvHelper.ReadParameters(RAF_Configure_Path[2]);
                UpdateConfigure(temp, ref dataGrid_Beam_Height_L);

                temp = CustomerCsvHelper.ReadParameters(RAF_Configure_Path[3]);
                UpdateConfigure(temp, ref dataGrid_Beam_Height_R);

                temp = CustomerCsvHelper.ReadParameters(RAF_Configure_Path[4]);
                UpdateConfigure(temp, ref dataGrid_Cross_Shield_TP);

                temp = CustomerCsvHelper.ReadParameters(RAF_Configure_Path[5]);
                UpdateConfigure(temp, ref dataGrid_Shield_Flatness);

                temp = CustomerCsvHelper.ReadParameters(RAF_Configure_Path[6]);
                UpdateConfigure(temp, ref dataGrid_Wafer_Thickness);

                temp = CustomerCsvHelper.ReadParameters(RAF_Configure_Path[7]);
                UpdateConfigure(temp, ref dataGrid_Beam_Inner_L);

                temp = CustomerCsvHelper.ReadParameters(RAF_Configure_Path[8]);
                UpdateConfigure(temp, ref dataGrid_Beam_Inner_R);



                /*
                UpdateConfigure(dataGrid_Beam_Touch_Window_L_L);
                UpdateConfigure(dataGrid_Beam_Touch_Window_L_R);
                UpdateConfigure(dataGrid_Beam_Tip_To_Window_L);
                UpdateConfigure(dataGrid_Beam_Touch_Window_R_L);
                UpdateConfigure(dataGrid_Beam_Touch_Window_R_R);
                UpdateConfigure(dataGrid_Beam_Tip_To_Window_R);
                */




            }
            else
            {

                /*


    DO


    Configure\DO

    Angle.csv
    Beam_Difference.csv
    Beam_L.csv
    Beam_R.csv
    Shield_Blade_Tp.csv
    Shield_Flatness.csv
    Shield_Plate_To_Tower.csv
                 */


                var temp = CustomerCsvHelper.ReadParameters(DO_Configure_Path[0]);
                UpdateConfigure(temp, ref dataGrid_Shield_Cross_Angle);

                temp = CustomerCsvHelper.ReadParameters(DO_Configure_Path[1]);
                UpdateConfigure(temp, ref dataGrid_Beam_Height_Difference);

                temp = CustomerCsvHelper.ReadParameters(DO_Configure_Path[2]);
                UpdateConfigure(temp, ref dataGrid_Beam_Height_L);

                temp = CustomerCsvHelper.ReadParameters(DO_Configure_Path[3]);
                UpdateConfigure(temp, ref dataGrid_Beam_Height_R);

                temp = CustomerCsvHelper.ReadParameters(DO_Configure_Path[4]);
                UpdateConfigure(temp, ref dataGrid_Wafer_Thickness);

                temp = CustomerCsvHelper.ReadParameters(DO_Configure_Path[5]);
                UpdateConfigure(temp, ref dataGrid_Shield_Flatness);

                temp = CustomerCsvHelper.ReadParameters(DO_Configure_Path[6]);
                UpdateConfigure(temp, ref dataGrid_Cross_Shield_TP);

                temp = CustomerCsvHelper.ReadParameters(DO_Configure_Path[7]);
                UpdateConfigure(temp, ref dataGrid_Beam_Inner_L);

                temp = CustomerCsvHelper.ReadParameters(DO_Configure_Path[8]);
                UpdateConfigure(temp, ref dataGrid_Beam_Inner_R);





            }

        }


        private void UpdateConfigure(IEnumerable<ParametersConfigure > _configure, ref DataGridView _grid)
        {
            var temp = _configure.ToList();
            DataTable tempt = ((DataTable)_grid.DataSource).Copy();
            for (int i = 0; i < _configure.Count(); i++)
            {
                tempt.Rows[i]["上限"] = temp[i].Max.ToString();
                tempt.Rows[i]["上限"] = temp[i].Max.ToString();
                tempt.Rows[i]["下限"] = temp[i].Min.ToString();
                tempt.Rows[i]["比例系数"] = temp[i].Rate.ToString();
                tempt.Rows[i]["偏移"] = temp[i].Offer.ToString();

                /*
                _grid.Rows[i].Cells["上限"].Value = temp[i].Max.ToString();
                _grid.Rows[i].Cells["下限"].Value = temp[i].Min.ToString();
                _grid.Rows[i].Cells["比例系数"].Value = temp[i].Rate.ToString();
                _grid.Rows[i].Cells["偏移"].Value = temp[i].Offer.ToString();*/

               // _grid.Rows[i].Cells["序号"].Value = (i+1).ToString();

            }
            _grid.DataSource = tempt;
        }

        private void UpdateConfigure( DataGridView _grid)
        {
           
            for (int i = 0; i < 96; i++)
            {
               

                _grid.Rows[i].Cells["序号"].Value = (i + 1).ToString();

            }
        }



        #endregion

        #region ResultShow  ,Save MeasureData
        private void ShowResultTable( ref Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 _showTool,bool _save_data)
        {
            bool is_allOK = true;
            string data_string="";
            switch (_showTool.Name.Replace("cogtool_",""))
            {
                case "RAF":
                    
                    
                    var temp = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_L_L"].Value).Copy();
                    dataGrid_Beam_Touch_Window_L_L.DataSource = null;
                    dataGrid_Beam_Touch_Window_L_L.DataSource = temp;
                    ShowResultTableChild(ref is_allOK,ref dataGrid_Beam_Touch_Window_L_L, temp,false, ref data_string);
                   

                    
                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_L_R"].Value).Copy();
                    dataGrid_Beam_Touch_Window_L_R.DataSource = null;
                    dataGrid_Beam_Touch_Window_L_R.DataSource = temp;
                    ShowResultTableChild(ref is_allOK,ref  dataGrid_Beam_Touch_Window_L_R, temp, false, ref data_string);

               
                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Tip_To_Window_L"].Value).Copy();
                    dataGrid_Beam_Tip_To_Window_L.DataSource = null;
                    dataGrid_Beam_Tip_To_Window_L.DataSource = temp;
                    ShowResultTableChild(ref is_allOK,ref dataGrid_Beam_Tip_To_Window_L, temp, false, ref data_string);

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_R_L"].Value).Copy();
                    dataGrid_Beam_Touch_Window_R_L.DataSource = null;
                    dataGrid_Beam_Touch_Window_R_L.DataSource = temp;
                    ShowResultTableChild(ref is_allOK,ref dataGrid_Beam_Touch_Window_R_L, temp, false, ref data_string);

                  
                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_R_R"].Value).Copy();
                    dataGrid_Beam_Touch_Window_R_R.DataSource = null;
                    dataGrid_Beam_Touch_Window_R_R.DataSource = temp;
                    ShowResultTableChild(ref is_allOK,ref dataGrid_Beam_Touch_Window_R_R, temp, false, ref data_string);

               
                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Tip_To_Window_R"].Value).Copy();
                    dataGrid_Beam_Tip_To_Window_R.DataSource = null;
                    dataGrid_Beam_Tip_To_Window_R.DataSource = temp;
                    ShowResultTableChild(ref is_allOK,ref dataGrid_Beam_Tip_To_Window_R, temp, false, ref data_string);


                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Height_L"].Value).Copy();
                    dataGrid_Beam_Height_L.DataSource = null;
                    dataGrid_Beam_Height_L.DataSource = temp;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Height_L, temp, true, ref data_string);


                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Height_R"].Value).Copy();
                    dataGrid_Beam_Height_R.DataSource = null;
                    dataGrid_Beam_Height_R.DataSource = temp;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Height_R, temp, true, ref data_string);


                    

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Inner_L"].Value).Copy();
                    dataGrid_Beam_Inner_L.DataSource = null;
                    dataGrid_Beam_Inner_L.DataSource = temp;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Inner_L, temp, true, ref data_string);

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Inner_R"].Value).Copy();
                    dataGrid_Beam_Inner_R.DataSource = null;
                    dataGrid_Beam_Inner_R.DataSource = temp;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Inner_R, temp, true, ref data_string);

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Height_Difference"].Value).Copy();
                    dataGrid_Beam_Height_Difference.DataSource = null;
                    dataGrid_Beam_Height_Difference.DataSource = temp;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Height_Difference, temp, true, ref data_string);

             
                    temp = ((DataTable)_showTool.Subject.Outputs["Shield_Flatness"].Value).Copy();
                    dataGrid_Shield_Flatness.DataSource = null;
                    dataGrid_Shield_Flatness.DataSource = temp;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Shield_Flatness, temp, true, ref data_string);

                
                    temp = ((DataTable)_showTool.Subject.Outputs["Cross_Shield_TP"].Value).Copy();
                    dataGrid_Cross_Shield_TP.DataSource = null;
                    dataGrid_Cross_Shield_TP.DataSource = temp;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Cross_Shield_TP, temp, true, ref data_string);

                
                    temp = ((DataTable)_showTool.Subject.Outputs["Wafer_Thickness"].Value).Copy();
                    dataGrid_Wafer_Thickness.DataSource = null;
                    dataGrid_Wafer_Thickness.DataSource = temp;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Wafer_Thickness, temp, true, ref data_string);

                 
                    temp = ((DataTable)_showTool.Subject.Outputs["Shield_Cross_Angle"].Value).Copy();
                    dataGrid_Shield_Cross_Angle.DataSource = null;
                    dataGrid_Shield_Cross_Angle.DataSource = temp;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Shield_Cross_Angle, temp, false, ref data_string);


                    







                    if (is_allOK)
                    {
                        if (_save_data)
                        {
                            programParameters.RAF_OK_NUM++;
                            programParameters.RAF_ALL_NUM++;
                        }
                        //SaveImageAndShowResult(mDisplay1Result,mDisplay1Row, is_allOK,20);

                        lbl_RAF_OKNG.BackColor = Color.Green;
                        lbl_RAF_OKNG.Text = "OK";

                        Label_max.BackColor = Color.Green;
                        Label_max.Text = "OK";
                        if (_save_data)
                        {
                            ResultImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[1], image = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display) as Bitmap });

                            this.PerformSafely(() => {
                                lblStatus.Text = "检测成功，产品OK";
                            });

                        }
                    }
                    else
                    {
                        if (_save_data)
                        {


                            programParameters.RAF_NG_NUM++;
                            programParameters.RAF_ALL_NUM++;
                        }
                        //SaveImageAndShowResult(mDisplay1Result, mDisplay1Row, is_allOK, 20);

                        lbl_RAF_OKNG.BackColor = Color.Red;
                        lbl_RAF_OKNG.Text = "NG";


                        Label_max.BackColor = Color.Red;
                        Label_max.Text = "NG";
                        if (_save_data)
                        {
                            ResultImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[2], image = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display)  as Bitmap});

                            this.PerformSafely(() => {
                                lblStatus.Text = "检测成功，产品NG";
                            });

                        }
                    }
                    ShowRafNum(programParameters.RAF_ALL_NUM, programParameters.RAF_OK_NUM, programParameters.RAF_NG_NUM);

                    if(_save_data)
                    {
                        SaveMeasureData_RAF(data_string, Current_File_Name[0]);
                    }
                    

                    

                    

                    break;
                case "DO":

                    var temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_L_L"].Value).Copy();
                    dataGrid_Beam_Touch_Window_L_L.DataSource = null;
                    dataGrid_Beam_Touch_Window_L_L.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Touch_Window_L_L, temp2, false, ref data_string);


                    temp2 =  ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_L_R"].Value).Copy();
                    dataGrid_Beam_Touch_Window_L_R.DataSource = null;
                    dataGrid_Beam_Touch_Window_L_R.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Touch_Window_L_R, temp2, false, ref data_string);

                    
                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Tip_To_Window_L"].Value).Copy();
                    dataGrid_Beam_Tip_To_Window_L.DataSource = null;
                    dataGrid_Beam_Tip_To_Window_L.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Tip_To_Window_L, temp2, false, ref data_string);

                   
                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_R_L"].Value).Copy();
                    dataGrid_Beam_Touch_Window_R_L.DataSource = null;
                    dataGrid_Beam_Touch_Window_R_L.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Touch_Window_R_L, temp2, false, ref data_string);

                
                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_R_R"].Value).Copy();
                    dataGrid_Beam_Touch_Window_R_R.DataSource = null;
                    dataGrid_Beam_Touch_Window_R_R.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Touch_Window_R_R, temp2, false, ref data_string);

                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Tip_To_Window_R"].Value).Copy();
                    dataGrid_Beam_Tip_To_Window_R.DataSource = null;
                    dataGrid_Beam_Tip_To_Window_R.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Tip_To_Window_R, temp2, false, ref data_string);


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Height_L"].Value).Copy();
                    dataGrid_Beam_Height_L.DataSource = null;
                    dataGrid_Beam_Height_L.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Height_L, temp2, true, ref data_string);


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Height_R"].Value).Copy();
                    dataGrid_Beam_Height_R.DataSource = null;
                    dataGrid_Beam_Height_R.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Height_R, temp2, true, ref data_string);


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Inner_R"].Value).Copy();
                    dataGrid_Beam_Inner_R.DataSource = null;
                    dataGrid_Beam_Inner_R.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Inner_R, temp2, true, ref data_string);

                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Inner_L"].Value).Copy();
                    dataGrid_Beam_Inner_L.DataSource = null;
                    dataGrid_Beam_Inner_L.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Inner_L, temp2, true, ref data_string);


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Inner_R"].Value).Copy();
                    dataGrid_Beam_Inner_R.DataSource = null;
                    dataGrid_Beam_Inner_R.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Inner_R, temp2, true, ref data_string);

                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Height_Difference"].Value).Copy();
                    dataGrid_Beam_Height_Difference.DataSource = null;
                    dataGrid_Beam_Height_Difference.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Beam_Height_Difference, temp2, true, ref data_string);
                    /*
                    var dasdad = temp2.Copy();
                    
                    for (int k = 0; k < 8; k++)
                    {
                        var rows = dasdad.NewRow();
                        rows["序号"] = 96 + k;
                        rows["上限"] = 0.1;
                        rows["下限"] = -0.1;
                        rows["偏移"] = 0;
                        rows["比例系数"] = 0.008;
                        rows["结果"] = 0;
                        rows["单项NG"] = 0;
                        rows["指示"] = true;

                        dasdad.Rows.Add(rows);

                    }
                    _showTool.Subject.Outputs["Shield_Blade_TP"].Value = dasdad.Copy(); ;
                    */
                    
                    temp2 = ((DataTable)_showTool.Subject.Outputs["Shield_Plate_Flatness"].Value).Copy();
                    dataGrid_Shield_Flatness.DataSource = null;
                    dataGrid_Shield_Flatness.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Shield_Flatness, temp2, true, ref data_string);

                
                    temp2 = ((DataTable)_showTool.Subject.Outputs["Shield_Plate_To_Tower"].Value).Copy();
                    dataGrid_Cross_Shield_TP.DataSource = null;
                    dataGrid_Cross_Shield_TP.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Cross_Shield_TP, temp2, true, ref data_string);


                    



                    temp2 = ((DataTable)_showTool.Subject.Outputs["Shield_Blade_TP"].Value).Copy();
                    dataGrid_Wafer_Thickness.DataSource = null;
                    dataGrid_Wafer_Thickness.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Wafer_Thickness, temp2, true, ref data_string);
                  


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Angle"].Value).Copy();
                    dataGrid_Shield_Cross_Angle.DataSource = null;
                    dataGrid_Shield_Cross_Angle.DataSource = temp2;
                    ShowResultTableChild(ref is_allOK, ref dataGrid_Shield_Cross_Angle, temp2, true, ref data_string);
                   
                    DO_Result = data_string;

                    First_ok = is_allOK;


                    if (is_allOK)
                    {
                        if (_save_data)
                        {
                            programParameters.DO_OK_NUM++;
                            programParameters.DO_ALL_NUM++;
                        }
                        //SaveImageAndShowResult(mDisplay1Result, mDisplay1Row, is_allOK, 20);

                        lbl_DO_OKNG.BackColor = Color.Green;
                        lbl_DO_OKNG.Text = "OK";

                        Label_max.BackColor = Color.Green;
                        Label_max.Text = "OK";
                        if (_save_data)
                        {
                            ResultImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[4], image = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display)  as Bitmap});

                            this.PerformSafely(() => {
                                lblStatus.Text = "检测成功，产品OK";
                            });

                        }
                    }
                    else
                    {
                        if (_save_data)
                        {


                            programParameters.DO_NG_NUM++;
                            programParameters.DO_ALL_NUM++;
                        }

                        lbl_DO_OKNG.BackColor = Color.Red;
                        lbl_DO_OKNG.Text = "NG";

                        Label_max.BackColor = Color.Red;
                        Label_max.Text = "NG";
                        if(_save_data)
                        {
                            var images = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display);
                            ResultImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[5], image = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display) as Bitmap});
                            this.PerformSafely(() => {
                                lblStatus.Text = "检测成功，产品NG";
                            });
                        }
                        
                    }
                    ShowDONum(programParameters.DO_ALL_NUM, programParameters.DO_OK_NUM, programParameters.DO_NG_NUM);

                    if(_save_data)
                    {
                        SaveMeasureData_DO(DO_Result, Current_File_Name[7]);
                    }
                    

                    break;
                
                default:
                    break;
            }
        }


        private bool ShowResultTableChild(ref bool _all_result ,ref DataGridView _grid, DataTable _table,bool isNeedSave,ref string dataS)
        {
            bool isok = true;
           
            //_grid.DefaultCellStyle.BackColor = Color.White;
            foreach (DataGridViewColumn item in _grid.Columns)
            {
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                item.ReadOnly = true;
              //  item.DefaultCellStyle.BackColor = Color.White;
            }
            var data_table = _table.AsEnumerable();
            if (isNeedSave)
            {
                var sss  = data_table.Select(x=>x.Field<string>("结果"));
                foreach (var item in sss)
                {
                    dataS += item + ";";
                }
            }

            
           
            var ng = data_table.Where(x => x.Field<string>("指示") == "False");


            isok = ng.Count() > 0 ? false : true;

            

            foreach (var item in ng)
            {
                _grid.Rows[Convert.ToInt32(item.Field<string>("序号"))-1].DefaultCellStyle.BackColor = Color.Red;//////////////////////////////////////////////////////////////////////
            }
            var temp1 = this.FindControls<RadioButton>(_grid.Name.Replace("dataGrid", "ra")).FirstOrDefault();

            if (isok)
            {
                temp1.BackColor = Color.White;
                
            }
            else
            {
                temp1.BackColor = Color.Red;
                _all_result = false;
            }
            return isok;
        }


        private void ClickTab()
        {
            foreach (TabPage item in tabControl_Main_all.TabPages)
            {
                tabControl_Main_all.SelectTab(item.Name);
            }
            tabControl_Main_all.SelectTab(tabControl_Main_all.TabPages[0]);
            foreach (TabPage item in tabControl_Main.TabPages)
            {
                tabControl_Main.SelectTab(item.Name);
            }
            tabControl_Main.SelectTab(tabControl_Main.TabPages[1]);
        }


        private void ShowRafNum(int all, int ok, int ng)
        {

            this.PerformSafely(() => {
                this.lblTotalNum_RAF.Text = all.ToString();
                this.lblPassNum_RAF.Text = ok.ToString();
                this.lblFailNum_RAF.Text = ng.ToString();
            });

        }
        private void ShowDONum(int all, int ok, int ng)
        {

            this.PerformSafely(() => {
                this.lblTotalNum_DO.Text = all.ToString();
                this.lblPassNum_DO.Text = ok.ToString();
                this.lblFailNum_DO.Text = ng.ToString();
            });


        }

        private void SaveMeasureData_RAF(string _measureData,string _filename)
        {
            if (!File.Exists(_filename))
            {
                CustomerCsvHelper.CreateFile(_filename);
                string head = "";
                List<string> dataname = new List<string>();
                dataname.Add("Beam_L");
                dataname.Add("Beam_R");
                dataname.Add("Beam_Inner_L");
                dataname.Add("Beam_Inner_R");
                dataname.Add("Difference");
                dataname.Add("Shield");
                dataname.Add("Cross");
                dataname.Add("Wafer");
                foreach (var item in dataname)
                {
                    for (int i = 1; i <= 96; i++)
                    {
                        head += item + "_" + i.ToString() + ";";
                    }
                }
                CustomerCsvHelper.WriteHeader(_filename, head);
            }
            CustomerCsvHelper.WriteOneLine(_filename, _measureData);
        }

        private void SaveMeasureData_DO(string _measureData, string _filename)
        {
            

            if (!File.Exists(_filename))
            {
                CustomerCsvHelper.CreateFile(_filename);
                string head = "";
                List<string> dataname = new List<string>();
                if (programParameters.Current_Program ==0)
                {
                    dataname.Add("Beam_L");
                    dataname.Add("Beam_R");
                    dataname.Add("Beam_Inner_L");
                    dataname.Add("Beam_Inner_R");
                    dataname.Add("Difference");
                    dataname.Add("Flatness");
                    dataname.Add("Cross_TP");
                    dataname.Add("Waffer");
                    dataname.Add("Angle");
                    foreach (var item in dataname)
                    {
                        for (int i = 1; i <= 96; i++)
                        {
                            head += item + "_" + i.ToString() + ";";
                        }
                       
                    }
                 
                }

                else
                {
                    dataname.Add("Beam_L");
                    dataname.Add("Beam_R");
                    dataname.Add("Beam_Inner_L");
                    dataname.Add("Beam_Inner_R");
                    dataname.Add("Difference");
                    dataname.Add("Flatness");
                    dataname.Add("Tower");
                    dataname.Add("TP");
                    dataname.Add("Angle");
                    foreach (var item in dataname)
                    {
                        for (int i = 1; i <= 96; i++)
                        {
                            head += item + "_" + i.ToString() + ";";
                        }
                        if (item == "TP")
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                head += item + "_" + (j + 96).ToString() + ";";
                            }
                        }
                    }
                   
                }
                CustomerCsvHelper.WriteHeader(_filename, head);


            }
            CustomerCsvHelper.WriteOneLine(_filename, _measureData);
        }





        #endregion

        
    }


}
