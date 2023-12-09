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
    public partial class frmVisitor : Form
    {
        public frmVisitor()
        {
            InitializeComponent();
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            frmVisitorAnimals visitorAFrm = new frmVisitorAnimals();
            visitorAFrm.ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {

        }

        private void frmVisitor_Load(object sender, EventArgs e)
        {

        }
    }
}
