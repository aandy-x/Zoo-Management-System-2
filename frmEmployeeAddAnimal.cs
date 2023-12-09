using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zoo_Management_System
{
    public partial class frmEmployeeAddAnimal : Form
    {
        AnimalDB transfer = new AnimalDB();

        private string genderChecked;
        public frmEmployeeAddAnimal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string animalPhoto = txtAnimalPhoto.Text;
            if (string.IsNullOrWhiteSpace(animalPhoto))
            {
                lblError.Text = ("Animal photo cannot be empty.");
                lblError.Visible = true;
                return;
            }

            //if (!File.Exists(animalPhoto))
            //{
            //    lblError.Text = ("Animal photo URL address is not found.");
            //    lblError.Visible = true;
            //    return;
            //}

            string animalCountryPhoto = txtAnimalCountryofOriginPhoto.Text;
            if (string.IsNullOrWhiteSpace(animalCountryPhoto))
            {
                lblError.Text = ("Animal's Country of origin photo cannot be empty.");
                lblError.Visible = true;
                return;
            }

            //if (!File.Exists(animalPhoto))
            //{
            //   lblError.Text = ("Animal's Country of origin photo URL address is not found.");
            //    lblError.Visible = true;
            //    return;
            //}

            string animalPersonalName = txtAnimalPersonalName.Text;
            if (string.IsNullOrWhiteSpace(animalPersonalName))
            {
                lblError.Text = ("The animal's personal name cannot be empty.");
                lblError.Visible = true;
                return;
            }

            string animalCountryofOrigin = txtAnimalCountryofOrigin.Text;
            if (string.IsNullOrWhiteSpace(animalCountryofOrigin))
            {
                lblError.Text = ("The animal's Country of origin cannot be empty.");
                lblError.Visible = true;
                return;
            }

            string animalBreed = txtAnimalBreed.Text;
            if (string.IsNullOrWhiteSpace(animalBreed))
            {
                lblError.Text = ("The animal's breed cannot be empty.");
                lblError.Visible = true;
                return;
            }

            string animalType = txtAnimalType.Text;
            if (string.IsNullOrWhiteSpace(animalType))
            {
                lblError.Text = ("The animal's type cannot be empty.");
                lblError.Visible = true;
                return;
            }

            string animalDescription = txtAnimalDescription.Text;
            if (string.IsNullOrWhiteSpace(animalDescription))
            {
                lblError.Text = ("The animal's description cannot be empty.");
                lblError.Visible = true;
                return;
            }

            string animalBehavior = txtAnimalBehavior.Text;
            if (string.IsNullOrWhiteSpace(animalBehavior))
            {
                lblError.Text = ("The animal's behavior cannot be empty.");
                lblError.Visible = true;
                return;
            }

            string animalAge = txtAnimalAge.Text;
            if (string.IsNullOrWhiteSpace(animalAge))
            {
                lblError.Text = ("The animal's age cannot be empty.");
                lblError.Visible = true;
                return;
            }

            string animalHabitat = txtAnimalHabitat.Text;
            if (string.IsNullOrWhiteSpace(animalAge))
            {
                lblError.Text = ("The animal's Habitat cannot be empty.");
                lblError.Visible = true;
                return;
            }

            if (!radMale.Checked && !radFemale.Checked)
            {
                lblError.Text = ("Please select one of the options for gender.");
                lblError.Visible = true;
                return;
            }
            else
            {
                if (radMale.Checked)
                {
                    genderChecked = "Male";
                }
                else
                {
                    genderChecked = "Female";
                }

            }
            Animal animal = new Animal(animalPhoto, animalCountryPhoto, animalCountryofOrigin, animalBreed, animalPersonalName, animalType, animalDescription, animalHabitat, animalBehavior, animalAge, genderChecked);
            transfer.SaveAnimal(animal.AnimalPhoto, animal.AnimalCountryofOriginPhoto, animal.AnimalCountryofOrigin, animal.AnimalBreed, animal.AnimalPersonalName, animal.AnimalType, animal.AnimalDescription, animal.AnimalHabitat, animal.AnimalBehavior, animal.AnimalAge, animal.AnimalSex);
            dgvTable.DataSource = transfer.GetAllAnimals();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTable.DataSource = transfer.GetAllAnimals();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
