using AmigoV2.UI;
using System;
using System.Windows.Forms;

namespace AmigoV2
{
    public partial class AmigoApp : Form
    {
        public AmigoApp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// biding source-urile astea de mai jos imi face ca informatia sa fie fie legata in diferite forme 
        /// </summary>
        /// 

        private BindingSource _engineerBidingSource = new BindingSource();

        private ISource _currentSource;
        private ObjectSource _objectSource;
        private EngineerDataSet _dataSetSource;

        private void Form1_Load(object sender, EventArgs e)
        {
            SourceToolStripComboBox.SelectedIndex = 0;//la initializare incepem cu Object source
            SetSource();
            BindEngieers();
         
            EmployeesListBox.DataSource = _engineerBidingSource;

            EmployeesListBox.ValueMember = "EngineerID";
            EmployeesListBox.DisplayMember = "EngineerName";
           
            EmployeesDataGridView.DataSource = _engineerBidingSource;

            NameTextBox.DataBindings.Clear();
            NameTextBox.DataBindings.Add("Text", _engineerBidingSource, "EngineerName");
            EngineersIDTextBox.DataBindings.Clear();
            EngineersIDTextBox.DataBindings.Add("Text", _engineerBidingSource, "EngineerID");
            RoleTextBox.DataBindings.Clear();
            RoleTextBox.DataBindings.Add("Text", _engineerBidingSource, "EngineerRole");
            GenderTextBox.DataBindings.Clear();
            GenderTextBox.DataBindings.Add("Text", _engineerBidingSource, "Gender");
        }

        private void AddEngineer_Click(object sender, EventArgs e)
        {
            AddNewEngieer form = new AddNewEngieer();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                var engineers = _engineerBidingSource;
                _currentSource.AddEngineer(engineers, form.Engineer);
            }
        }

        private void DeleteEngineer_Click(object sender, EventArgs e)
        {
            int engineerID = (int)EmployeesListBox.SelectedValue;
            _currentSource.DeleteEngineer(_engineerBidingSource, engineerID);
        }

        private void OnClickMovePrevious_Click(object sender, EventArgs e)
        {
            _engineerBidingSource.MovePrevious();
        }

        private void OnClickMoveNext_Click(object sender, EventArgs e)
        {
            _engineerBidingSource.MoveNext();
        }

        private void SourceToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSource();
            BindEngieers();
        }

        private void OnClickSave_Click(object sender, EventArgs e)
        {
            _currentSource.Save();
        }
        private void BindEngieers()
        {
           _engineerBidingSource.DataSource = _currentSource.GetEngineers();
        }

        private void SetSource()
        {
            switch (SourceToolStripComboBox.SelectedIndex)
            {
                case 0:
                    if (_objectSource == null)
                    {
                        _objectSource = new ObjectSource();
                    }
                    _currentSource = _objectSource;
                    break;
                case 1:
                    if (_dataSetSource == null)
                    {
                        _dataSetSource = new EngineerDataSet();
                    }
                    _currentSource = _dataSetSource;
                    break;
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var updatedEng = new Engineer()
            {
                EngineerID = int.Parse(EngineersIDTextBox.Text),
                EngineerRole = RoleTextBox.Text,
                EngineerName = NameTextBox.Text,
                Gender = GenderTextBox.Text,
            };
            _currentSource.Update(_engineerBidingSource, updatedEng);
        }

        private void ShowScheduleButton_Click(object sender, EventArgs e)
        {
            ShowSchedule theCalendar = new UI.ShowSchedule();

            if (_objectSource != null)
            {
                var shuffleEng = new ObjectSource();
                BindingSource _engineersShuffled = new BindingSource();

                _engineersShuffled.DataSource = shuffleEng.ShowSchedule();
                theCalendar.EngineersSource = _engineersShuffled;

                theCalendar.ShowDialog();
            }
            else
            {
                //TO DO: aici sa fac shuffle din DataSetSource...
            }
           
        }
    }
}
