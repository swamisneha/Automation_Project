using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo
{
    public class DemoExcel
    {
        [Test]
        public void DemoExcelRead()
        {
            XLWorkbook book = new XLWorkbook("C:\\AutomationTraining\\SauceDemo\\SauceDemo\\Test Data\\SwagLabs_data.xlsx");
            IXLWorksheet sheet = book.Worksheet("InvalidLoginTestData");
            IXLRange range = sheet.RangeUsed();

            object[] allData = new object[3];

            for (int r = 2; r <= 4; r++)
            {
                //create string[]
                for (int c = 1; c <= 3; c++)
                {
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);
                }

            }

            book.Dispose();
        }
    }
}
