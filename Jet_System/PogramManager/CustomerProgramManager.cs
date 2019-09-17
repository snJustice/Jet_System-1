using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jet_System.PogramManager
{
    public class CustomerProgramManager
    {
        public static void SaveProgram<T>(T sss)
        {
            
            using (FileStream fsWriter = new FileStream(@"test.xml", FileMode.Create, FileAccess.Write))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(fsWriter, sss);
            }
        }

        public static T Read<T>() where T:class
        {
            T outputList ;
            using (FileStream fsReader = new FileStream(@"test.xml", FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                outputList = xs.Deserialize(fsReader) as T;
            }
            return outputList;
        }
    }
}
