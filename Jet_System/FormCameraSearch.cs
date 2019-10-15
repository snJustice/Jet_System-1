

using JC.Camera;
using Jet_System.Utils.ProgramConfig;
using MvCamCtrl.NET;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static MvCamCtrl.NET.MyCamera;
using Jet_System.Utils;
namespace Jet_System
{
    public delegate void SetIODelegate(string io, bool check);
    public partial class FormCameraSearch : Form
    {

        public CameraBase camera;
        public CameraOperator temp = new CameraOperator();

        public ProgramParameters programs;

        public PCI7230 CurrentPCI;

        public event SetIODelegate SetIOEvent;

        Dictionary<string, MyCamera.MV_CC_DEVICE_INFO> camerastring = new Dictionary<string, MV_CC_DEVICE_INFO>();

        public FormCameraSearch()
        {
            InitializeComponent();

            

            

        }





        private  void Init()
        {
            

            txtRAF_Exposure.Text = programs.RAF_Exposure.ToString();
            txt_DO_Exposure.Text = programs.DO_Exposure1.ToString();
            txt_DO_T_Exposure.Text = programs.DO_Exposure2.ToString();

            txtRAF_Gain.Text = programs.RAF_Gain.ToString();
            txt_DO_Gain.Text = programs.DO_Gain1.ToString();
            txt_DO_T_Gain.Text = programs.DO_Gain2.ToString();

            chbxStartConnect.Checked = programs.IsStartConnect;




        }

        private void btnTriggerOnce_Click(object sender, EventArgs e)
        {

         
            camera.OneShot(Command.Grab);

            



        }

        private void Formest_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cbxCameras.Items.Clear();
            camerastring = CameraOperator.EnumDevices();
            foreach (var item in camerastring)
            {
                cbxCameras.Items.Add(item.Key);
            }

            ShowButtonState(true, false, false, false, false, false, false,false,false,false);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            if(cbxCameras.Items.Count!=0)
            {
                temp = new CameraOperator();
                MyCamera.MV_CC_DEVICE_INFO cameraInfo;
                camerastring.TryGetValue(cbxCameras.Text,out cameraInfo);
                camera = new HikvisionCamera(temp, cameraInfo);
                camera.ImageEvent += ImagShow;
                camera.Open();
                camera.IP = cbxCameras.Text;

                ShowButtonState(true,true,true,false,true,true,true,true,true,true);
                txtGain.Text = camera.GainCur.ToString();
                txtExposure.Text = camera.ShuterCur.ToString();

            }
            
            
           
        }


        private void ImagShow(object sender, ImageEventArgs e)
        {

            DisplayBefore.Image = e.CameraImage;
        }

        private void btnStopLive_Click(object sender, EventArgs e)
        {
            camera.ContinuousShotStop();
            ShowButtonState(true, true, true, false, true, true, true,true,true,true);
        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            camera.ContinuousShot();

            ShowButtonState(true, true,false, true, true, true, true,true,true,true);

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            camera.ContinuousShotStop();
            ConnectedOk();
            Console.WriteLine(camera.ErrMessage);

        }


        private void ConnectedOk()
        {
            this.DialogResult = DialogResult.OK;
            programs.IsStartConnect = chbxStartConnect.Checked;
            programs.IP = camera.IP;
            camera.ImageEvent -= ImagShow;
            this.Close();
        }

        

        private void btnSetGain_Click(object sender, EventArgs e)
        {
            long gain = Convert.ToInt32(txtGain.Text);

            camera.GainCur = gain;

            long expu = Convert.ToInt32(txtExposure.Text);

            camera.ShuterCur = expu;
        }

        private void cbxCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void ShowButtonState(bool _open,bool _trigger_once, 
            bool _live, bool _stop_live, bool _set_gain, bool _set_exposure, bool _complete,
            bool _set_raf,bool _set_do,bool _set_do_t)
        {
            btnOpen.Enabled = _open;
            btnTriggerOnce.Enabled = _trigger_once;
            btnLive.Enabled = _live;
            btnStopLive.Enabled = _stop_live;
            btnSetGain.Enabled = _set_gain;
            btnSetExposure.Enabled = _set_exposure;
            btnComplete.Enabled = _complete;
            btnSetRaf.Enabled = _set_raf;
            btnSetDO.Enabled = _set_do;
            btnSetDO_T.Enabled = _set_do_t;


        }

        private void btnSetRaf_Click(object sender, EventArgs e)
        {
            programs.RAF_Exposure =Convert.ToDouble( txtExposure.Text);
            txtRAF_Exposure.Text = programs.RAF_Exposure.ToString();

            programs.RAF_Gain = Convert.ToDouble(txtGain.Text);
            txtRAF_Gain.Text = programs.RAF_Gain.ToString();

        }

        private void btnSetDO_Click(object sender, EventArgs e)
        {
            programs.DO_Exposure1 = Convert.ToDouble(txtExposure.Text);
            txt_DO_Exposure.Text = programs.DO_Exposure1.ToString();

            programs.DO_Gain1 = Convert.ToDouble(txtGain.Text);
            txt_DO_Gain.Text = programs.DO_Gain1.ToString();
        }

        private void btnSetDO_T_Click(object sender, EventArgs e)
        {
            programs.DO_Exposure2= Convert.ToDouble(txtExposure.Text);
            txt_DO_T_Exposure.Text = programs.DO_Exposure2.ToString();

            programs.DO_Gain2 = Convert.ToDouble(txtGain.Text);
            txt_DO_T_Gain.Text = programs.DO_Gain2.ToString();
        }

        private void FormCameraSearch_Load(object sender, EventArgs e)
        {
            Init();
            if(camera.IsLink)
            {
                camera.ImageEvent+= ImagShow;
                cbxCameras.Items.Add(programs.IP);
                cbxCameras.SelectedIndex = 0;
                ShowButtonState(true, true, true, false, true, true, true, true, true, true);

                txtGain.Text = camera.GainCur.ToString();
                txtExposure.Text = camera.ShuterCur.ToString();
            }
        }

        private void cbxIO1_CheckedChanged(object sender, EventArgs e)
        {


            var main = (FormMain)this.Parent;
            
            CheckBox cbx = (CheckBox)(sender);
            bool checkState = cbx.Checked;
            string ioCount = cbx.Name.Replace("cbxIO", "");
            SetIOEvent?.Invoke(ioCount, checkState);


        }
    }
}
