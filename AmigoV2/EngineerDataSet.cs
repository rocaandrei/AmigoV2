using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AmigoV2.Properties;
using System.Linq;
using System;

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


            table.Rows.Add(newRow);

        }

        public void DeleteEngineer(BindingSource bidingSource, int engineerID)
        {
            using (var connectionString = new SqlConnection(Settings.Default.EngineerConnection))
            {
                DataTable table = _engineerDataSet.Tables["Engineers_tbl"];

                var query = from eng in table.AsEnumerable()
                            where eng.RowState != DataRowState.Deleted
                            where eng.Field<int>("EngineerID") == engineerID
                            select eng;
                var singleEng = query.Single();
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
            string querySave = "SELECT * FROM Engineers_tbl";
            using (var sqlConnection = new SqlConnection(Settings.Default.EngineerConnection))
            {
                _engineerDataAdapter = new SqlDataAdapter(querySave, sqlConnection);
                var builder = new SqlCommandBuilder(_engineerDataAdapter);//need this line to bulid my comands
                _engineerDataAdapter.Update(_engineerDataSet, "Engineers_tbl");

                sqlConnection.Close();
            }
            MessageBox.Show("Options saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Update(BindingSource bidingSource, Engineer engineer)
        {
            var querryUpdate = $"UPDATE Engineers_tbl SET EngineerName = '{engineer.EngineerName}', EngineerRole = '{engineer.EngineerRole}', Gender = '{engineer.Gender}' WHERE EngineerID = {engineer.EngineerID}";
            using (var sqlConnection = new SqlConnection(Settings.Default.EngineerConnection))
            {
                sqlConnection.Open();

                SqlCommand updateCommand = new SqlCommand(querryUpdate, sqlConnection);
                _engineerDataAdapter = new SqlDataAdapter();

                _engineerDataAdapter.UpdateCommand = updateCommand;
                _engineerDataAdapter.UpdateCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }
    }
}
