﻿


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
 Cross_Shield_extp.csv
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


/*
 * 
 * 
 * RAF                       DO                  DataGerd
 * 
 Wafer_Thickness   ,   Shield_Blade_TP  ,        dataGrid_Wafer_Thickness
 
 Cross_Shield_TP,      Shield_Plate_To_Tower,    dataGrid_Cross_Shield_TP
 


 Shield_Flatness,      Shield_Plate_Flatness,    dataGrid_Shield_Flatness


 Shield_Cross_Angle,   Angle,                    dataGrid_Shield_Cross_Angle
 */




using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.Implementation;
using Cognex.VisionPro.ToolBlock;
using JC.Camera;
using Jet_System.Utils;
using Jet_System.Utils.CustomerCSV;
using Jet_System.Utils.MyQuene;
using Jet_System.Utils.ProgramConfig;
using System;
using System.Collections;
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

        List<string> RAF_Configure_Path = new List<string>();//存放RAF配置
        List<string> DO_Configure_Path = new List<string>();//存放DO配置

        string Check_Configure_Path = "";

        CustomerQuene MeasureDataQuene;

        List<WaveData> Wavedata_Do = new List<WaveData>();
        List<WaveData> Wavedata_Raf = new List<WaveData>();
        WaveData WaveData;

        Wave_Pattern wavepatten = new Wave_Pattern();
        bool isClick = false;

        string waveName = null;
        public FormMain()
        {
            InitializeComponent();

            chbxSaveImage.Checked = true;
            DataGridBindEvent();//找到显示DataTable的控件
            
            //并将每个控件显示datatable包含datagrid名称的控件绑定rowprepaint事件和自适应表格大小


        }

        #region FormInit
        private void Init()//初始化
        {
            
            programParameters = ReadParameters();
            MeasureDataQuene = new CustomerQuene(programParameters.MeasureDeep);
            SetImageAndMeasureDataPath();//读取存放再xml文件的根文件名，用来存放公差数据和图片，下次需要更换保存路径就不要反复设置了；


            Read_Measure_Path();//读取公差数据。。如果读取的文件名条数不等于19说明路径错误。判断完将前十条目录 放进raf配置后9条do配置          
            Read_Vpp_Path();//读取vpro文件，载入文件显示再界面上。并且绑定cogtool_raf_ran使之运行完后将inputs图片显示在界面上，创建一个lastrecord显示ng信息。。两张图都自适应大小

            ClickTab();

            SetCurrentFileName();//设定文件名
            CheckImageAndCsvSavePath();//检查字典中有没有设定好的文件名，没有就创一个




            CbxHistoryIndexAdd();
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
            
            if (programParameters.Current_Program == 0)
            {
                var tab = GetProductTable(cogtool_RAF);//tab存放生成的datatable的各项数据
        
                ShowRecord(0,ref  tab,"RAF",false,false,false);//这个index不知道干嘛的的。。tab：输入的表。""raf:"raf/do" false:是否保存
             
                mDisplay1Row.Image = cogtool_RAF.Subject.Inputs["Image"].Value as CogImage8Grey;
                ShowRAF_User_Message();//tab和ratiobutton text显示成raf的各项数据
            }
            else
            {
                var tab = GetProductTable(cogtool_DO);
        
                ShowRecord(0,ref  tab, "DO",false,false,false);
              
                mDisplay1Row.Image = cogtool_DO.Subject.Inputs["Image"].Value as CogImage8Grey;
                ShowDO_User_Message();
            }

            cbxProgramSelect.SelectedIndex = programParameters.Current_Program;
            
            ScanResultImage();//开一个新线程用来保存结果图片
            ScanRowImage();//保存原始图

            ReadConfigure();//从csv文件中读取配置
            ScanImageProcess();//开始检测

            ScanIOSignals();
            ScanTime();

        }


        private void CbxHistoryIndexAdd()
        {

            cbxHistoryData.Items.Clear();
            for (int i = 1; i <= programParameters.MeasureDeep; i++)
            {
                cbxHistoryData.Items.Add(i);
            }
            
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

            if (fil.Count() != 20)
            {
                MessageBox.Show(measure_path + "  不存在");
            }
            for (int i = 0; i < 10; i++)
            {
                RAF_Configure_Path.Add(fil[i]);
            }

            for (int i = 10; i < 19; i++)
            {
                DO_Configure_Path.Add(fil[i]);
            }

            Check_Configure_Path = fil[19];
        }
        private ProgramParameters ReadParameters()
        {
            return CustomerSerialize.XmlDeserialize<ProgramParameters>(@"Config/Data.xml");
        }
        private void Read_Vpp_Path()
        {
            filenames = System.IO.File.ReadAllLines(@"Config\VPP_Config.txt");

            var raf = CogSerializer.LoadObjectFromFile(filenames[0]) as CogToolBlock;
            var dodd = CogSerializer.LoadObjectFromFile(filenames[1]) as CogToolBlock;
            var check = CogSerializer.LoadObjectFromFile(filenames[2]) as CogToolBlock;
            cogtool_RAF.Subject = raf;
            cogtool_DO.Subject = dodd;
            cogtool_Check.Subject = check;

            dataGrid_Check.DataSource = (DataTable)check.Outputs["Data"].Value;

            cogtool_RAF.Subject.Ran += cogtool_RAF_Ran;
            cogtool_DO.Subject.Ran += cogtool_DO_Ran;
            cogtool_Check.Subject.Ran += cogtool_Check_Ran;
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
            //444
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
                    try
                    {


                        var temp = RowImageSave.Take();
                        if (!Directory.Exists(temp.Path))
                        {
                            Directory.CreateDirectory(temp.Path);
                        }
                        temp.image.Save(temp.Path + "/" + DateTime.Now.ToString("hh-mm-ss-ff") + ".png");
                    }
                    catch(Exception ex)
                    {

                    }
                    /*
                    try
                    {
                        foreach (var item in RowImageSave.GetConsumingEnumerable())
                        {

                            if (!Directory.Exists(item.Path))
                            {
                                Directory.CreateDirectory(item.Path);
                            }
                            item.image.Save(item.Path + "/" + DateTime.Now.ToString("hh-mm-ss-ff") + ".png");

                        }

                        Task.Delay(TimeSpan.FromSeconds(200));
                    }
                    catch(System.ObjectDisposedException ex)
                    {
                        return;
                    }*/
                }
            });
        }

        private void ScanResultImage()
        {
            Task.Factory.StartNew(() => {
            while (true)
            {
                    try
                    {


                        var temp = ResultImageSave.Take();
                        if (!Directory.Exists(temp.Path))
                        {
                            Directory.CreateDirectory(temp.Path);
                        }

                        temp.image.Save(temp.Path + "/" + DateTime.Now.ToString("hh-mm-ss-ff") + ".png");
                    }
                    catch(Exception ex )
                    {

                    }
                    /*
                    try
                    {
                        foreach (var item in ResultImageSave.GetConsumingEnumerable())
                        {

                            if (!Directory.Exists(item.Path))
                            {
                                Directory.CreateDirectory(item.Path);
                            }
                            item.image.Save(item.Path + "/" + DateTime.Now.ToString("hh-mm-ss-ff") + ".png");

                        }

                        Task.Delay(TimeSpan.FromSeconds(200));
                    }
                    catch(System.ObjectDisposedException ex)
                    {
                        return;
                    }*/

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

        public Action<List<WaveData>,int,int,string> Sendmsg;
        private void FormMain_Load(object sender, EventArgs e)
        {
            Init();
            BtnWave.Enabled = false;
      

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Currnet_Camera?.Close();
            ScanPCI?.Dispose();
           // ImageProcess_Task.CompleteAdding();
          //  cancel.Cancel(); 

            Task.Delay(TimeSpan.FromMilliseconds(100));
            Currnet_PCI?.Release();
            RowImageSave.CompleteAdding();
            ResultImageSave.CompleteAdding();
            

            CustomerSerialize.XMLSerialize<ProgramParameters>(programParameters);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// Program switch
        {

            if(programParameters.Current_Program == cbxProgramSelect.SelectedIndex)
            {
                return;
            }
            
            if(ChangeCurrentProgram(cbxProgramSelect.SelectedIndex))
            {
                MessageBox.Show("切换完成");
            }

            
        }


        private bool ChangeCurrentProgram(int _programID)
        {
            if(_programID == programParameters.Current_Program)
            {
                return false;
            }

            MeasureDataQuene.Clear();
            if (first_change)
            {
                first_change = false;
                //return false;
            }

            if (_programID == 0)
            {

                programParameters.Current_Program = 0;

                ShowRAF_User_Message();
               // Tool_SetInputs(cogtool_DO.Subject.Inputs["Image"].Value as CogImage8Grey, cogtool_DO);
                SaveToolBlock(cogtool_DO, filenames[1]);
                mDisplay1Row.Image = cogtool_RAF.Subject.Inputs["Image"].Value as CogImage8Grey;

                var tab = GetProductTable(cogtool_RAF);
                ShowRecord(0,ref  tab, "RAF", false,false,false);

                ReadConfigure();
            }
            if (_programID == 1)
            {

                programParameters.Current_Program = 1;
                ShowDO_User_Message();
              //  Tool_SetInputs(cogtool_RAF.Subject.Inputs["Image"].Value as CogImage8Grey, cogtool_RAF);

                SaveToolBlock(cogtool_RAF, filenames[0]);
                mDisplay1Row.Image = cogtool_DO.Subject.Inputs["Image"].Value as CogImage8Grey;

                var tab = GetProductTable(cogtool_DO);
                ShowRecord(0,ref tab, "DO", false,false,false);


                ReadConfigure();

            }
            return true;
        }

        private void cbxHistoryData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(cbxHistoryData.Text) -1;
            // count = programParameters.MeasureDeep - count;
         //   int index = MeasureDataQuene.CurrentCount - count;


            if (count < MeasureDataQuene.CurrentCount)
            {
                var table = MeasureDataQuene[count];
                string programString = programParameters.Current_Program == 0 ? "RAF" : "DO";
                ShowRecord(0,ref table, programString, false,false,true);
            }
            else
            {
                MessageBox.Show("当前选择的历史纪录不存在");
            }

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

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            
            camera.SetIOEvent += SetIO;
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

                Currnet_PCI.Init();
                

              //  Currnet_Camera.ImageEvent += ProcessImage;


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
            ImageProcess_Task.Add(new ImageProcess { Image = mDisplay1Row.Image,Program = programParameters.Current_Program,RunTime=1});



        }

        //Trigger Once
        private void btnRunOnce_Click(object sender, EventArgs e)
        {

            Second_Trigger();
            


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

        void cogtool_Check_Ran(object sender, EventArgs e)
        {

            mDisplay1Result.Image = cogtool_Check.Subject.Inputs["Image"].Value as CogImage8Grey;

            var temp = cogtool_Check.Subject.CreateLastRunRecord().SubRecords["OutputImage"];

            cogDisplay_Check.Record = temp;



            cogDisplay_Check.Fit(true);
           

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
                    ImageProcess_Task.Add(new ImageProcess { Image = e.CameraImage.Copy( CogImageCopyModeConstants.CopyPixels),Program = programParameters.Current_Program ,RunTime = 1});
                    break;
                case Command.Grab2:
                    ImageProcess_Task.Add(new ImageProcess { Image = e.CameraImage.Copy( CogImageCopyModeConstants.CopyPixels), Program = programParameters.Current_Program, RunTime = 2 });
                    //RunningOnce_Second(e.CameraImage);
                    break;
                case Command.Grab_Check:

                    RunningCheck(e.CameraImage.Copy(CogImageCopyModeConstants.CopyPixels));
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
                    cogtool_RAF.Subject.Inputs["TiePian"].Value = ((DataTable)dataGrid_TiePian.DataSource).Copy();

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
        private ProductTables GetProductTable(Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 _showTool)
        {
            ProductTables product = new ProductTables();
            switch (_showTool.Name.Replace("cogtool_", ""))
            {
                case "RAF":
                    var temp = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_L_L"].Value).Copy();
                    product.Beam_Touch_Window_L_L = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_L_R"].Value).Copy();
                    product.Beam_Touch_Window_L_R = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Tip_To_Window_L"].Value).Copy();
                    product.Beam_Tip_To_Window_L = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_R_L"].Value).Copy();
                    product.Beam_Touch_Window_R_L = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_R_R"].Value).Copy();
                    product.Beam_Touch_Window_R_R = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Tip_To_Window_R"].Value).Copy();
                    product.Beam_Tip_To_Window_R = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Height_L"].Value).Copy();
                    product.Beam_Height_L = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Height_R"].Value).Copy();
                    product.Beam_Height_R = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Inner_L"].Value).Copy();
                    product.Beam_Inner_L = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Inner_R"].Value).Copy();
                    product.Beam_Inner_R = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Beam_Height_Difference"].Value).Copy();
                    product.Beam_Height_Difference = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Shield_Flatness"].Value).Copy();
                    product.Shield_Flatness = temp;


                    temp = ((DataTable)_showTool.Subject.Outputs["Cross_Shield_TP"].Value).Copy();
                    product.Cross_Shield_TP = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Wafer_Thickness"].Value).Copy();
                    product.Wafer_Thickness = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["Shield_Cross_Angle"].Value).Copy();
                    product.Shield_Cross_Angle = temp;

                    temp = ((DataTable)_showTool.Subject.Outputs["TiePian"].Value).Copy();
                    product.TiePian = temp;


                    object ngnum = _showTool.Subject.Outputs["Current_NG_Num"].Value;
                    product.Current_NG_Num =Convert.ToInt32( ngnum.ToString()) ;

                    mDisplay1Result.Image = (cogtool_RAF.Subject.Inputs["Image"].Value as CogImage8Grey).Copy();
                    var ImageRecord1 = cogtool_RAF.Subject.CreateLastRunRecord().SubRecords["OutputImage"];
                    product.Image = ImageRecord1;
                   
                    

                    break;
                case "DO":

                    var temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_L_L"].Value).Copy(); 
                      product.Beam_Touch_Window_L_L = temp2;


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_L_R"].Value).Copy();
                    product.Beam_Touch_Window_L_R = temp2;


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Tip_To_Window_L"].Value).Copy();
                    product.Beam_Tip_To_Window_L = temp2;


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_R_L"].Value).Copy();
                    product.Beam_Touch_Window_R_L = temp2;


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Touch_Window_R_R"].Value).Copy();
                    product.Beam_Touch_Window_R_R = temp2;

                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Tip_To_Window_R"].Value).Copy();
                    product.Beam_Tip_To_Window_R = temp2;

                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Height_L"].Value).Copy();
                    product.Beam_Height_L = temp2;

                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Height_R"].Value).Copy();
                    product.Beam_Height_R = temp2;


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Inner_L"].Value).Copy();
                    product.Beam_Inner_L = temp2;


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Inner_R"].Value).Copy();
                    product.Beam_Inner_R = temp2;

                    temp2 = ((DataTable)_showTool.Subject.Outputs["Beam_Height_Difference"].Value).Copy();
                    product.Beam_Height_Difference = temp2;

                    temp2 = ((DataTable)_showTool.Subject.Outputs["Shield_Plate_Flatness"].Value).Copy();
                    product.Shield_Flatness = temp2;


                    temp2 = ((DataTable)_showTool.Subject.Outputs["Shield_Plate_To_Tower"].Value).Copy();
                    product.Cross_Shield_TP = temp2;

                    temp2 = ((DataTable)_showTool.Subject.Outputs["Shield_Blade_TP"].Value).Copy();
                    product.Wafer_Thickness = temp2;

                    temp2 = ((DataTable)_showTool.Subject.Outputs["Angle"].Value).Copy();
                    product.Shield_Cross_Angle = temp2;

                    object ngnum1 = _showTool.Subject.Outputs["Current_NG_Num"].Value;
                    product.Current_NG_Num = Convert.ToInt32(ngnum1.ToString());

                    mDisplay1Result.Image = cogtool_DO.Subject.Inputs["Image"].Value as CogImage8Grey;
                    var ImageRecord2 = cogtool_DO.Subject.CreateLastRunRecord().SubRecords["OutputImage"];
                    product.Image = ImageRecord2;


                    break;
                default:
                    break;


            }
            return product;
        }

        public delegate void delegatea(List<WaveData> wd, int indexx, int Count, string name, string program);
        private void RunningOnce_First(CogImage8Grey image,int _program)
        {
            mDisplay1Row.Image = image;
            mDisplay1RowShow.Image = image;
            CogImage8Grey _image = image;
            Bitmap aa = image.ToBitmap();



            this.PerformSafely(()=> {
                lblStatus.Text = "开始检测....";
                lblStatusShow.Text = "开始检测....";
                PCI_ImageOK_Signal();//拍照完成脉冲显示
                PCI_CloseSignal_OK();
                PCI_CloseSignal_NG();

                lblStatus.ForeColor = Color.Black;
                lblStatusShow.ForeColor = Color.Black;

                
            });
            



            if (_program == 0)//RAF
            {

               

                RowImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[3], image = aa });

                Stopwatch ss = new Stopwatch();
                ss.Start();
                Tool_SetInputs(_image, cogtool_RAF);
                
                Currnet_PCI?.Clear4Light();
                cogtool_RAF.Subject.Run();

           
               
               
                this.PerformSafely(()=> {
                    var tab=GetProductTable(cogtool_RAF);
                    tab.RowImage = _image;

                       
                        
                    if (isClick == false)
                    {

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(textBox3.Text))
                        {
                            MessageBox.Show("请选择行");
                        }
                        else
                        {
                            WaveDisplay(tab, ref WaveData);
                            Wavedata_Raf.Add(WaveData);
                            int count = Wavedata_Raf.Count * (Wavedata_Raf[0].Beam_Height_L.Count());//meishayong
                            delegatea a = new delegatea(wavepatten.ReceiveMsg);
                            a(Wavedata_Raf, Convert.ToInt32(textBox3.Text), count, waveName, "RAF");
                            LabelWaveDataCnt.Text = "共有" + Wavedata_Raf.Count.ToString() + "个数据。";
                        }
                       

                    }


                   
                    ShowRecord(0,ref tab, "RAF",true,true,false);
                    MeasureDataQuene.Add(tab);

                    LightShow();




                });
                
                ss.Stop();             
                this.PerformSafely(() => {
                    
                    Console.WriteLine(ss.ElapsedMilliseconds.ToString());
                    txtTime.Text = ss.ElapsedMilliseconds.ToString();
                });
            }

            else
            {
              
                RowImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[6], image = aa }) ;
             
                
                CogStopwatch ss = new CogStopwatch();
                ss.Start();
               
                Tool_SetInputs(_image, cogtool_DO);
                Currnet_PCI?.Clear4Light();
                cogtool_DO.Subject.Run();
                
               

                this.PerformSafely(()=> {
              //      Currnet_PCI?.Open4Light();
                //    Second_Trigger();

                    var tab = GetProductTable(cogtool_DO);
                    tab.RowImage = _image;
                    
                       
                    if (isClick == false)
                    {

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(textBox3.Text))
                        {
                            MessageBox.Show("请选择行");
                        }
                        else
                        {
                            WaveDisplay(tab, ref WaveData);
                            Wavedata_Do.Add(WaveData);
                            int count = Wavedata_Do.Count * (Wavedata_Do[0].Beam_Height_L.Count());//meishayong  
                            delegatea a = new delegatea(wavepatten.ReceiveMsg);
                            a(Wavedata_Do, Convert.ToInt32(textBox3.Text), count, waveName, "DO");
                            LabelWaveDataCnt.Text = "共有" + Wavedata_Do.Count.ToString() + "个数据。";
                        }

                    }
                    
                    ShowRecord(0,ref tab, "DO", true,true,false);
                    MeasureDataQuene.Add(tab);
                    LightShow();
                });
                
                ss.Stop();
                this.PerformSafely(() => {

                    Console.WriteLine(ss.Milliseconds.ToString());
                    txtTime.Text = ss.Milliseconds.ToString();

                });
                           
                  
          
            }
            
        }





        private void LightShow()
        {
            var historyResults = MeasureDataQuene.GetResults();
            customerLights.SetColor(historyResults);
            
        }


        

        private void RunningOnce_Second(CogImage8Grey _image,int programID)
        {

            Currnet_PCI.Clear5Light();

            mDisplay2Row.Image = _image;
            mDisplay2RowShow.Image = _image;

            mDisplay2Result.Image = _image;
            mDisplay2ResultShow.Image = _image;
            switch (programID)
            {
                case 0:
                    cogtool_RAF.Subject.Inputs["Image_T"].Value = _image;
                    break;
                case 1:
                    cogtool_DO.Subject.Inputs["Image_T"].Value = _image;
                    break;
                default:
                    break;
            }


            

            First_Trigger();


            
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
                            RunningOnce_Second(temp.Image as CogImage8Grey,temp.Program);
                            break;
                        default:
                            break;
                    }
                   
                }

            });
        }

        private void ShowHistoryMeasureData(int index)
        {
            var table = MeasureDataQuene[index];
            string name = programParameters.Current_Program == 0 ? "RAF" : "DO";
            ShowRecord(0,ref table, name,false,false,false);
        }

        


        #endregion

        #region  FileName Change 
       


        /// <summary>
        /// 1.时间变化
        /// 2.被拷贝走的话，要在生成
        /// </summary>
        private void ScanTime()
        {
            int temp = programParameters.ImageDeleteNum;
            Observable.Interval(TimeSpan.FromSeconds(1)).Subscribe(
                x => {
                    var current = DateTime.Now.ToString("yyyy-MM-dd");
                    if (last_time != current)
                    {
                        SetCurrentFileName();
                        last_time = current;
                        DeleteImages(temp);
                    }
                });
        }


       





        #endregion

        #region PCI IO Signls,

        private void ScanIOSignals()
        {
            bool trigger_last_signal = false;
            bool trigger_current_signal = false;

            bool switch8_last_sigal = false;
            bool switch8_current_sigal = false;


            bool switch12_last_sigal = false;
            bool switch12_current_sigal = false;


            bool check_last_signal = false;
            bool check_current_signal = false;

            uint current_signls;

            ScanPCI = Observable.Interval(TimeSpan.FromMilliseconds(10)).Buffer(1).Subscribe(
                x => {
                    
                    current_signls = Currnet_PCI.Read();

                    trigger_current_signal = (current_signls & PCI7230.PCI_IN4) == PCI7230.PCI_IN4 ? true : false;
                    switch8_current_sigal = (current_signls & PCI7230.PCI_IN1) == PCI7230.PCI_IN1 ? true : false;
                    switch12_current_sigal = (current_signls & PCI7230.PCI_IN0) == PCI7230.PCI_IN0 ? true : false;

                    check_current_signal = (current_signls & PCI7230.PCI_IN3) == PCI7230.PCI_IN3 ? true : false;


                    //get io signal
                    if (trigger_current_signal == true && trigger_last_signal == false)
                    {
                        Second_Trigger();
                       // First_Trigger();
                    
                    }
                    


                    if (switch8_current_sigal == true && switch8_last_sigal == false)
                    {
                        this.PerformSafely(()=> {

                            ChangeCurrentProgram(1);
                            cbxProgramSelect.SelectedIndex = 1;
                        });

                        PCI_Change_Program_OK();//程序切换完成后，发送切换完成信号
                    }

                    if (switch12_current_sigal == true && switch12_last_sigal == false)
                    {
                        this.PerformSafely(() => {
                            ChangeCurrentProgram(0);
                            cbxProgramSelect.SelectedIndex = 0;
                        });
                        
                        PCI_Change_Program_OK();//程序切换完成后，发送切换完成信号
                    }

                    //点检
                    if(check_current_signal == true && check_last_signal == false)
                    {/*
                        Currnet_PCI.Open4Light();
                        Currnet_Camera.ShuterCur = 65000; //(long)programParameters.RAF_Exposure;
                        Currnet_Camera.GainCur = 0; //(long)programParameters.RAF_Gain;

                        Currnet_Camera.OneShot(Command.Grab_Check);*/
                    }

                    trigger_last_signal = trigger_current_signal;
                    switch8_last_sigal = switch8_current_sigal;
                    switch12_last_sigal = switch12_current_sigal;
                    check_last_signal = check_current_signal;
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

        public void SetIO(string _io, bool _checked)
        {
            switch (_io)
            {
                case "0":
                    if (_checked)
                    {
                        Currnet_PCI.WriteIO0();
                    }
                    else
                    {
                        Currnet_PCI.ClearIO0();
                    }
                    break;
                case "1":
                    if (_checked)
                    {
                        Currnet_PCI.WriteIO1();
                    }
                    else
                    {
                        Currnet_PCI.ClearIO1();
                    }
                    break;
                case "2":
                    if (_checked)
                    {
                        Currnet_PCI.WriteIO2();
                    }
                    else
                    {
                        Currnet_PCI.ClearIO2();
                    }
                    break;
                case "3":
                    if (_checked)
                    {
                        Currnet_PCI.WriteIO3();
                    }
                    else
                    {
                        Currnet_PCI.ClearIO3();
                    }
                    break;

                case "8":
                    if (_checked)
                    {
                        Currnet_PCI.WriteIO8();
                    }
                    else
                    {
                        Currnet_PCI.ClearIO8();
                    }
                    break;
                default:
                    break;
            }
        }

        private void PCI_OK_Signal()
        {
            Currnet_PCI?.WriteIO4();
            Thread.Sleep(50);
            Currnet_PCI?.ClearIO4();
        }

        private void PCI_NG_Signal()
        {
            Currnet_PCI?.WriteIO5();
            Thread.Sleep(50);
            Currnet_PCI?.ClearIO5();
        }

        private void PCI_ImageOK_Signal()
        {
            Currnet_PCI?.WriteIO6();
            Thread.Sleep(100);
            Currnet_PCI?.ClearIO6();
        }

        private void PCI_Change_Program_OK()
        {
            Currnet_PCI?.WriteIO7();
            Thread.Sleep(50);
            Currnet_PCI?.ClearIO7();
        }

        private void PCI_CloseSignal_OK()
        {
            Currnet_PCI?.ClearIO4();
        }
        private void PCI_CloseSignal_NG()
        {
            Currnet_PCI?.ClearIO5();
        }
        private void PCI_OpenSignal_OK()
        {
            Currnet_PCI?.WriteIO4();
        }
        private void PCI_OpenSignal_NG()
        {
            Currnet_PCI?.WriteIO5();
        }

        private void First_Trigger()
        {
            if (programParameters.Current_Program == 0)
            {
                Currnet_PCI?.Open4Light();
                Currnet_Camera.ShuterCur = (long)programParameters.RAF_Exposure;
                Currnet_Camera.GainCur = (long)programParameters.RAF_Gain;
                

            }
            else
            {
                //8pair为了保留
                Currnet_PCI?.Open4Light();
                Currnet_Camera.ShuterCur = (long)programParameters.DO_Exposure1;
                Currnet_Camera.GainCur = (long)programParameters.DO_Gain1;
                


            }
            Currnet_Camera.OneShot(Command.Grab);

        }
        private void Second_Trigger()
        {
            
            if (programParameters.Current_Program == 0)
            {
                Currnet_PCI?.Open5Light();//改变光源

                Currnet_Camera.ShuterCur = (long)programParameters.RAF_Exposure2;
                Currnet_Camera.GainCur = (long)programParameters.RAF_Gain2;


                Currnet_Camera.OneShot(Command.Grab2);
               // First_Trigger();


            }
            else
            {
                
                Currnet_PCI?.Open5Light();//改变光源

                Currnet_Camera.ShuterCur = (long)programParameters.DO_Exposure2;
                Currnet_Camera.GainCur = (long)programParameters.DO_Gain2;


                Currnet_Camera.OneShot(Command.Grab2);


            }


        }
        #endregion

        #region Get Excel Configure And Update table
        private void ReadConfigure()
        {


            var checktemp = CustomerCsvHelper.ReadParameters(Check_Configure_Path);
            UpdateConfigure(checktemp,ref dataGrid_Check);

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

                temp = CustomerCsvHelper.ReadParameters(RAF_Configure_Path[9]);
                UpdateConfigure(temp, ref dataGrid_TiePian);


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
                //tempt.Rows[i]["上限"] = temp[i].Max.ToString();
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
       

       

        private bool ShowResultTableChild(ref bool _all_result ,ref DataGridView _grid, DataTable _table,bool isNeedSave,ref string dataS)
        {
            bool isok = true;//标红的标志位
           
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



        private void ModifyDataGridChild(ref DataGridView _modifyGrid,DataTable temp, bool _save_data,ref string _data_string,ref bool _allok)
        {
           
            _modifyGrid.DataSource = null;
            _modifyGrid.DataSource = temp;
            _modifyGrid.Columns["偏移"].Visible = false;
            ShowResultTableChild(ref _allok, ref _modifyGrid, temp, _save_data, ref _data_string);
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="_tables"></param>
        /// <param name="_do"></param>
        /// <param name="_is_save"></param>
        private void ShowRecord(int index,ref ProductTables _tables,string _do,bool _is_save,bool _isFirstOutput,bool isShowRecord)
        {
            bool is_allOK = true;
            string data_string = "";

            var temp = _tables.Beam_Touch_Window_L_L.Copy();
            ModifyDataGridChild(ref dataGrid_Beam_Touch_Window_L_L, temp, false, ref data_string, ref is_allOK);


            temp = _tables.Beam_Touch_Window_L_R.Copy();
            ModifyDataGridChild(ref dataGrid_Beam_Touch_Window_L_R, temp, false, ref data_string, ref is_allOK);


            temp = _tables.Beam_Tip_To_Window_L.Copy();
            ModifyDataGridChild(ref dataGrid_Beam_Tip_To_Window_L, temp, false, ref data_string, ref is_allOK);


            temp = _tables.Beam_Touch_Window_R_L.Copy();
            ModifyDataGridChild(ref dataGrid_Beam_Touch_Window_R_L, temp, false, ref data_string, ref is_allOK);


            temp = _tables.Beam_Touch_Window_R_R.Copy();
            ModifyDataGridChild(ref dataGrid_Beam_Touch_Window_R_R, temp, false, ref data_string, ref is_allOK);


            temp = _tables.Beam_Tip_To_Window_R.Copy();
            ModifyDataGridChild(ref dataGrid_Beam_Tip_To_Window_R, temp, false, ref data_string, ref is_allOK);


            temp = _tables.Beam_Height_L.Copy();
            ModifyDataGridChild(ref dataGrid_Beam_Height_L, temp, true, ref data_string, ref is_allOK);



            temp = _tables.Beam_Height_R.Copy();
            ModifyDataGridChild(ref dataGrid_Beam_Height_R, temp, true, ref data_string, ref is_allOK);


            temp = _tables.Beam_Inner_L.Copy();
            ModifyDataGridChild(ref dataGrid_Beam_Inner_L, temp, true, ref data_string, ref is_allOK);


            temp = _tables.Beam_Inner_R.Copy();
            ModifyDataGridChild(ref dataGrid_Beam_Inner_R, temp, true, ref data_string, ref is_allOK);


            temp = _tables.Beam_Height_Difference.Copy();
            ModifyDataGridChild(ref dataGrid_Beam_Height_Difference, temp, true, ref data_string, ref is_allOK);


            temp = _tables.Shield_Flatness.Copy();
            ModifyDataGridChild(ref dataGrid_Shield_Flatness, temp, true, ref data_string, ref is_allOK);



            temp = _tables.Cross_Shield_TP.Copy();
            ModifyDataGridChild(ref dataGrid_Cross_Shield_TP, temp, true, ref data_string, ref is_allOK);


            temp = _tables.Wafer_Thickness.Copy();
            ModifyDataGridChild(ref dataGrid_Wafer_Thickness, temp, true, ref data_string, ref is_allOK);

            temp = _tables.Shield_Cross_Angle.Copy();
            ModifyDataGridChild(ref dataGrid_Shield_Cross_Angle, temp, true, ref data_string, ref is_allOK);

            if(isShowRecord)
            {
                mDisplay1Result.Record = _tables.Image;
                mDisplay1ResultShow.Record = _tables.Image;
                mDisplay1Row.Image = _tables.RowImage;
                mDisplay1RowShow.Image = _tables.RowImage;
            }
            
            switch (_do)
            {
                case "RAF":
                    temp = _tables.TiePian.Copy();
                    ModifyDataGridChild(ref dataGrid_TiePian, temp, true, ref data_string, ref is_allOK);
                    data_string = DateTime.Now.ToString("hh:mm:ss,ff") + ";" + data_string;
                   
                    CheckRAFResult(is_allOK, _is_save, data_string, _isFirstOutput);
                   
                    break;
                case "DO":
                    data_string = DateTime.Now.ToString("hh:mm:ss,ff") + ";" + data_string;

                        CheckDOResult(is_allOK, _is_save, data_string, _isFirstOutput);
                    

                    break;

                default:
                    break;
            }

            _tables.Result = is_allOK;
        }

        private void CheckRAFResult(bool is_allOK,bool _save_data,string data_string,bool isfirstOutput)
        {

        
            if (is_allOK)
            {

                lbl_RAF_OKNG.BackColor = Color.Green;
                lbl_RAF_OKNG.Text = "OK";
                Label_max.BackColor = Color.Green;
                Label_max.Text = "OK";
                this.PerformSafely(() =>{lblStatus.Text = "检测成功，产品OK";
                    lblStatusShow.Text = "检测成功，产品OK";
                    lblStatus.ForeColor = Color.Green;
                    lblStatusShow.ForeColor = Color.Green;
                    if(isfirstOutput == true)
                    {
                        PCI_OpenSignal_OK();
                    }
                    
                    
                });
                
                if (_save_data)
                {

                    programParameters.RAF_OK_NUM++;
                    programParameters.RAF_ALL_NUM++;
                    ResultImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[1], image = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display) as Bitmap });

                }

              
            }
            else
            {
                lbl_RAF_OKNG.BackColor = Color.Red;
                lbl_RAF_OKNG.Text = "NG";
                Label_max.BackColor = Color.Red;
                Label_max.Text = "NG";
                this.PerformSafely(() =>{lblStatus.Text = "检测成功，产品NG";
                    lblStatusShow.Text = "检测成功，产品NG";
                    lblStatus.ForeColor = Color.Red;
                    lblStatusShow.ForeColor = Color.Red;
                    if (isfirstOutput == true)
                    {
                        PCI_OpenSignal_NG();
                    }
                        
                });
              
                if (_save_data)
                {
                    programParameters.RAF_NG_NUM++;
                    programParameters.RAF_ALL_NUM++;
                    ResultImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[2], image = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display) as Bitmap });

                }

               
            }
            if (_save_data)
            {
               
                SaveMeasureData_RAF(data_string, Current_File_Name[0]);
            }
            ShowRafNum(programParameters.RAF_ALL_NUM, programParameters.RAF_OK_NUM, programParameters.RAF_NG_NUM);
           
        }

        private void CheckDOResult(bool is_allOK,bool _save_data,string data_string,bool _isFistInit)
        {


            
            if (is_allOK)
            {
                lbl_DO_OKNG.BackColor = Color.Green;
                lbl_DO_OKNG.Text = "OK";
                Label_max.BackColor = Color.Green;
                Label_max.Text = "OK";
                this.PerformSafely(() => {lblStatus.Text = "检测成功，产品OK";
                    lblStatusShow.Text = "检测成功，产品OK";
                    lblStatus.ForeColor = Color.Green;
                    lblStatusShow.ForeColor = Color.Green;
                    if(_isFistInit==true)
                    {
                        PCI_OpenSignal_OK();
                    }
                    
                });

                if (_save_data)
                {
                    programParameters.DO_OK_NUM++;
                    programParameters.DO_ALL_NUM++;
                    ResultImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[4], image = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display) as Bitmap });
                }

            }
            else
            {

                lbl_DO_OKNG.BackColor = Color.Red;
                lbl_DO_OKNG.Text = "NG";
                Label_max.BackColor = Color.Red;
                Label_max.Text = "NG";
                this.PerformSafely(() => {lblStatus.Text = "检测成功，产品NG";
                    lblStatusShow.Text = "检测成功，产品NG";
                    lblStatus.ForeColor = Color.Red;
                    lblStatusShow.ForeColor = Color.Red;
                    if (_isFistInit == true)
                    {
                        PCI_OpenSignal_NG();
                    }
                        
                });
                if (_save_data)
                {
                    programParameters.DO_NG_NUM++;
                    programParameters.DO_ALL_NUM++;                   
                    ResultImageSave.Add(new ImageIndexAndImage { Path = Current_File_Name[5], image = mDisplay1Result.CreateContentBitmap(CogDisplayContentBitmapConstants.Display) as Bitmap });
                    
                }
            }
            if(_save_data)
            {
                
                SaveMeasureData_DO(data_string, Current_File_Name[7]);
            }

            ShowDONum(programParameters.DO_ALL_NUM, programParameters.DO_OK_NUM, programParameters.DO_NG_NUM);






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
                string head = "Number;";
                List<string> dataname = new List<string>();
                dataname.Add("Beam_L");
                dataname.Add("Beam_R");
                dataname.Add("Beam_Inner_L");
                dataname.Add("Beam_Inner_R");
                dataname.Add("Difference");
                dataname.Add("Shield");
                dataname.Add("Cross");
                dataname.Add("Wafer");
                dataname.Add("Angle");
                foreach (var item in dataname)
                {
                    for (int i = 1; i <= 96; i++)
                    {
                        head += item + "_" + i.ToString() + ";";
                    }
                }
                for (int i = 1; i <= 14; i++)
                {
                    head += "TiePian" + "_" + i.ToString() + ";";
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
                string head = "Number;";
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
                            for (int j = 1; j <= 8; j++)
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

        #region  DataGridView Paint Event 

        private void DataGridBindEvent()
        {

            var finds = this.FindControls<DataGridView>("");
          
            foreach (var item in finds)
            {
                if (item is DataGridView && item.Name.Contains("dataGrid"))
                {
                    item.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                    item.RowPrePaint += dataGridView1_RowPrePaint;
                    item.AllowUserToAddRows = false;
                    item.ReadOnly = true;
                    item.Dock = DockStyle.Fill;

                }
            }
        
           



        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var temp = (DataGridView)sender;
           
            string isok = temp.Rows[e.RowIndex].Cells[7].Value.ToString();

            if (isok =="False" )
            {
                temp.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
            
        }
        private void WaveDisplay(ProductTables _tables,ref WaveData wavedata)
        {
            wavedata = new WaveData();
            
            var temp = _tables.Beam_Height_L.AsEnumerable();
            var selectResult = temp.Select(x => x.Field<string>("结果")).ToArray();
            wavedata.Beam_Height_L = selectResult;

            temp = _tables.Beam_Height_R.AsEnumerable();
            selectResult = temp.Select(x => x.Field<string>("结果")).ToArray();
            wavedata.Beam_Height_R = selectResult;

            temp = _tables.Beam_Height_Difference.AsEnumerable();
            selectResult = temp.Select(x => x.Field<string>("结果")).ToArray();
            wavedata.Beam_Height_Difference = selectResult;

            temp = _tables.Cross_Shield_TP.AsEnumerable();
            selectResult = temp.Select(x => x.Field<string>("结果")).ToArray();
            wavedata.Cross_Shield_TP = selectResult;

            temp = _tables.Wafer_Thickness.AsEnumerable();
            selectResult = temp.Select(x => x.Field<string>("结果")).ToArray();
            wavedata.Wafer_Thickness= selectResult;

            temp = _tables.Shield_Flatness.AsEnumerable();
            selectResult = temp.Select(x => x.Field<string>("结果")).ToArray();
            wavedata.Shield_Flatness = selectResult;

            temp = _tables.Shield_Cross_Angle.AsEnumerable();
            selectResult = temp.Select(x => x.Field<string>("结果")).ToArray();
            wavedata.Shield_Cross_Angle = selectResult;


            temp = _tables.Beam_Inner_L.AsEnumerable();
            selectResult = temp.Select(x => x.Field<string>("结果")).ToArray();
            wavedata.Beam_Inner_L = selectResult;


            temp = _tables.Beam_Inner_R.AsEnumerable();
            selectResult = temp.Select(x => x.Field<string>("结果")).ToArray();
            wavedata.Beam_Inner_R = selectResult;


            wavedata.datetime = DateTime.Now;
           
        }


        #endregion


        #region 波动图
        private void BtnWave_Click(object sender, EventArgs e)
        {
            if (isClick == false)
            {
                isClick = true;
                BtnWave.Text = "正在记录数据。。";

                wavepatten.Show();
            }
            else
            {
                //Wavedata_Raf.Clear();
                //Wavedata_Do.Clear();
                isClick = false;
                BtnWave.Text = "不记录数据。。";
                wavepatten.Close();
            }


            //int count = Wavedata_Raf.Count * (Wavedata_Raf[0].Beam_Height_L.Count());//meishayong                 
            //delegatea a = new delegatea(wavepatten.ReceiveMsg);
            //if (string.IsNullOrEmpty(textBox1.Text))
            //{
            //    MessageBox.Show("请选择数据");
            //}
            //else
            //{
            //    a(Wavedata_Raf, Convert.ToInt32(textBox1.Text), count, waveName);

            //}

            //wavepatten.Show();

        }

        private void dataGrid_Beam_Touch_Window_L_L_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string rowindex = (e.RowIndex+1).ToString();

            BtnWave.Enabled = false;
            waveName = null;
            if (ra_Beam_Height_Difference.Checked)
            {
                BtnWave.Enabled = true;
                textBox3.Text = waveName;
                waveName = ra_Beam_Height_Difference.Name.Remove(0, 3);
                textBox3.Text = rowindex;
            }
            else if (ra_Beam_Height_R.Checked)
            {
                BtnWave.Enabled = true;
                textBox3.Text = waveName;
                waveName = ra_Beam_Height_R.Name.Remove(0, 3);
                textBox3.Text = rowindex;
            }
            else if (ra_Beam_Height_L.Checked)
            {
                BtnWave.Enabled = true;
                textBox3.Text = waveName;
                waveName = ra_Beam_Height_L.Name.Remove(0, 3);
                textBox3.Text = rowindex;
            }
            else if (ra_Shield_Flatness.Checked)
            {
                BtnWave.Enabled = true;
                textBox3.Text = waveName;
                waveName = ra_Shield_Flatness.Name.Remove(0, 3);
                textBox3.Text = rowindex;
            }
            else if (ra_Cross_Shield_TP.Checked)
            {
                BtnWave.Enabled = true;
                textBox3.Text = waveName;
                waveName = ra_Cross_Shield_TP.Name.Remove(0, 3);
                textBox3.Text = rowindex;
            }
            else if (ra_Wafer_Thickness.Checked)
            {
                BtnWave.Enabled = true;
                textBox3.Text = waveName;
                waveName = ra_Wafer_Thickness.Name.Remove(0, 3);
                textBox3.Text = rowindex;
            }
            else if (ra_Shield_Cross_Angle.Checked)
            {
                BtnWave.Enabled = true;
                waveName = ra_Shield_Cross_Angle.Name.Remove(0, 3);
                textBox3.Text = waveName;
                textBox3.Text = rowindex;
            }
            else if (ra_Beam_Inner_L.Checked)
            {
                BtnWave.Enabled = true;
                waveName = ra_Beam_Inner_L.Name.Remove(0, 3);
                textBox3.Text = waveName;
                textBox3.Text = rowindex;
            }
            else if (ra_Beam_Inner_R.Checked)
            {
                BtnWave.Enabled = true;
                waveName = ra_Beam_Inner_R.Name.Remove(0, 3);
                textBox3.Text = waveName;
                textBox3.Text = rowindex;
            }
            else
            {
                BtnWave.Enabled = false;
            }



        }


        private void btnClearaHistory_Click(object sender, EventArgs e)
        {
            Wavedata_Raf.Clear();
            Wavedata_Do.Clear();
            MessageBox.Show("已清除波动图数据");
            LabelWaveDataCnt.Text = "共有0个数据";
        }

        private void BtnWave_Click_1(object sender, EventArgs e)
        {

            if (isClick == false)
            {
                isClick = true;
                BtnWave.Text = "正在记录数据。。";

                wavepatten.Show();
            }
            else
            {
                //Wavedata_Raf.Clear();
                //Wavedata_Do.Clear();
                isClick = false;
                BtnWave.Text = "不记录数据。。";
                wavepatten.Close();
            }
        }
        #endregion



        #region 图片删除
        private void DeleteImages(int _deleteNum)
        {
            DateTime timepath = DateTime.Now;
            List<string> timepaths = new List<string>();
            for (int i = 0; i < _deleteNum; i++)
            {
                timepaths.Add(timepath.AddDays((-1) * i).ToString("yyyy-MM-dd"));
            }
            List<string> ImagePaths = new List<string>();
            ImagePaths.Add(SavePath.Image1ResultNG);
            ImagePaths.Add(SavePath.Image1ResultOK);
            ImagePaths.Add(SavePath.Image1Row);
            ImagePaths.Add(SavePath.Image2ResultNG);
            ImagePaths.Add(SavePath.Image2ResultOK);
            ImagePaths.Add(SavePath.Image2Row);
            List<string> tempNeedPath = new List<string>();
            foreach (var item in ImagePaths)
            {
                tempNeedPath.Clear();
                foreach (var ite in timepaths)
                {
                    tempNeedPath.Add(item + @"\" + ite);
                }
                string[] exitsDirectories = Directory.GetDirectories(item);
                foreach (var it in exitsDirectories)
                {
                    if (!tempNeedPath.Contains(it))
                    {
                        Directory.Delete(it, true);
                    }
                }


            }




        }







        #endregion




        #region Check,点检

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Currnet_PCI.Open4Light();
            Currnet_Camera.ShuterCur = 65000; //(long)programParameters.RAF_Exposure;
            Currnet_Camera.GainCur = 0; //(long)programParameters.RAF_Gain;

            Currnet_Camera.OneShot(Command.Grab_Check);
        }



        private void RunningCheck(CogImage8Grey image)
        {

            this.PerformSafely(() => {
                lblCheck_Message.Text = "开始检测....";

                lblCheck_Message.ForeColor = Color.Black;
            });
            cogtool_Check.Subject.Inputs["Image"].Value = image.Copy();
            cogtool_Check.Subject.Inputs["Data"].Value = ((DataTable)dataGrid_Check.DataSource).Copy();
            Currnet_PCI?.Clear4Light();
            cogtool_Check.Subject.Run();
            


            this.PerformSafely(() => {

                
                var result_table = (DataTable)cogtool_Check.Subject.Outputs["Data"].Value;
                dataGrid_Check.DataSource = result_table;
                var resultrow = result_table.AsEnumerable();
                var results = resultrow.Where(x => x.Field<string>("指示") == "False");
                if (results.Count()>0)
                {
                    lblCheck_Message.BackColor = Color.Red;
                    lblCheck_Message.Text = "NG";
                }
                else
                {
                    lblCheck_Message.BackColor = Color.Green;
                    lblCheck_Message.Text = "OK";
                }


            });

             
            

            

        }

        #endregion

    }


}
