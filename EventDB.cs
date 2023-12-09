using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Zoo_Management_System
{
    class EventDB
    {
        private static string connectString = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = ZooDataBase.accdb;";
        OleDbConnection myConnection;
        OleDbCommand myCommand;
        OleDbDataAdapter myDataAdapter;
        OleDbDataReader myDataReader;

        DataSet eventDataSet;

        DataTable eventTable;

        string queryString;

        public void InsertEvent(string eventName, string eventDate, string eventDescription, string eventImage)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "INSERT INTO Events(eventName, eventDate, eventDescription, eventImage)" +
                "VALUES ('" + eventName + "','" + eventDate + "','" + eventDescription + "','" + eventImage + "')";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            myConnection.Open();
            myDataAdapter.Update(eventDataSet, "eventTable");
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        public DataTable GetAllEventFields()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT * FROM Events";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            eventDataSet = new DataSet("eventTable");

            myDataAdapter.Fill(eventDataSet, "eventTable");

            return eventDataSet.Tables["eventTable"];
        }

        public static void DeleteEvent(int eventID)
        {
            //the TA showed me this method
            string deleteStatement =
                "DELETE FROM Events " +
                "WHERE eventID = @eventID; ";

            OleDbConnection connection = new OleDbConnection(connectString);

            OleDbCommand command = new OleDbCommand(deleteStatement, connection);

            //prevent SQL injection
            command.Parameters.AddWithValue("@eventID", eventID);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable LoadViewAllEvent()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT eventID, eventName FROM Events";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            eventDataSet = new DataSet("eventTable");

            myDataAdapter.Fill(eventDataSet, "eventTable");

            return eventDataSet.Tables["eventTable"];
        }
    }
}
