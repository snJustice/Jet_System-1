using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet_System.Utils
{
     public class WaveData
    {
        public string[] Beam_Height_Difference { set; get; }
        public string[] Beam_Height_L { set; get; }
        public string[] Beam_Height_R { set; get; }
        public string[] Shield_Flatness { set; get; }
        public string[] Cross_Shield_TP { set; get; }
        public string[] Wafer_Thickness { set; get; }
        public string[] Shield_Cross_Angle { set; get; }

        public DateTime datetime  { set; get; }
  
    }
}
