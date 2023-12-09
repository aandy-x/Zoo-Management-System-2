using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Zoo_Management_System
{
    class Animal
    {
        string animalPhoto;
        string animalCountryofOriginPhoto;
        string animalCountryofOrigin;
        string animalBreed;
        string animalPersonalName;
        string animalType;
        string animalDescription;
        string animalHabitat;
        string animalBehavior;
        string animalAge;
        string animalSex;

        public Animal()
        {
            animalPhoto = "";
            animalCountryofOriginPhoto = "";
            animalCountryofOrigin = "";
            animalBreed = "";
            animalPersonalName = "";
            animalType = "";
            animalDescription = "";
            animalHabitat = "";
            animalBehavior = "";
            animalAge = "";
            animalSex = "";
        }

        public Animal(string animalPhoto,string animalCountryofOriginPhoto, string animalCountryofOrigin,string animalBreed,string animalPersonalName,string animalType,string animalDescription, string animalHabitat, string animalBehavior,string animalAge,string animalSex)
        {
            this.animalPhoto = animalPhoto;
            this.animalCountryofOriginPhoto = animalCountryofOriginPhoto;
            this.animalCountryofOrigin = animalCountryofOrigin;
            this.animalBreed = animalBreed;
            this.animalPersonalName = animalPersonalName;
            this.animalType = animalType;
            this.animalDescription = animalDescription;
            this.animalHabitat = animalHabitat;
            this.animalBehavior = animalBehavior;
            this.animalAge = animalAge;
            this.animalSex = animalSex;
        }

        public string AnimalPhoto
        {
            get { return animalPhoto; }
            set { animalPhoto = value; }
        }

        public string AnimalCountryofOriginPhoto
        {
            get { return animalCountryofOriginPhoto; }
            set { animalCountryofOriginPhoto = value; }
        }

        public string AnimalCountryofOrigin
        {
            get { return animalCountryofOrigin; }
            set { animalCountryofOrigin = value; }
        }

        public string AnimalBreed
        {
            get { return animalBreed; }
            set { animalBreed = value; }
        }

        public string AnimalPersonalName
        {
            get { return animalPersonalName; }
            set { animalPersonalName = value; }
        }

        public string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public string AnimalDescription
        {
            get { return animalDescription; }
            set { animalDescription = value; }
        }

        public string AnimalHabitat
        {
            get { return animalHabitat; }
            set { animalHabitat = value; }
        }

        public string AnimalBehavior
        {
            get { return animalBehavior; }
            set { animalBehavior = value; }
        }

        public string AnimalAge
        {
            get { return animalAge; }
            set { animalAge = value; }
        }

        public string AnimalSex
        {
            get { return animalSex; }
            set { animalSex = value; }
        }
    }
}
