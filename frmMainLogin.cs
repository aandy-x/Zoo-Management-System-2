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
    public partial class frmMainLogin : Form
    {
        AccountDB accountDB = new AccountDB();
        List<Visitor> visitors;
        List<Employees> employees;

        public frmMainLogin()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp signUp = new frmSignUp();

            signUp.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool login = false;
            if (cBoxAccountType.SelectedItem.ToString() == "Visitor")
            {
                foreach (Visitor v in visitors)
                {
                    if (txtBoxUserName.Text.Trim() == v.UserName && txtBoxPassword.Text.Trim() == v.Password)
                    {
                        login = true;
                        frmVisitor visitorFrm = new frmVisitor();
                        visitorFrm.ShowDialog();
                        break;
                    }
                }

                if (!login)
                {
                    MessageBox.Show("Invalid Username/Password");
                }
            }
            else if (cBoxAccountType.SelectedItem.ToString() == "Employee")
            {
                foreach (Employees emp in employees)
                {
                    if (txtBoxUserName.Text.Trim() == emp.UserName && txtBoxPassword.Text.Trim() == emp.Password)
                    {
                        login = true;
                        if (emp.EmployeeType == "Manager")
                        {
                            frmManagerDashboard managerFrm = new frmManagerDashboard();
                            managerFrm.ShowDialog();
                            break;
                        }
                        else
                        {
                            frmEmployeeAddAnimal employeeFrm = new frmEmployeeAddAnimal();
                            employeeFrm.ShowDialog();
                            break;
                        }
                    }
                }

                if (!login)
                {
                    MessageBox.Show("Invalid Username/Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid Account Type");
            }

        }

        private void frmMainLogin_Load(object sender, EventArgs e)
        {
            visitors = accountDB.GetAllVisitors();
            employees = accountDB.GetAllEmployees();
            cBoxAccountType.SelectedIndex = 0;
        }
    }
}
