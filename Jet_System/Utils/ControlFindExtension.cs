using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jet_System.Utils
{
    public static class ControlFindExtension
    {
        public static IEnumerable<T> FindControls<T>(this Control parentControl, string name)
        {
            if (parentControl is T)
            {
                if (string.IsNullOrEmpty(name))
                    yield return (T)(object)parentControl;
                else if (parentControl.Name.Contains(name))
                {
                    yield return (T)(object)parentControl;
                    yield break;
                }
            }
            var filteredControlList = from controlList in parentControl.Controls.OfType<Control>()
                                      where controlList is T || controlList.Controls.Count > 0
                                      select controlList;
            foreach (Control childControl in filteredControlList)
            {
                foreach (T foundControl in FindControls<T>(childControl, name))
                {
                    yield return foundControl;
                    if (!string.IsNullOrEmpty(name))
                        yield break;
                }
            }
        }





       
    }
}
