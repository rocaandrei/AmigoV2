using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace AmigoV2.UI
{
    public partial class ShowSchedule : Form
    {
        public ShowSchedule()
        {
            InitializeComponent();
        }
        private BindingSource _engineersSource = new BindingSource();

        public BindingSource EngineersSource
        {
            set
            {
                _engineersSource = value;
            }
        }

        private void ShowSchedule_Load(object sender, EventArgs e)
        {
            ScheduleEngineersDataGridView.DataSource = _engineersSource;
        }

        private void ExportToExcelBt_Click_1(object sender, EventArgs e)
        {
            var _excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook1 = _excelApp.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet worksheet1 = _excelApp.ActiveSheet;
            worksheet1.Name = "Schedule for next week";
            _excelApp.Visible = true;


            worksheet1.Cells[1, 1] = "The engieers ho will take turn the week between " + DateTime.Today.ToString("d.MM.yyyy") + " and " + DateTime.Today.ToString("d.MM.yyyy");
            for (int i = 1; i < ScheduleEngineersDataGridView.ColumnCount + 1; i++)
            {
                worksheet1.Cells[3, i] = ScheduleEngineersDataGridView.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < 10/*ScheduleEngineersDataGridView.Rows.Count - 1*/; i++)
            {
                for (int j = 0; j < ScheduleEngineersDataGridView.ColumnCount; j++)
                {
                    worksheet1.Cells[i + 4, j + 1] = ScheduleEngineersDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
    }
}
