using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LEDLib;
namespace Jet_System.CustomerUserControl
{
    public partial class CustomerLights : UserControl
    {
        public CustomerLights()
        {
            InitializeComponent();
            LightCount = 2;
            LightLength = 5;
            LightRadius = 20;
            Init();
        }

        public int LightCount { set; get; }

        public int LightLength { set; get; }

        public int LightRadius { set; get; }

        private LEDControl[] Lights;


        public void Init()
        {
            Lights = new LEDControl[LightCount];
            for (int i = 0; i < LightCount; i++)
            {
                LEDControl light = new LEDControl();
                light.Location = new Point(i * (LightCount* LightRadius + LightLength), 0);
                light.Size = new Size(LightRadius, LightRadius);
                this.Controls.Add(light);
                Lights[i] = light;


            }
            InitLight();
        }

        public void InitLight()
        {
            foreach (var item in Lights)
            {
                item.ForeColor = Color.Black;
            }
        }

    }
}
