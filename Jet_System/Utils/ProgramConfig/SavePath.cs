using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet_System.Utils.ProgramConfig
{
    public class SavePath
    {
        public static string ImageRootPath { set; get; }
        public static string Image1ResultOK { set { } get { return ImageRootPath + "/12PR_OK"; } }//12PR_OK
        public static string Image1ResultNG { set { } get { return ImageRootPath + "/12PR_NG"; } }//12PR_NG

        public static string Image1Row { set { } get { return ImageRootPath + "/12PR_ROW"; } }//12PR_ROW
        public static string Image2ResultOK { set { } get { return ImageRootPath + "/8PR_OK"; } }//8PR_OK

        public static string Image2ResultNG { set { } get { return ImageRootPath + "/8PR_NG"; } }//8PR_NG
        public static string Image2Row { set { } get { return ImageRootPath + "/8PR_ROW"; } }//8PR_ROW
        public static string FileResult { set; get; }
    }
}
