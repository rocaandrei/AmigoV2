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

        int temporaryID = int.MaxValue;
        Random random = new Random();

        public EngineerDataSet()
        {
            _engineerDataSet = new DataSet();

            //o alta varinata de a te conecta la connections string
            var EngineerConnection = ConfigurationManager.ConnectionStrings["EngineerConnection"].ConnectionString;
            using (SqlConnection connectionString = new SqlConnection(EngineerConnection))
            {
                AddEngineersTbl(connectionString);
                AddShuffledEngineersTbl(connectionString);
            }
        }

        private void AddShuffledEngineersTbl(SqlConnection connectionString)
        {
            _shuffledEngineersDataAdapter = new SqlDataAdapter("SELECT * FROM Shuffeld_Engineers_tbl", connectionString);
            _shuffledEngineersDataAdapter.Fill(_engineerDataSet, "Shuffeld_Engineers_tbl");
        }

        private void AddEngineersTbl(SqlConnection connectionString)
        {
            _engineerDataAdapter = new SqlDataAdapter("SELECT * FROM Engineers_tbl", connectionString);
            connectionString.Open();
            var builder = new SqlCommandBuilder(_engineerDataAdapter);
            _engineerDataAdapter.Fill(_engineerDataSet, "Engineers_tbl");
        }

        public void AddEngineer(BindingSource bidingSource, Engineer engineer)
        {
            DataTable table = _engineerDataSet.Tables["Engineers_tbl"];

            temporaryID -= 1;
            var newRow = table.NewRow();

            newRow["EngineerID"] = temporaryID;
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

                connectionString.Open();
                //bidingSource.Remove(singleEng);
                singleEng.Delete();
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
            using (var connectionString = new SqlConnection(Settings.Default.EngineerConnection))
            {
                _engineerDataAdapter = new SqlDataAdapter(querySave, connectionString);
                var builder = new SqlCommandBuilder(_engineerDataAdapter);//need this line to bulid my comands
                connectionString.Open();
                _engineerDataAdapter.Update(_engineerDataSet, "Engineers_tbl");
            }
            MessageBox.Show("Options saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Update(BindingSource bidingSource, Engineer engineer)
        {
            var querryUpdate = $"UPDATE Engineers_tbl SET EngineerName = @EngineerName, EngineerRole = @EngineerRole, Gender = @Gender WHERE EngineerID = {engineer.EngineerID}";

            using (var sqlConnection = new SqlConnection(Settings.Default.EngineerConnection))
            {
                sqlConnection.Open();

                SqlCommand updateCommand = new SqlCommand(querryUpdate, sqlConnection);
                //this is to avoid SQL Inject Attack
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
            var tableTest =  _engineerDataSet.Tables["Shuffeld_Engineers_tbl"];
            int n = tableTest.Rows.Count;

            for (int i = 0; i < n; i++)
            {
                int randomNo = i + this.random.Next(n - i);

                var temp = tableTest.Rows[randomNo].ItemArray;
                tableTest.Rows[randomNo].ItemArray = tableTest.Rows[i].ItemArray;
                tableTest.Rows[i].ItemArray = temp;
            }

            return tableTest;
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
            return ShuffleEngineers();

        }
    }

}


