using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet_System.Utils
{
    class ImageProcess
    {
        public int Program { set; get; }
        public Cognex.VisionPro.ICogImage Image { set; get; }
        public int RunTime { set; get; }
    }
}
