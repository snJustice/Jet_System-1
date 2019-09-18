using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet_System.Utils
{
    public class ExcelHelper
    {
        XSSFWorkbook wb;
        XSSFSheet sheet;
        FileStream file;

        public ExcelHelper(string filename, string heads)
        {

            if (!filename.Contains(".csv"))
            {
                return;
            }
            if (!File.Exists(filename))
            {
                wb = new XSSFWorkbook();
                var sht = wb.CreateSheet("sheet1");
                var dataArray = heads.Split(';');
                var roe = sht.CreateRow(0);
                for (int i = 0; i < dataArray.Count(); i++)
                {
                    roe.CreateCell(i).SetCellValue(dataArray[i]);
                }
                file = new FileStream(filename, FileMode.Create);
                wb.Write(file);
                file.Close();
                Console.WriteLine("hello");
                Console.WriteLine("hello");

            }


            file = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite);

            wb = new XSSFWorkbook(file);
            sheet = (XSSFSheet)wb.GetSheet("sheet1");
        }
        public void WriteValue(string filename, string value)
        {
            var row = sheet.CreateRow(sheet.LastRowNum + 1);
            var dataArray = value.Split(';');
            for (int i = 0; i < dataArray.Count(); i++)
            {
                var temp = row.GetCell(i);
                row.CreateCell(i).SetCellValue(dataArray[i]);
            }


            //sheet.CreateRow(sheet.LastRowNum + 1).CreateCell(0).SetCellValue(value);
        }

        public void Save(string filename)
        {
            file = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite);
            wb.Write(file);
            file.Close();
            wb.Close();
        }
    }
}
