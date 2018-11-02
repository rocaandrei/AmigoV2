using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoV2
{
    public partial class AddNewEngieer : Form
    {
        public AddNewEngieer()
        {
            InitializeComponent();
        }
        public Engineer Engineer
        {
            get
            {
                try
                {
                    return new Engineer()
                    {
                        EngineerID = int.Parse(EngineersIDTBAddForm.Text),
                        EngineerName = NameTBAddForm.Text,
                        EngineerRole = RoleTBAddForm.Text,
                        Gender = GenderTBAddForm.Text
                    };
                }
                catch (Exception)
                {
                    MessageBox.Show("Eroare datele nu au fost introduse corect","Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return new Engineer();
                }
            }
        }
    }
}
