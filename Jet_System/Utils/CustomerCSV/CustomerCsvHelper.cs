using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace Jet_System.Utils.CustomerCSV
{
    public class CustomerCsvHelper 
    {
        //private static  readonly string Root_path = "Data";

        public static void CreateFile(string FileName)
        {
            if(FileName.Contains(".csv"))
            {

               
                if (!File.Exists(FileName))
                {
                    using (File.Create(FileName))
                    {

                    }
                }
            }
            else
            {
                throw new Exception("不是csv文件，无法创建");
            }

            
        }

        public static bool IsExistFile(string FileName)
        {
            
            return File.Exists(FileName);
           
        }

        public static void WriteHeader(string _fileName,string header)
        {

            var writer = new StreamWriter(_fileName, true);
            using (var csv = new CsvWriter(writer))
            {
                csv.Configuration.HasHeaderRecord = false;
                
                csv.WriteField(header.Split(';'));
                

            }
        }

        public static void WriteOneLine(string _fileName,string data)
        {

            var writer = new StreamWriter(_fileName, true);
            using (var csv = new CsvWriter(writer))
            {
                csv.Configuration.HasHeaderRecord = false;
                csv.NextRecord();
                csv.WriteField(data.Split(';'));

            }
        }




        public static IEnumerable<ParametersConfigure> ReadParameters(string _filename)
        {
            var reader = new StreamReader(_filename);
            
              //  reader.ReadLine();
                using (var csv = new CsvReader(reader))
                {
                  //  csv.Configuration.HasHeaderRecord = false;
                    var records = csv.GetRecords<ParametersConfigure>().ToList();
                    return records;
                }
            
        }
    }
}
