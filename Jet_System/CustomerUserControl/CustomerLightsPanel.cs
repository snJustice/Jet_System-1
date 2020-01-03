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
using Jet_System.Utils;
namespace Jet_System.CustomerUserControl
{
    public partial class CustomerLightsPanel : UserControl
    {
        public CustomerLightsPanel()
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
           
        }

        public void InitLight()
        {
           
        }



        public void SetColor(List<bool> _result,List<int> _emptys)
        {
           // var lights = this.FindControls<CustomerLight>("");
           // _result.Reverse();


            for (int i = 0; i < 10; i++)
            {
                var light = this.FindControl<CustomerLight>("customerLight" + (i + 1).ToString()).FirstOrDefault();
                if (i< _result.Count)
                {
                    if(_emptys[i] == 0)
                    {
                        light.Color = Color.Black;
                    }
                    else
                    {
                        if (_result[i])
                        {
                            light.Color = Color.Green;
                        }
                        else
                        {
                            light.Color = Color.Red;
                        }
                    }
                   

                }

                else
                {
                    light.Color = Color.Yellow;
                }
            }

            this.Refresh();
        }
    }
}
