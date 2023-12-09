using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Zoo_Management_System
{
    class AnimalDB
    {
        private static string connectString = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = ZooDataBase.accdb;";
        OleDbConnection myConnection;
        OleDbCommand myCommand;
        OleDbDataAdapter myDataAdapter;
        OleDbDataReader myDataReader;

        DataSet animalDataSet, animalTypeDataSet, animalPersonalNameDataSet, animalBreedDataSet;

        DataTable animalTable;

        string queryString;

        public void SaveAnimal(string animalPhoto, string animalCountryofOriginPhoto, string animalCountryofOrigin, string animalBreed, string animalPersonalName, string animalType, string animalDescription, string animalHabitat, string animalBehavior, string animalAge, string animalSex)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "INSERT INTO Animals(animalPhoto, animalCountryofOriginPhoto, animalCountryofOrigin, animalBreed, animalPersonalName, animalType, animalDescription, animalHabitat, animalBehavior, animalAge, animalSex)" +
                "VALUES ('" + animalPhoto + "','" + animalCountryofOriginPhoto + "','" + animalCountryofOrigin + "','" + animalBreed + "','" + animalPersonalName + "','" + animalType + "','" + animalDescription + "','" + animalHabitat + "','" + animalBehavior + "','" + animalAge + "','" + animalSex + "')";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            myConnection.Open();
            myDataAdapter.Update(animalDataSet, "animalTable");
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        public List<Animal> GetAnimalList()
        {
            List<Animal> animals = new List<Animal>();
            foreach (DataRow row in GetAllAnimals().Rows)
            {
                Animal a = new Animal();
                a.AnimalPhoto = row["animalPhoto"].ToString();
                a.AnimalCountryofOriginPhoto = row["animalCountryofOriginPhoto"].ToString();
                a.AnimalCountryofOrigin = row["animalCountryofOrigin"].ToString();
                a.AnimalBreed = row["animalBreed"].ToString();
                a.AnimalPersonalName = row["animalPersonalName"].ToString();
                a.AnimalType = row["animalType"].ToString();
                a.AnimalDescription = row["animalDescription"].ToString();
                a.AnimalHabitat = row["animalHabitat"].ToString();
                a.AnimalBehavior = row["animalBehavior"].ToString();
                a.AnimalAge = row["animalAge"].ToString();
                a.AnimalSex = row["animalSex"].ToString();
                animals.Add(a);
            }
            return animals;
        }
        public DataTable GetAllAnimals()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT * FROM Animals";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            animalDataSet = new DataSet("animalTable");

            myDataAdapter.Fill(animalDataSet, "animalTable");

            return animalDataSet.Tables["animalTable"];
        }

        public DataTable LoadDeleteAnimal()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT animalPersonalName, animalBreed, animalType FROM Animals";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            animalDataSet = new DataSet("animalTable");

            myDataAdapter.Fill(animalDataSet, "animalTable");

            return animalDataSet.Tables["animalTable"];
        }

        public void DeleteItem(int studentID)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "DELETE  FROM Animals Where animalID = '" + studentID + "'";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);
            myConnection.Open();
            myDataAdapter.Update(animalDataSet, "animalTable");
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        //Static method to delete item based on ID (ID is Unique/primary key)
        public static void DeleteMenuItem(int studentID)
        {
            //the TA showed me this method
            string deleteStatement =
                "DELETE FROM Animals " +
                "WHERE AnimalID = @AnimalID; ";

            OleDbConnection connection = new OleDbConnection(connectString);

            OleDbCommand command = new OleDbCommand(deleteStatement, connection);

            //prevent SQL injection
            command.Parameters.AddWithValue("@ID", studentID);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable LoadAnimalPersonalNameTable()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT Distinct animalPersonalName FROM Animals";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            animalPersonalNameDataSet = new DataSet("animalTable");

            myDataAdapter.Fill(animalPersonalNameDataSet, "animalTable");
            return animalPersonalNameDataSet.Tables["animalTable"];
        }

        public DataTable LoadAnimalBreedTable()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT Distinct animalBreed FROM Animals";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            animalBreedDataSet = new DataSet("animalTable");

            myDataAdapter.Fill(animalBreedDataSet, "animalTable");
            return animalBreedDataSet.Tables["animalTable"];
        }

        public DataTable LoadAnimalType()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT Distinct animalType FROM Animals";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            animalTypeDataSet = new DataSet("animalTable");

            myDataAdapter.Fill(animalTypeDataSet, "animalTable");
            return animalTypeDataSet.Tables["animalTable"];
        }

        public DataTable FilterAnimalsByPersonalName(string personalName)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT animalPersonalName, animalBreed, animalType FROM Animals WHERE animalPersonalName = @PersonalName";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@PersonalName", personalName);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            animalDataSet = new DataSet("animalTable");

            myDataAdapter.Fill(animalDataSet, "animalTable");

            return animalDataSet.Tables["animalTable"];
        }

        public DataTable FilterAnimalsByType(string animalType)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT animalPersonalName, animalBreed, animalType FROM Animals WHERE animalType = @Type";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@Type", animalType);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            animalDataSet = new DataSet("animalTable");

            myDataAdapter.Fill(animalDataSet, "animalTable");

            return animalDataSet.Tables["animalTable"];
        }

        public DataTable FilterAnimalsByBreed(string animalBreed)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT animalPersonalName, animalBreed, animalType FROM Animals WHERE animalBreed = @Breed";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@Breed", animalBreed);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            animalDataSet = new DataSet("animalTable");

            myDataAdapter.Fill(animalDataSet, "animalTable");

            return animalDataSet.Tables["animalTable"];
        }

        public void UpdateAnimalDescription(int animalID, string newDescription)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Animals SET animalDescription = @NewDescription WHERE animalID = @AnimalID";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@NewDescription", newDescription);
            myCommand.Parameters.AddWithValue("@AnimalID", animalID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void UpdateAnimalPhoto(int animalID, string newAnimalPhoto)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Animals SET animalPhoto = @newAnimalPhoto WHERE animalID = @AnimalID";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@newAnimalPhoto", newAnimalPhoto);
            myCommand.Parameters.AddWithValue("@AnimalID", animalID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void UpdateAnimalCountryOfOriginPhoto(int animalID, string newCountryOfOriginPhoto)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Animals SET animalCountryOfOriginPhoto = @NewCountryOfOriginPhoto WHERE animalID = @AnimalID";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@NewCountryOfOriginPhoto", newCountryOfOriginPhoto);
            myCommand.Parameters.AddWithValue("@AnimalID", animalID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void UpdateAnimalCountryOfOrigin(int animalID, string newCountryOfOrigin)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Animals SET animalCountryOfOrigin = @NewCountryOfOrigin WHERE animalID = @AnimalID";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@NewCountryOfOrigin", newCountryOfOrigin);
            myCommand.Parameters.AddWithValue("@AnimalID", animalID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void UpdateAnimalBreed(int animalID, string newBreed)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Animals SET animalBreed = @NewBreed WHERE animalID = @AnimalID";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@NewBreed", newBreed);
            myCommand.Parameters.AddWithValue("@AnimalID", animalID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void UpdateAnimalPersonalName(int animalID, string newPersonalName)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Animals SET animalPersonalName = @NewPersonalName WHERE animalID = @AnimalID";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@NewPersonalName", newPersonalName);
            myCommand.Parameters.AddWithValue("@AnimalID", animalID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void UpdateAnimalType(int animalID, string newAnimalType)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Animals SET animalType = @NewAnimalType WHERE animalID = @AnimalID";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@NewAnimalType", newAnimalType);
            myCommand.Parameters.AddWithValue("@AnimalID", animalID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void UpdateAnimalHabitat(int animalID, string newHabitat)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Animals SET animalHabitat = @NewHabitat WHERE animalID = @AnimalID";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@NewHabitat", newHabitat);
            myCommand.Parameters.AddWithValue("@AnimalID", animalID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void UpdateAnimalBehavior(int animalID, string newBehavior)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Animals SET animalBehavior = @NewBehavior WHERE animalID = @AnimalID";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@NewBehavior", newBehavior);
            myCommand.Parameters.AddWithValue("@AnimalID", animalID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void UpdateAnimalAge(int animalID, string newAge)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Animals SET animalAge = @NewAge WHERE animalID = @AnimalID";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@NewAge", newAge);
            myCommand.Parameters.AddWithValue("@AnimalID", animalID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void UpdateAnimalSex(int animalID, string newSex)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Animals SET animalSex = @NewSex WHERE animalID = @AnimalID";

            myCommand = new OleDbCommand(queryString, myConnection);
            myCommand.Parameters.AddWithValue("@NewSex", newSex);
            myCommand.Parameters.AddWithValue("@AnimalID", animalID);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public DataTable LoadModifyAnimal()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT animalID, animalPersonalName, animalBreed, animalType FROM Animals";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            animalDataSet = new DataSet("animalTable");

            myDataAdapter.Fill(animalDataSet, "animalTable");

            return animalDataSet.Tables["animalTable"];
        }


    }
}
