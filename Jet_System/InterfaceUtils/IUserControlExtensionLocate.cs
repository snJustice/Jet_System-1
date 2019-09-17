using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet_System.InterfaceUtils
{
    public interface IUserControlExtensionLocate
    {
        void SetDisplay(Cognex.VisionPro.Display.CogDisplay _dis , Cognex.VisionPro.Display.CogDisplay _dis1);


        void SetImage();

        void RunOnce(bool isRun);

        void Init();
    }
}
