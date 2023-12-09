using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management_System
{
    class Employees : Visitor
    {
        string employeeType;
        string employeePhoto;

        public Employees()
        {
            employeeType = "";
            employeePhoto = "";
        }

        public Employees(string firstName, string lastName, string cityName, string stateName, string zipCode, string phoneNumber, string email, string userName, string password, string country, string address, string employeeType, string employeePhoto)
        : base(firstName, lastName, cityName, stateName, zipCode, phoneNumber, email, userName, password, country, address)
        {

            this.employeeType = employeeType;
            this.employeePhoto = employeePhoto;
        }

        public string EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; }
        }

        public string EmployeePhoto
        {
            get { return employeePhoto; }
            set { employeePhoto = value; }
        }
    }
}
