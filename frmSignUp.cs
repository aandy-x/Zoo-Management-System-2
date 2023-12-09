using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo_Management_System
{
    public partial class frmSignUp : Form
    {
        AccountDB accountDB;
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cBoxAccountType.SelectedItem.ToString() == "Visitor")
            {
                Visitor visitor = new Visitor();
                visitor.FirstName = txtboxAccountFName.Text.Trim();
                visitor.LastName = txtBoxAccountLName.Text.Trim();
                visitor.CityName = txtBoxAccountCity.Text.Trim();
                visitor.StateName = mTxtBoxAccountState.Text;
                visitor.ZipCode = mTxtBoxAccountZip.Text;
                visitor.PhoneNumber = mTxtBoxAccountPhone.Text;
                visitor.Email = txtBoxAccountEmail.Text.Trim();
                visitor.UserName = txtBoxAccountUserName.Text.Trim();
                visitor.Password = txtBoxAccountPassword.Text.Trim();
                visitor.Address = txtBoxAccountAddress.Text.Trim();
                visitor.Country = txtBoxAccountCountry.Text.Trim();

                if (txtBoxAccountUserName.Text == string.Empty || txtBoxAccountPassword.Text == string.Empty)
                {
                    MessageBox.Show("Username/Password cannot be empty.");
                    return;
                }
                accountDB.AddVisitor(visitor);
                this.Close();

            }
            else if (cBoxAccountType.SelectedItem.ToString() == "Employee")
            {
                Employees emp = new Employees();
                emp.FirstName = txtboxAccountFName.Text.Trim();
                emp.LastName = txtBoxAccountLName.Text.Trim();
                emp.CityName = txtBoxAccountCity.Text.Trim();
                emp.StateName = mTxtBoxAccountState.Text;
                emp.ZipCode = mTxtBoxAccountZip.Text;
                emp.PhoneNumber = mTxtBoxAccountPhone.Text;
                emp.Email = txtBoxAccountEmail.Text.Trim();
                emp.UserName = txtBoxAccountUserName.Text.Trim();
                emp.Password = txtBoxAccountPassword.Text.Trim();
                emp.Address = txtBoxAccountAddress.Text.Trim();
                emp.Country = txtBoxAccountCountry.Text.Trim();
                emp.EmployeeType = cBoxAccountEmployeeType.SelectedItem.ToString();
                emp.EmployeePhoto = txtBoxAccountEmployeePhoto.Text.Trim();

                if (txtBoxAccountUserName.Text == string.Empty || txtBoxAccountPassword.Text == string.Empty)
                {
                    MessageBox.Show("Username/Password cannot be empty.");
                    return;
                }
                accountDB.AddEmployee(emp);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Account Type");
            }
        }

        private void cBoxAccountType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cBoxAccountType.SelectedItem.ToString() == "Visitor")
            {
                lblAccountEmployeeType.Visible = false;
                cBoxAccountEmployeeType.Visible = false;
                lblAccountEmployeePhoto.Visible = false;
                txtBoxAccountEmployeePhoto.Visible = false;

            }
            else if (cBoxAccountType.SelectedItem.ToString() == "Employee")
            {
                lblAccountEmployeeType.Visible = true;
                cBoxAccountEmployeeType.Visible = true;
                lblAccountEmployeePhoto.Visible = true;
                txtBoxAccountEmployeePhoto.Visible = true;
            }
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            accountDB = new AccountDB();
            cBoxAccountType.SelectedIndex = 0;
            cBoxAccountEmployeeType.SelectedIndex = 0;
        }
    }
}
