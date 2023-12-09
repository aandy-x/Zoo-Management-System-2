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
    public partial class frmEducationalInfo : Form
    {
        public frmEducationalInfo()
        {
            InitializeComponent();
        }

        private void frmEducationalInfo_Load(object sender, EventArgs e)
        {
            pbxQuiz1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxQuiz1.Load("https://cdn.abcteach.com/abcteach-content-member/docs/web_pub_preview/z/zooanimals_p-0.jpg");

            pbxQuiz2.SizeMode = PictureBoxSizeMode.Zoom;
            pbxQuiz2.Load("https://cdn.abcteach.com/abcteach-content-member/docs/web_pub_preview/z/zooanimals_p-2.jpg");


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
