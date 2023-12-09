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
    public partial class frmEmployeeModifyAnimal : Form
    {
        public frmEmployeeModifyAnimal()
        {
            InitializeComponent();
        }

        AnimalDB animalDB = new AnimalDB();

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                int selectedAnimalID = Convert.ToInt32(dgvTable.CurrentRow.Cells["animalID"].Value);
                string newAnimeCountryPhoto = txtAnimalCountryofOriginPhoto.Text;

                if (string.IsNullOrWhiteSpace(newAnimeCountryPhoto))
                {
                    MessageBox.Show("Animal's country photo cannot be empty.");
                    return;
                }

                animalDB.UpdateAnimalCountryOfOriginPhoto(selectedAnimalID, newAnimeCountryPhoto);

                MessageBox.Show("Animal's country photo updated successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an animal's country of origin photo to update.");
            }
        }
        private void PopulateMenuItems()
        {
            AnimalDB animalDB = new AnimalDB();
            DataTable Items = animalDB.LoadModifyAnimal();
            dgvTable.DataSource = Items;
        }

        private void frmEmployeeModifyAnimal_Load(object sender, EventArgs e)
        {
            PopulateMenuItems();

        }

        private void btnModifyGender_Click(object sender, EventArgs e)
        {
       
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModifyAnimalPersonalName_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                int selectedAnimalID = Convert.ToInt32(dgvTable.CurrentRow.Cells["animalID"].Value);
                string newAnimalPersonalName = txtAnimalPersonalName.Text;

                if (string.IsNullOrWhiteSpace(newAnimalPersonalName))
                {
                    MessageBox.Show("Animal's personal name cannot be empty.");
                    return;
                }

                animalDB.UpdateAnimalPersonalName(selectedAnimalID, newAnimalPersonalName);

                MessageBox.Show("Animal's personal name updated successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an animal personal name to update.");
            }
        }

        private void btnModifyAnimalPhoto_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                int selectedAnimalID = Convert.ToInt32(dgvTable.CurrentRow.Cells["animalID"].Value);
                string newAnimalPhoto = txtAnimalPhoto.Text;

                if (string.IsNullOrWhiteSpace(newAnimalPhoto))
                {
                    MessageBox.Show("Animal's photo cannot be empty.");
                    return;
                }

                animalDB.UpdateAnimalPhoto(selectedAnimalID, newAnimalPhoto);

                MessageBox.Show("Animal's photo updated successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an animal photo to update.");
            }
        }

        private void btnModifyCountry_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                int selectedAnimalID = Convert.ToInt32(dgvTable.CurrentRow.Cells["animalID"].Value);
                string newAnimalCountryOfOrigin = txtAnimalCountryofOrigin.Text;

                if (string.IsNullOrWhiteSpace(newAnimalCountryOfOrigin))
                {
                    MessageBox.Show("Animal's country of origin cannot be empty.");
                    return;
                }

                animalDB.UpdateAnimalCountryOfOrigin(selectedAnimalID, newAnimalCountryOfOrigin);

                MessageBox.Show("Animal's country of origin updated successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an animal's country of origin to update.");
            }
        }

        private void btnModifyAnimalBreed_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                int selectedAnimalID = Convert.ToInt32(dgvTable.CurrentRow.Cells["animalID"].Value);
                string newAnimalBreed = txtAnimalBreed.Text;

                if (string.IsNullOrWhiteSpace(newAnimalBreed))
                {
                    MessageBox.Show("Animal's breed cannot be empty.");
                    return;
                }

                animalDB.UpdateAnimalBreed(selectedAnimalID, newAnimalBreed);

                MessageBox.Show("Animal's breed updated successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an animal's breed to update.");
            }
        }

        private void btnModifyAnimalType_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                int selectedAnimalID = Convert.ToInt32(dgvTable.CurrentRow.Cells["animalID"].Value);
                string newAnimalType = txtAnimalType.Text;

                if (string.IsNullOrWhiteSpace(newAnimalType))
                {
                    MessageBox.Show("Animal's type cannot be empty.");
                    return;
                }

                animalDB.UpdateAnimalType(selectedAnimalID, newAnimalType);

                MessageBox.Show("Animal's type updated successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an animal's type to update.");
            }
        }

        private void btnModifyAnimalDescription_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                int selectedAnimalID = Convert.ToInt32(dgvTable.CurrentRow.Cells["animalID"].Value);
                string newAnimalDescription = txtAnimalDescription.Text;

                if (string.IsNullOrWhiteSpace(newAnimalDescription))
                {
                    MessageBox.Show("Animal's description cannot be empty.");
                    return;
                }

                animalDB.UpdateAnimalDescription(selectedAnimalID, newAnimalDescription);

                MessageBox.Show("Animal's description updated successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an animal's description to update.");
            }
        }

        private void btnModifyAnimalBehavior_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                int selectedAnimalID = Convert.ToInt32(dgvTable.CurrentRow.Cells["animalID"].Value);
                string newAnimalBehavior = txtAnimalBehavior.Text;

                if (string.IsNullOrWhiteSpace(newAnimalBehavior))
                {
                    MessageBox.Show("Animal's behavior cannot be empty.");
                    return;
                }

                animalDB.UpdateAnimalBehavior(selectedAnimalID, newAnimalBehavior);

                MessageBox.Show("Animal's description behavior successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an animal's behavior to update.");
            }
        }

        private void btnModifyAge_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                int selectedAnimalID = Convert.ToInt32(dgvTable.CurrentRow.Cells["animalID"].Value);
                string newAnimalAge = txtAnimalAge.Text;

                if (string.IsNullOrWhiteSpace(newAnimalAge))
                {
                    MessageBox.Show("Animal's behavior cannot be empty.");
                    return;
                }

                animalDB.UpdateAnimalAge(selectedAnimalID, newAnimalAge);

                MessageBox.Show("Animal's age behavior successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an animal's behabior to update.");
            }
        }

        private void btnModifyHabitat_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                int selectedAnimalID = Convert.ToInt32(dgvTable.CurrentRow.Cells["animalID"].Value);
                string newAnimalHabiat = txtAnimalHabitat.Text;

                if (string.IsNullOrWhiteSpace(newAnimalHabiat))
                {
                    MessageBox.Show("Animal's Habiat cannot be empty.");
                    return;
                }

                animalDB.UpdateAnimalHabitat(selectedAnimalID, newAnimalHabiat);

                MessageBox.Show("Animal's Habiat successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an animal's Habiat to update.");
            }
        }
    }
}
