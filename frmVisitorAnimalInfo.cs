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
    public partial class frmVisitorAnimalInfo : Form
    {
        AnimalDB animalDb;
        int index;
        List<Animal> animals;
        // global class variable used to store a reference of the form that
        // created and opened this form.
        private frmVisitorAnimals ownerForm;
        public frmVisitorAnimalInfo()
        {
            InitializeComponent();
        }

        public frmVisitorAnimalInfo(int index) : this()
        {
            this.index = index;
        }

        public void SetOwner(Form theForm)
        {
            animalDb = new AnimalDB();
            animals = animalDb.GetAnimalList();
            // Cast the form to the correct class.
            ownerForm = (frmVisitorAnimals)theForm;
            lblAnimalBreed.Text = "Animal Breed: " + animals[index].AnimalBreed;
            lblAnimalPersonalName.Text = "Animal Personal Name: " + animals[index].AnimalPersonalName;
            lblAnimalTyper.Text = "Animal Type: " + animals[index].AnimalType;
            lblAnimalHabitat.Text = "Animal Habitat: " + animals[index].AnimalHabitat;
            lblAnimalBehavior.Text = "Animal Behavior: " + animals[index].AnimalBehavior;
            lblAnimalAge.Text = "Animal Age: " + animals[index].AnimalAge;
            lblAnimalSex.Text = "Animal Sex: " + animals[index].AnimalSex;
            lblAnimalCountry.Text = "Animal Country Of Origin: " + animals[index].AnimalCountryofOrigin;
            lblAnimalDescription.Text = "Animal Description:\n" + animals[index].AnimalDescription;
            try
            {
                picBoxAnimal.Load(animals[index].AnimalPhoto);
            }
            catch (Exception)
            {
                picBoxAnimal.Image = picBoxAnimal.ErrorImage;
            }
            try
            {
                picBoxCountry.Load(animals[index].AnimalCountryofOriginPhoto);
            }
            catch (Exception)
            {
                picBoxCountry.Image = picBoxCountry.ErrorImage;
            }
        }
        private void frmVisitorAnimalInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
