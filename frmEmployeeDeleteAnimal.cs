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
    public partial class frmEmployeeDeleteAnimal : Form
    {
        //private AnimalDB animal;
        public frmEmployeeDeleteAnimal()
        {
            InitializeComponent();
        }
        AnimalDB animalDB = new AnimalDB();

        private void frmEmployeeDeleteAnimal_Load(object sender, EventArgs e)
        {
            PopulateMenuItems();
            cobNickName.DataSource = animalDB.LoadAnimalPersonalNameTable();
            cobNickName.DisplayMember = "animalPersonalName";
            cobNickName.ValueMember = "animalPersonalName";

            cobBreed.DataSource = animalDB.LoadAnimalBreedTable();
            cobBreed.DisplayMember = "animalBreed";
            cobBreed.ValueMember = "animalBreed";

            cobAnimalType.DataSource = animalDB.LoadAnimalType();
            cobAnimalType.DisplayMember = "animalType";
            cobAnimalType.ValueMember = "animalType";
        }

        private void btnTransferOut_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                //stackover - "How to delete a selected DataGridViewRow and update a connected database table?
                //https://stackoverflow.com/questions/2084346/how-to-delete-a-selected-datagridviewrow-and-update-a-connected-database-table
                int selectedItemId = Convert.ToInt32(dgvTable.CurrentRow.Cells["animalID"].Value);

                //AnimalDB animalDB = new AnimalDB();

                AnimalDB.DeleteMenuItem(selectedItemId);

                MessageBox.Show("Menu item deleted successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //populate the data grid view from the databse
        private void PopulateMenuItems()
        {
            AnimalDB animalDB = new AnimalDB();
            DataTable Items = animalDB.LoadDeleteAnimal();
            dgvTable.DataSource = Items;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedType = cobAnimalType.SelectedValue.ToString();

            DataTable filteredType = animalDB.FilterAnimalsByType(selectedType);

            dgvTable.DataSource = filteredType;

        }

        private void btnFilterBreed_Click(object sender, EventArgs e)
        {
            string selectedBreed = cobBreed.SelectedValue.ToString();

            DataTable filteredBreed = animalDB.FilterAnimalsByBreed(selectedBreed);

            dgvTable.DataSource = filteredBreed;
        }

        private void btnFilterNickName_Click(object sender, EventArgs e)
        {
            string selectedPersonalName = cobNickName.SelectedValue.ToString();

            DataTable filteredPersonaNAme = animalDB.FilterAnimalsByPersonalName(selectedPersonalName);

            dgvTable.DataSource = filteredPersonaNAme;
        }
    }
}
