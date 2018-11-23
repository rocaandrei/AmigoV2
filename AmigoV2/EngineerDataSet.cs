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
        SqlDataAdapter _calendar;

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
                AddCalendar(connectionString);
            }
        }

        private void AddCalendar(SqlConnection connectionString)
        {
            _calendar = new SqlDataAdapter("SELECT * FROM Calendar", connectionString);
            _calendar.Fill(_engineerDataSet, "Calendar");
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
            var shuffledEngineersTbl = _engineerDataSet.Tables["Shuffeld_Engineers_tbl"];
            int n = shuffledEngineersTbl.Rows.Count;

            for (int i = 0; i < n; i++)
            {
                int randomNo = i + this.random.Next(n - i);

                var temp = shuffledEngineersTbl.Rows[randomNo].ItemArray;
                shuffledEngineersTbl.Rows[randomNo].ItemArray = shuffledEngineersTbl.Rows[i].ItemArray;
                shuffledEngineersTbl.Rows[i].ItemArray = temp;
            }
            return shuffledEngineersTbl;
        }

        public object AddWorkdays()
        {
            DataTable shuffledEng = (DataTable)ShuffleEngineers();
            if (!shuffledEng.Columns.Contains("Workday"))
            {
                DataColumn workdays = new DataColumn();
                workdays.ColumnName = "Workday";
                shuffledEng.Columns.Add(workdays);
            }
            Monday(shuffledEng);
            Tuesday(shuffledEng);
            Wednesday(shuffledEng);
            Thursday(shuffledEng);
            Friday(shuffledEng);

            return shuffledEng;
        }
        public object AddShifts()
        {
            DataTable engieers = (DataTable)AddWorkdays();

            if (!engieers.Columns.Contains("Shifts"))
            {
                DataColumn shifts = new DataColumn();
                shifts.ColumnName = "Shifts";
                engieers.Columns.Add(shifts);
            }
            int maxShifts = 10;
            for (int i = 0; i < engieers.Rows.Count; i++)
            {
                if (i < maxShifts)
                {
                    if (i % 2 == 0)
                    {
                        engieers.Rows[i][5] = "First shift";
                    }
                    else
                    {
                        engieers.Rows[i][5] = "Second shift";
                    }

                }
            }
            return engieers;
        }

        public object ShowSchedule()
        {
            DataTable schedule = (DataTable)AddShifts();
           
            return schedule;
        }
        #region Workdays
        private static void Monday(DataTable shuffledEng)
        {
            DataRow first = shuffledEng.Rows[0];
            first[4] = Workdays.Luni;
            DataRow second = shuffledEng.Rows[1];
            second[4] = Workdays.Luni;
        }
        private static void Tuesday(DataTable shuffledEng)
        {
            DataRow first = shuffledEng.Rows[2];
            first[4] = Workdays.Marti;
            DataRow second = shuffledEng.Rows[3];
            second[4] = Workdays.Marti;
        }
        private static void Wednesday(DataTable shuffledEng)
        {
            DataRow first = shuffledEng.Rows[4];
            first[4] = Workdays.Miercuri;
            DataRow second = shuffledEng.Rows[5];
            second[4] = Workdays.Miercuri;
        }
        private static void Thursday(DataTable shuffledEng)
        {
            DataRow first = shuffledEng.Rows[6];
            first[4] = Workdays.Joi;
            DataRow second = shuffledEng.Rows[7];
            second[4] = Workdays.Joi;
        }
        private static void Friday(DataTable shuffledEng)
        {
            DataRow first = shuffledEng.Rows[8];
            first[4] = Workdays.Vineri;
            DataRow second = shuffledEng.Rows[9];
            second[4] = Workdays.Vineri;
        }
        #endregion

    }
}


