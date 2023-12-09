using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management_System
{
    internal class AnimalHealthRecordDB
    {
        private static string connectString = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = ZooDataBase.accdb;";
        OleDbConnection myConnection;
        OleDbCommand myCommand;
        OleDbDataAdapter myDataAdapter;
        OleDbDataReader myDataReader;

        DataSet healthDataSet;

        DataTable healthTable;

        string queryString;

        public void InsertHealthRecord(string healthRecordBehaviorNote, string healthRecordMedicalHistory, string healthRecordVetVisits, DateTime HealthRecordDate)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "INSERT INTO Events(HealthRecordBehaviorNote, HealthRecordMedicalHistory, HealthRecordVetVisits, HealthRecordDate)" +
                "VALUES ('" + healthRecordBehaviorNote + "','" + healthRecordMedicalHistory + "','" + healthRecordVetVisits + "','" + HealthRecordDate + "')";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            myConnection.Open();
            myDataAdapter.Update(healthDataSet, "healthTable");
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        public DataTable GetAllAnimalHealthRecordFields()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT * FROM AnimalHealthRecord";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            healthDataSet = new DataSet("healthTable");

            myDataAdapter.Fill(healthDataSet, "healthTable");

            return healthDataSet.Tables["healthTable"];
        }

        public static void DeleteAnimalHealthRecord(int animalHealthRecordID)
        {
            //the TA showed me this method
            string deleteStatement =
                "DELETE FROM AnimalHealthRecord " +
                "WHERE animalHealthRecordID = @animalHealthRecordID; ";

            OleDbConnection connection = new OleDbConnection(connectString);

            OleDbCommand command = new OleDbCommand(deleteStatement, connection);

            //prevent SQL injection
            command.Parameters.AddWithValue("@animalHealthRecordID", animalHealthRecordID);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable LoadViewAllAnimalHealthRecord()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT animalID, HealthRecordBehaviorNote, HealthRecordMedicalHistory, HealthRecordVetVisits, HealthRecordDate FROM Animals";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            healthDataSet = new DataSet("healthTable");

            myDataAdapter.Fill(healthDataSet, "healthTable");

            return healthDataSet.Tables["healthTable"];
        }
    }
}
