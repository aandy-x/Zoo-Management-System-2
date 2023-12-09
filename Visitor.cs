using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management_System
{
    class Visitor
    {
        string firstName;
        string lastName;
        string cityName;
        string stateName;
        string zipCode;
        string phoneNumber;
        string email;
        string userName;
        string password;
        string country;
        string address;

        public Visitor()
        {
            firstName = "";
            lastName = "";
            cityName = "";
            stateName = "";
            zipCode = "";
            phoneNumber = "";
            email = "";
            userName = "";
            password = "";
            country = "";
            address = "";
        }

        public Visitor(string firstName, string lastName, string cityName, string stateName, string zipCode, string phoneNumber, string email, string userName, string password, string country, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cityName = cityName;
            this.stateName = stateName;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.userName = userName;
            this.password = password;
            this.country = country;
            this.address = address;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public string StateName
        {
            get { return stateName; }
            set { stateName = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}
