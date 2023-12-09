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
    public partial class frmManagerDashboard : Form
    {
        public frmManagerDashboard()
        {
            InitializeComponent();
        }

        private void btnTransferIn_Click(object sender, EventArgs e)
        {
            //open the employee form that add animals
            frmEmployeeAddAnimal addAnimal = new frmEmployeeAddAnimal();
            //modal form
            addAnimal.ShowDialog();
        }

        private void btnTransferOut_Click(object sender, EventArgs e)
        {
            //open the employee form that delete animals
            frmEmployeeDeleteAnimal deleteAnimal = new frmEmployeeDeleteAnimal();
            //modal form
            deleteAnimal.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            //open the employee form that view all animals
            frmEmployeeViewAllAnimals viewAnimals = new frmEmployeeViewAllAnimals();
            //modal form
            viewAnimals.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //open the employee form that modify animals
            frmEmployeeModifyAnimal modifyAnimals = new frmEmployeeModifyAnimal();
            //modal form
            modifyAnimals.ShowDialog();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            FrmAddEvents addEvents = new FrmAddEvents();
            addEvents.ShowDialog();
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            FrmDeleteEvent deleteEvent = new FrmDeleteEvent();
            deleteEvent.ShowDialog();
        }

        private void btnViewEvents_Click(object sender, EventArgs e)
        {
            frmViewAllEvents viewEvent = new frmViewAllEvents();
            viewEvent.ShowDialog();
        }

        private void btnZooMap_Click(object sender, EventArgs e)
        {
            frmEducationalMap map = new frmEducationalMap();
            map.ShowDialog();
        }

        private void btnLabelingGame_Click(object sender, EventArgs e)
        {
            frmEducationalLabeling label = new frmEducationalLabeling();
            label.ShowDialog();
        }

        private void btnFunFact_Click(object sender, EventArgs e)
        {
            frmEducationalInfo info = new frmEducationalInfo();
            info.ShowDialog();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            frmEducationalQuiz quiz = new frmEducationalQuiz();
            quiz.ShowDialog();
        }
    }
}
