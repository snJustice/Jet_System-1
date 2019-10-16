using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Jet_System.Utils
{
    public class ProductTables:IDisposable
    {

        

        public Cognex.VisionPro.ICogRecord Image { set; get; }

        public bool Result { set; get; }

        public Cognex.VisionPro.ICogImage RowImage { set; get; }
        public DataTable Beam_Touch_Window_R_L { set; get; }
        public DataTable Beam_Touch_Window_R_R { set; get; }
        public DataTable Beam_Tip_To_Window_R { set; get; }
        public DataTable Beam_Touch_Window_L_L { set; get; }
        public DataTable Beam_Touch_Window_L_R { set; get; }
        public DataTable Beam_Tip_To_Window_L { set; get; }
        public DataTable Beam_Inner_L { set; get; }
        public DataTable Beam_Inner_R { set; get; }
        public DataTable Beam_Height_Difference { set; get; }
        public DataTable Beam_Height_L { set; get; }
        public DataTable Beam_Height_R { set; get; }
        public DataTable Shield_Flatness { set; get; }
        public DataTable Cross_Shield_TP { set; get; }
        public DataTable Wafer_Thickness { set; get; }
        public DataTable Shield_Cross_Angle { set; get; }

        public DataTable TiePian { get; set; }

        public int Current_NG_Num { set; get; }

        public void Dispose()
        {
            
            Beam_Touch_Window_R_L.Dispose();
            Beam_Touch_Window_R_R.Dispose();
            Beam_Tip_To_Window_R.Dispose();
            Beam_Touch_Window_L_L.Dispose();
            Beam_Touch_Window_L_R.Dispose();
            Beam_Tip_To_Window_L.Dispose();
            Beam_Height_Difference.Dispose();
            Beam_Height_L.Dispose();
            Beam_Height_R.Dispose();
            Beam_Inner_L.Dispose();
            Beam_Inner_R.Dispose();
            Shield_Flatness.Dispose();
            Cross_Shield_TP.Dispose();
            Wafer_Thickness.Dispose();
            Shield_Cross_Angle.Dispose();
            TiePian.Dispose();
        }
    }
}
