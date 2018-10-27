using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AmigoV2.Properties;
using System.Linq;

namespace AmigoV2
{
    public class EngineerDataSet : ISource
    {
        DataSet _engineerDataSet;
        SqlDataAdapter _engineerDataAdapter;
        int nextID = int.MaxValue;

        public EngineerDataSet()
        {
            _engineerDataSet = new DataSet();

            SqlConnection connectionString = new SqlConnection(Settings.Default.EngineerConnection);
            _engineerDataAdapter = new SqlDataAdapter("SELECT * FROM Engineers_tbl", connectionString);
            var builder = new SqlCommandBuilder(_engineerDataAdapter);
            _engineerDataAdapter.Fill(_engineerDataSet, "Engineers_tbl");
            connectionString.Dispose();
            connectionString.Close();

        }
        public void AddEngineer(BindingSource bidingSource, Engineer engineer)
        {
            DataTable table = _engineerDataSet.Tables["Engineers_tbl"];

            nextID -= 1;
            var newRow = table.NewRow();

            newRow["EngineerID"] = nextID;
            newRow["EngineerName"] = engineer.EngineerName;
            newRow["EngineerRole"] = engineer.EngineerRole;
            newRow["Gender"] = engineer.Gender;
            newRow["ShiftDay"] = engineer.ShiftDay;

            table.Rows.Add(newRow);

        }

        public void DeleteEngineer(BindingSource bidingSource, int engineerID)
        {
            using (var connectionString = new SqlConnection(Settings.Default.EngineerConnection))
            {
                DataTable table = _engineerDataSet.Tables["Engineers_tbl"];

                var querry = from eng in table.AsEnumerable()
                             where eng.RowState != DataRowState.Deleted
                             where eng.Field<int>("EngineerID") == engineerID
                             select eng;
                var singleEng = querry.Single();
                //bidingSource.Remove(singleEng);
                singleEng.Delete();
                // Save();
            }
        }

        public object GetEngineers()
        {
            DataTable table = _engineerDataSet.Tables["Engineers_tbl"];
            return table;
        }

        public void Save()
        {
            using (var sqlConnection = new SqlConnection(Settings.Default.EngineerConnection))
            {
                _engineerDataAdapter = new SqlDataAdapter("SELECT * FROM Engineers_tbl", sqlConnection);
                var builder = new SqlCommandBuilder(_engineerDataAdapter);
                _engineerDataAdapter.Update(_engineerDataSet, "Engineers_tbl");

                sqlConnection.Close();
            }
            MessageBox.Show("Options saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
