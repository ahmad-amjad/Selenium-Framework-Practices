using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Data;
using System.IO;

namespace TestFramework.Util
{
    public static class ExportToExcel
    {
        public static void WriteDataToExcelWorkbook(DataTable data)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                //create a new Worksheet
                ExcelWorksheet tabletSheet = excelPackage.Workbook.Worksheets.Add("TabletData");

                //add data in sheet
                tabletSheet.Cells.LoadFromDataTable(data, true);

                //the path of the file
                string filePath = Environment.CurrentDirectory + "\\TabletData.xlsx";

                //Write the file to the disk
                FileInfo fi = new FileInfo(filePath);
                excelPackage.SaveAs(fi);
            }
        }
    }
}
