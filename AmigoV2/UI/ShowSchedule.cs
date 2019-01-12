using System;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportToExcelBt_Click_1(object sender, EventArgs e)
        {
            ExcelProcessor.GenerateExcelFile().AddDataToFile(ScheduleEngineersDataGridView);
        }

       
    }
}
