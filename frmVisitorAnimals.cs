using System;
using System.Collections;
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
    public partial class frmVisitorAnimals : Form
    {
        AnimalDB animalDb;
        List<Animal> animals;
        ArrayList buttons = new ArrayList();
        frmVisitorAnimalInfo infoForm;
        public frmVisitorAnimals()
        {
            InitializeComponent();
        }

        private void frmVisitorAnimals_Load(object sender, EventArgs e)
        {
            animalDb = new AnimalDB();
            animals = animalDb.GetAnimalList();
        }

        private void btnLoadAnimals_Click(object sender, EventArgs e)
        {
            const int ImgWidth = 100;
            const int ImgHeight = 100;
            const int ControlWidth = 100;
            const int ControlHeight = 50;
            const int Top = 0;
            const int OffsetFromLeft = 10;
            const int ControlSpacing = 1;

            int offsetFromTop = Top;
            int imgOffSet = offsetFromTop;
            for (int i = 0; i < animals.Count; i++)
            {
                Button control = new Button();
                control.Name = i.ToString();
                control.Text = "More Info";
                control.Size = new System.Drawing.Size(ControlWidth, ControlHeight);
                control.Click += new EventHandler(Button_Click);
                //control.Width = ControlWidth;
                //control.Height = ControlHeight;
                control.BackColor = Color.CornflowerBlue;


                // Calculate the controls position based on the position of the last control added
                offsetFromTop = offsetFromTop + ImgHeight + ControlSpacing;
                control.Location = new System.Drawing.Point(OffsetFromLeft + ImgWidth, offsetFromTop + ControlHeight / 2);

                // Store a reference to the object in the ArrayList and place it on the Form
                buttons.Add(control);
                this.Controls.Add(control);

                imgOffSet = offsetFromTop;
                PictureBox img = new PictureBox();
                try
                {
                    img.Load(animals[i].AnimalPhoto);
                }
                catch (Exception)
                {
                    img.Image = img.ErrorImage;
                    //img.Load("https://images.rawpixel.com/image_png_800/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIzLTA4L2hpcHBvdW5pY29ybjc2X3Bob3RvX29mX2JhYnlfbGFicmFkb3JfeWF3bmluZ19pc29sYXRlZF9vbl93aGl0ZV82YjVmMTIwMS02ZTU1LTRiMzQtOWQ4ZC0yNTM0NWQ4MmM3MDEucG5n.png");
                }
                img.SizeMode = PictureBoxSizeMode.Zoom;
                img.Size = new System.Drawing.Size(ImgWidth, ImgHeight);
                img.Location = new System.Drawing.Point(OffsetFromLeft, imgOffSet);
                this.Controls.Add(img);

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //event handler code

            Button button = (Button)sender;

            int index = int.Parse(button.Name);
            // Create an instance of the form to open.
            infoForm = new frmVisitorAnimalInfo(index);
            infoForm.SetOwner(this);
            // Open the form as a Modal form. Opening a modal form requires the user
            // to only interact with that form and no other forms until it is closed.
            infoForm.ShowDialog();
        }
    }
}
