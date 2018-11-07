using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AmigoV2.Properties;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace AmigoV2
{
    public class EngineerDataSet : ISource
    {
        DataSet _engineerDataSet;
        SqlDataAdapter _engineerDataAdapter;
        SqlDataAdapter _shuffledEngineersDataAdapter;

        int nextID = int.MaxValue;

        public EngineerDataSet()
        {
            _engineerDataSet = new DataSet();

            //o alta varinata de a te conecta la connections string
            var EngineerConnection = ConfigurationManager.ConnectionStrings["EngineerConnection"].ConnectionString;
            using (SqlConnection connectionString = new SqlConnection(EngineerConnection))
            {
                _engineerDataAdapter = new SqlDataAdapter("SELECT * FROM Engineers_tbl", connectionString);
                var builder = new SqlCommandBuilder(_engineerDataAdapter);
                _engineerDataAdapter.Fill(_engineerDataSet, "Engineers_tbl");
                connectionString.Dispose();
                connectionString.Close();
            }

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

        public void Update(BindingSource bidingSource, Engineer engineer)//TO DO: to avoid SQL injection attack: https://www.youtube.com/watch?v=QKhHkEmv3Kw
        {
            var querryUpdate = $"UPDATE Engineers_tbl SET EngineerName = @EngineerName, EngineerRole = @EngineerRole, Gender = @Gender WHERE EngineerID = {engineer.EngineerID}";

            using (var sqlConnection = new SqlConnection(Settings.Default.EngineerConnection))
            {
                sqlConnection.Open();

                SqlCommand updateCommand = new SqlCommand(querryUpdate, sqlConnection);

                updateCommand.Parameters.AddWithValue("@EngineerName", engineer.EngineerName);
                updateCommand.Parameters.AddWithValue("@EngineerRole", engineer.EngineerRole);
                updateCommand.Parameters.AddWithValue("@Gender", engineer.Gender);

                _engineerDataAdapter = new SqlDataAdapter();
                _engineerDataAdapter.UpdateCommand = updateCommand;
                _engineerDataAdapter.UpdateCommand.ExecuteNonQuery();
            }
        }

        public object ShuffleEngineers()
        {
            var table = _engineerDataSet.Tables["Engineers_tbl"];



            SqlConnection connectionString = new SqlConnection(Settings.Default.EngineerConnection);
            _shuffledEngineersDataAdapter = new SqlDataAdapter("SELECT * FROM Shuffeld_Engineers_tbl", connectionString);
            var builder = new SqlCommandBuilder(_shuffledEngineersDataAdapter);
            _shuffledEngineersDataAdapter.Fill(_engineerDataSet, "Shuffeld_Engineers_tbl");


            var table2 = _engineerDataSet.Tables["Shuffeld_Engineers_tbl"];
            var item = table2.NewRow();
            item = table.Rows[1];
            table2.Rows.Add(item);//TO DO: aquers an error when I try to copy a row from another table 

            _shuffledEngineersDataAdapter.Update(_engineerDataSet, "Shuffeld_Engineers_tbl");
            connectionString.Dispose();
            connectionString.Close();
            return null;

        }

        public object AddWorkdays()
        {
            throw new NotImplementedException();
        }

        public object AddShifts()
        {
            throw new NotImplementedException();
        }

        public object ShowSchedule()
        {
            ShuffleEngineers();
            return null;
        }
    }
}
