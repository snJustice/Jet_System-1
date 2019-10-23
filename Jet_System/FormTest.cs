using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jet_System.Utils;
using Jet_System.Utils.MyQuene;

namespace Jet_System
{
    public partial class FormTest : Form
    {
        List<bool> l1 = new List<bool>() { true, false, true, false, true };
        List<bool> l2 = new List<bool>() { true, false, true, false, false , false, false, true, false, true };

        List<bool> l3 = new List<bool>() { true, false, true, false, true, false};

        ConcurrentQueue<int> con = new ConcurrentQueue<int>();
        CustomerQuene tabs = new CustomerQuene(10);
        bool result = true;
        int index = 0;

        
        public FormTest()
        {

            InitializeComponent();
            customerLightsPanel1.SetColor(l1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
            customerLightsPanel1.SetColor(tabs.GetResults());
            index++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Add()
        {
            DataTable ta = new DataTable();
            ProductTables temp = new ProductTables();
            temp.Beam_Height_Difference = ta;
            temp.Beam_Tip_To_Window_L = ta;
            temp.Beam_Touch_Window_L_R = ta;
            temp.Beam_Touch_Window_L_L = ta;

            temp.Beam_Touch_Window_R_L = ta;
            temp.Beam_Touch_Window_R_R = ta;
            temp.Beam_Tip_To_Window_R = ta;

            temp.Beam_Height_L = ta;
            temp.Beam_Height_R = ta;
            temp.Beam_Inner_L = ta;
            temp.Beam_Inner_R = ta;

            temp.Cross_Shield_TP = ta;
            temp.Shield_Cross_Angle = ta;

            temp.Shield_Flatness = ta;
            temp.TiePian = ta;
            temp.Wafer_Thickness = ta;
            temp.Result = index % 3 == 0 ? true : false;
            tabs.Add(temp);

        }
    }
}
