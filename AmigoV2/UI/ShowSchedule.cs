using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
