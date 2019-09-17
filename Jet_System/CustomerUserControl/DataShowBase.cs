using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Jet_System.CustomerUserControl
{
    public partial class DataShowBase : UserControl
    {

        DataTable Measure_Data;
        MeasureSetting_Torrent data;

        public DataShowBase()
        {
            InitializeComponent();
            data = new MeasureSetting_Torrent();
            data.Count = 5;
            data.SetMax(20.0);
            data.SetMin(10.0);
            data.SetOffset(0.1);
            Measure_Data = new DataTable();
            Measure_Data.Columns.Add("5");
            var rr = Measure_Data.NewRow();
            rr["5"] = "00";
            Measure_Data.Rows.Add(rr);

            dataGridView1.DataSource = Measure_Data;
        }

        public void Serializer_()
        {
            XmlSerializer binForamt = new XmlSerializer(typeof(MeasureSetting_Torrent));
            string filename = "Setting.xml";
            using (Stream fstrem = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                binForamt.Serialize(fstrem,data);
            }
        }
    }


    [Serializable]
    public class MeasureSetting_Torrent
    {
        public  int Count { get; set; }
        
        public List<double> Max_list;
        public List<double> Min_list;
        public List<double> Offset_List;
        public List<double> Measure_list;
        public List<bool> Result_List;

        public MeasureSetting_Torrent()
        {
            Max_list = new List<double>();
            Min_list = new List<double>();
            Offset_List = new List<double>();
            Measure_list = new List<double>();
            Result_List = new List<bool>();
        }

        public void SetMax(double _max)
        {
            Max_list.Clear();
            for (int i =0;i<Count;i++){Max_list.Add(_max);}
        }
        public void SetMin(double _max)
        {
            Min_list.Clear();
            for (int i = 0; i < Count; i++) { Min_list.Add(_max); }
        }
        public void SetOffset(double _max)
        {
            Offset_List.Clear();
            for (int i = 0; i < Count; i++) { Offset_List.Add(_max); }
        }

        
       

    }
}
