using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo_Management_System
{
    class AccountDB
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        OleDbCommand myCommand;
        DataSet visitorDataSet, employeeDataSet;
        DataTable visitorTable, employeeTable;

        string strSQL;

        public AccountDB()
        {
            Load();
        }

        public void Load()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=ZooDataBase.accdb;");
            strSQL = "SELECT * FROM Visitors";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            visitorDataSet = new DataSet("visitorTable");
            myDataAdapter.Fill(visitorDataSet, "visitorTable");
            visitorTable = visitorDataSet.Tables["visitorTable"];

            strSQL = "SELECT * FROM Employees";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            employeeDataSet = new DataSet("employeeTable");
            myDataAdapter.Fill(employeeDataSet, "employeeTable");
            employeeTable = employeeDataSet.Tables["employeeTable"];
        }

        public List<Visitor> GetAllVisitors()
        {
            List<Visitor> visitors = new List<Visitor>();
            foreach (DataRow row in visitorTable.Rows)
            {
                Visitor visitor = new Visitor();
                visitor.FirstName = row["firstName"].ToString();
                visitor.LastName = row["lastName"].ToString();
                visitor.CityName = row["cityName"].ToString();
                visitor.StateName = row["stateName"].ToString();
                visitor.ZipCode = row["zipCode"].ToString();
                visitor.PhoneNumber = row["phoneNumber"].ToString();
                visitor.Email = row["email"].ToString();
                visitor.UserName = row["userName"].ToString();
                visitor.Password = row["userPassword"].ToString();
                visitor.Address = row["address"].ToString();
                visitor.Country = row["country"].ToString();
                visitors.Add(visitor);
            }
            return visitors;
        }

        public List<Employees> GetAllEmployees()
        {
            List<Employees> employees = new List<Employees>();
            foreach (DataRow row in employeeTable.Rows)
            {
                Employees emp = new Employees();
                emp.FirstName = row["firstName"].ToString();
                emp.LastName = row["lastName"].ToString();
                emp.CityName = row["cityName"].ToString();
                emp.StateName = row["stateName"].ToString();
                emp.ZipCode = row["zipCode"].ToString();
                emp.PhoneNumber = row["phoneNumber"].ToString();
                emp.Email = row["email"].ToString();
                emp.UserName = row["userName"].ToString();
                emp.Password = row["userPassword"].ToString();
                emp.Address = row["address"].ToString();
                emp.Country = row["country"].ToString();
                emp.EmployeeType = row["employeeType"].ToString();
                emp.EmployeePhoto = row["employeePhoto"].ToString();
                employees.Add(emp);
            }
            return employees;
        }

        public void AddVisitor(Visitor visitor)
        {
            //string FirstName, string LastName, string CityName, string StateName, string ZipCode, string PhoneNumber, string Email, string UserName, string Password, string Address, string Country
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=ZooDataBase.accdb;");

            //strSQL = "INSERT INTO Visitors(firstName, lastName, cityName, stateName, zipCode, phoneNumber, email, userName, userPassword, address, country)" +
            //  "VALUES ('" + FirstName + "','" + LastName + "','" + CityName + "','" + StateName + "','" + ZipCode + "','" + PhoneNumber + "','" + Email + "','" + UserName + "','" + Password + "','" + Address + "','" + Country + "')";

            strSQL = "INSERT INTO Visitors (firstName, lastName, cityName, stateName, zipCode, phoneNumber, email, userName, userPassword, address, country) " +
                "VALUES (@FirstName, @LastName, @City, @State, @Zip, @Phone, @Email, @Username, @Password, @Address, @Country)";
            myDataAdapter = new OleDbDataAdapter(myCommand);
            myCommand = new OleDbCommand(strSQL, myConnection);

            try
            {
                myConnection.Open();
                // Use parameters to avoid SQL injection
                myCommand.Parameters.AddWithValue("@FirstName", visitor.FirstName);
                myCommand.Parameters.AddWithValue("@LastName", visitor.LastName);
                myCommand.Parameters.AddWithValue("@City", visitor.CityName);
                myCommand.Parameters.AddWithValue("@State", visitor.StateName);
                myCommand.Parameters.AddWithValue("@Zip", visitor.ZipCode);
                myCommand.Parameters.AddWithValue("@Phone", visitor.PhoneNumber);
                myCommand.Parameters.AddWithValue("@Email", visitor.Email);
                myCommand.Parameters.AddWithValue("@Username", visitor.UserName);
                myCommand.Parameters.AddWithValue("@Password", visitor.Password);
                myCommand.Parameters.AddWithValue("@Address", visitor.Address);
                myCommand.Parameters.AddWithValue("@Country", visitor.Country);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void AddEmployee(Employees emp)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=ZooDataBase.accdb;");
            strSQL = "INSERT INTO Employees (firstName, lastName, cityName, stateName, zipCode, phoneNumber, email, userName, userPassword, address, country, employeeType, employeePhoto) " +
                            "VALUES (@FirstName, @LastName, @City, @State, @Zip, @Phone, @Email, @Username, @Password, @Address, @Country, @EmpType, @EmpPhoto)";
            myDataAdapter = new OleDbDataAdapter(myCommand);
            myCommand = new OleDbCommand(strSQL, myConnection);
            try
            {
                myConnection.Open();
                // Use parameters to avoid SQL injection
                myCommand.Parameters.AddWithValue("@FirstName", emp.FirstName);
                myCommand.Parameters.AddWithValue("@LastName", emp.LastName);
                myCommand.Parameters.AddWithValue("@City", emp.CityName);
                myCommand.Parameters.AddWithValue("@State", emp.StateName);
                myCommand.Parameters.AddWithValue("@Zip", emp.ZipCode);
                myCommand.Parameters.AddWithValue("@Phone", emp.PhoneNumber);
                myCommand.Parameters.AddWithValue("@Email", emp.Email);
                myCommand.Parameters.AddWithValue("@Username", emp.UserName);
                myCommand.Parameters.AddWithValue("@Password", emp.Password);
                myCommand.Parameters.AddWithValue("@Address", emp.Address);
                myCommand.Parameters.AddWithValue("@Country", emp.Country);
                myCommand.Parameters.AddWithValue("@EmpType", emp.EmployeeType);
                myCommand.Parameters.AddWithValue("@EmpPhoto", emp.EmployeePhoto);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void Save()
        {
            OleDbCommandBuilder builder = new OleDbCommandBuilder(myDataAdapter);
            try
            {
                myDataAdapter.Update(visitorDataSet, "visitorTable");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
