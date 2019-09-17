using Jet_System.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet_System.InterfaceUtils
{
    public interface IUserControlExtensionGenerate
    {
        void SetDisplay(Cognex.VisionPro.Display.CogDisplay _dis);


        void SetImage();

        ResultStringAndOkNG RunOnce(bool isRun);
        
    }
}
