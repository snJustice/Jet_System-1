using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jet_System.Utils
{
    public class CustomerSerialize
    {
        public static void XMLSerialize<T>(T parameters)
        {
            XmlSerializer binformat = new XmlSerializer(typeof(T));

            string fileName = "Data.xml";
            if(File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (Stream fStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                
                binformat.Serialize(fStream, parameters);
            }
        }



        public static void XMLSerialize<T>(T parameters,string _File)
        {
            XmlSerializer binformat = new XmlSerializer(typeof(T));

            string fileName = _File;
            if(File.Exists(_File))
            {
                File.Delete(_File);
                
            }
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {

                binformat.Serialize(fStream, parameters);
            }
        }


        public static  T XmlDeserialize<T>()where T:class  
        {
            string fileName = "Data.xml";
            if (!File.Exists(fileName))
            {
                return null;
            }

            XmlSerializer binFormat = new XmlSerializer(typeof(T));
            
            using (Stream fStream = File.OpenRead(fileName))
            {
                try
                {
                    T pis = binFormat.Deserialize(fStream) as T;
                    return pis;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                return  null;
            }
        }


        public static T XmlDeserialize<T>(string file) where T : class
        {
            string fileName = file;
            if (!File.Exists(fileName))
            {
                return null;
            }

            XmlSerializer binFormat = new XmlSerializer(typeof(T));

            using (Stream fStream = File.OpenRead(fileName))
            {
                T pis = binFormat.Deserialize(fStream) as T;

                return pis;
            }
        }
    }
}
