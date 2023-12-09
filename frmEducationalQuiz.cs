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
    public partial class frmEducationalQuiz : Form
    {
        public frmEducationalQuiz()
        {
            InitializeComponent();
        }

        private void frmEducationalQuiz_Load(object sender, EventArgs e)
        {
            pbxQuiz1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxQuiz1.Load("https://i.pinimg.com/564x/42/3b/f0/423bf0eacc275ab22193f43799f47567.jpg");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
