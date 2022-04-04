using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Moodle_Ofline_Browser_Core;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Data;

namespace Moodle_Ofline_Browser_Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
           // Moodle_Ofline_Browser_Core.models.FullCourse fullCourse = MbzDecompressor.Extract(@"C:\Users\Adam\Downloads\test2.mbz");
            GenerateExcel();
        }

        public static void GenerateExcel()
        {

            // DataSet dataSet = new DataSet();
            //dataSet.Tables.Add(dataTable);

            // create a excel app along side with workbook and worksheet and give a name to it  
            Application excelApp = new Application();
            //Workbook excelWorkBook = excelApp.Workbooks.Add();
            Workbook excelWorkBook = excelApp.Workbooks.Add("cos");
            excelWorkBook.Worksheets[1].Name = "Sheet Name";
            excelWorkBook.Worksheets.Add();
            excelWorkBook.Worksheets[1].Name = "Se Name";

            Workbook activeworkbook = excelApp.ActiveWorkbook;

            //Worksheet newWorksheet;
            //newWorksheet = (Worksheet)excelWorkBook.Worksheets.Add();

            //excelWorkBook.Sheets.Add();

            //_Worksheet xlWorksheet = excelWorkBook.Sheets["Jakas nazwa"];
            //Range xlRange = xlWorksheet.UsedRange;



            //foreach (System.Data.DataTable table in dataSet.Tables)
            //{
            //    //Add a new worksheet to workbook with the Datatable name  
            //    Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
            //    excelWorkSheet.Name = table.TableName;

            //    // add all the columns  
            //    for (int i = 1; i < table.Columns.Count + 1; i++)
            //    {
            //        excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
            //    }

            //    // add all the rows  
            //    for (int j = 0; j < table.Rows.Count; j++)
            //    {
            //        for (int k = 0; k < table.Columns.Count; k++)
            //        {
            //            excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
            //        }
            //    }
            //}


            excelApp.Visible = true;
            excelApp.UserControl = true;
            // excelWorkBook.Save(); -> this is save to its default location  
            //excelWorkBook.SaveAs(path); // -> this will do the custom  
            //excelWorkBook.Close();
           // excelApp.Quit();
        }
    }

}
