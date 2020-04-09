using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jet_System
{
    public partial class FormTest : Form
    {
        List<bool> l1 = new List<bool>() { true, false, true, false, true };
        List<bool> l2 = new List<bool>() { true, false, true, false, false , false, false, true, false, true };

        List<bool> l3 = new List<bool>() { true, false, true, false, true, false};
        public FormTest()
        {

            InitializeComponent();
           // customerLightsPanel1.SetColor(l1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // customerLightsPanel1.SetColor(l2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // customerLightsPanel1.SetColor(l3);
        }
    }
}
