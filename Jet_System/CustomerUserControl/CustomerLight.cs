using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jet_System.CustomerUserControl
{
    public partial class CustomerLight : UserControl
    {
        public String Number { set { lblNumber.Text = value; } get { return lblNumber.Text; } }

        public Color Color { set {led.LEDSurroundColor = value;led.LEDCenterColor = value; } get { return led.LEDSurroundColor; } }

        public CustomerLight()
        {
            InitializeComponent();
        }
    }
}
