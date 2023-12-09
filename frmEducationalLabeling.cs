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
    public partial class frmEducationalLabeling : Form
    {
        public frmEducationalLabeling()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEducationalLabeling_Load(object sender, EventArgs e)
        {

        }
        private bool labelsVisible = true;

        private void btnReveal_Click(object sender, EventArgs e)
        {
            labelsVisible = !labelsVisible; 
            ToggleLabelsVisibility(); 
        }

        private void ToggleLabelsVisibility()
        {
            lblLabelDog.Visible = labelsVisible;
            lblLabelElephannts.Visible = labelsVisible;
            lblLabelHorse.Visible = labelsVisible;
            lblLabelLion.Visible = labelsVisible;
            lblLabelMonkey.Visible = labelsVisible;
            lblLabelParrot.Visible = labelsVisible;
            lblLabelPig.Visible = labelsVisible;
            lblLabelRabbit.Visible = labelsVisible;
            lblLabelSnake.Visible = labelsVisible;
        }

    }
}
