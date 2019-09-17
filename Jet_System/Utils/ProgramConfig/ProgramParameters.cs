using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet_System.Utils.ProgramConfig
{
    public class ProgramParameters
    {
        public string IP { set; get; }

        public bool IsStartConnect { set; get; }

        public double RAF_Exposure { set; get; } 

        public double RAF_Gain { set; get; }

        public double DO_Exposure1 { set; get; }

        public double DO_Gain1 { set; get; }

        public double DO_Exposure2 { set; get; }

        public double DO_Gain2 { set; get; }


        public int RAF_OK_NUM { set; get; }
        public int RAF_ALL_NUM { set; get; }
        public int RAF_NG_NUM { set; get; }

        public int DO_OK_NUM { set; get; }
        public int DO_ALL_NUM { set; get; }
        public int DO_NG_NUM { set; get; }

        public int Current_Program { set; get; }



    }
}
