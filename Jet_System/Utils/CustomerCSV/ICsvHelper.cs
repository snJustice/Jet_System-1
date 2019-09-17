using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet_System.Utils.CustomerCSV
{
    public interface ICsvHelper
    {
        void WriteHeader(string _fileName,string header);
        void WriteOneLine(string _fileName,string data);

        bool IsExistFile(string FileName);

        void CreateFile(string FileName);
    }
}
