using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management_System
{
    internal class AnimalDietPlanDB
    {
        private static string connectString = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = ZooDataBase.accdb;";
        OleDbConnection myConnection;
        OleDbCommand myCommand;
        OleDbDataAdapter myDataAdapter;
        OleDbDataReader myDataReader;

        DataSet dietDataSet;

        DataTable dietTable;

        string queryString;

        public void InsertDietPlan(string dietTypeOfFood, string dietFeedingSchedule)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "INSERT INTO AnimalDietPlan(dietTypeOfFood, dietFeedingSchedule)" +
                "VALUES ('" + dietTypeOfFood + "','" + dietFeedingSchedule + "')";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            myConnection.Open();
            myDataAdapter.Update(dietDataSet, "dietTable");
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        public DataTable GetAllDietPlanFields()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT * FROM AnimalDietPlan";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            dietDataSet = new DataSet("dietTable");

            myDataAdapter.Fill(dietDataSet, "dietTable");

            return dietDataSet.Tables["dietTable"];
        }

        public static void DeleteDietPlan(int dietID)
        {
            //the TA showed me this method
            string deleteStatement =
                "DELETE FROM AnimalDietPlan " +
                "WHERE DietID = @DietID; ";

            OleDbConnection connection = new OleDbConnection(connectString);

            OleDbCommand command = new OleDbCommand(deleteStatement, connection);

            //prevent SQL injection
            command.Parameters.AddWithValue("@DietID", dietID);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

    }
}
