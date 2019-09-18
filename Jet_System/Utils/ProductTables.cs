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

        

        public Cognex.VisionPro.CogImage8Grey Image;
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
        public DataTable Shield_Plate_Flatness { set; get; }
        public DataTable Shield_Plate_To_Tower { set; get; }
        public DataTable Shield_Blade_TP { set; get; }
        public DataTable Angle { set; get; }

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
            Shield_Plate_Flatness.Dispose();
            Shield_Plate_To_Tower.Dispose();
            Shield_Blade_TP.Dispose();
            Angle.Dispose();
        }
    }
}
