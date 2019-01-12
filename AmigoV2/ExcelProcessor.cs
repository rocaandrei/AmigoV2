using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoV2
{
    //Documentation from: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interop/how-to-access-office-onterop-objects
    public static class ExcelProcessor
    {
        public static Worksheet GenerateExcelFile()
        {
            var _excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = _excelApp.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet worksheet = _excelApp.ActiveSheet;
            worksheet.Name = "Schedule for next week";
            _excelApp.Visible = true;
            DateTime currentDay = DateTime.Today; //.ToString("d.MM.yyyy");
            DateTime endOfWeek = currentDay.AddDays(5);

            worksheet.Cells[1, "A"] = "The engieers ho will take turn the week between " + currentDay.ToString("d.MM.yyyy") + " and " + endOfWeek.ToString("d.MM.yyyy");

            return worksheet;
        }
        public static void AddDataToFile(this Worksheet worksheet, DataGridView grid)
        {
            int neededEngineers = 10;

            for (int i = 1; i < grid.ColumnCount + 1; i++)
            {
                worksheet.Cells[3, i] = grid.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < neededEngineers; i++)
            {
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    worksheet.Cells[i + 4, j + 1] = grid.Rows[i].Cells[j].Value.ToString();
                }
            }
            AutoFitColumns(worksheet);
        }
        private static void AutoFitColumns(Worksheet worksheet)
        {
            string[] columsToArange = new string[] { "B", "C", "D", "E", "F" };
            for (int i = 0; i < columsToArange.Length; i++)
            {
                worksheet.Columns[columsToArange[i]].AutoFit();
            }
        }
    }
}
