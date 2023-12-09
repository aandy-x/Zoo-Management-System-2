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
    public partial class FrmDeleteEvent : Form
    {
        public FrmDeleteEvent()
        {
            InitializeComponent();
        }

        EventDB eventDB = new EventDB();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTransferOut_Click(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                //stackover - "How to delete a selected DataGridViewRow and update a connected database table?
                //https://stackoverflow.com/questions/2084346/how-to-delete-a-selected-datagridviewrow-and-update-a-connected-database-table
                int selectedItemId = Convert.ToInt32(dgvTable.CurrentRow.Cells["eventID"].Value);

                //AnimalDB animalDB = new AnimalDB();

                EventDB.DeleteEvent(selectedItemId);

                MessageBox.Show("Menu item deleted successfully.");

                PopulateMenuItems();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void FrmDeleteEvent_Load(object sender, EventArgs e)
        {
            PopulateMenuItems();
        }

        //populate the data grid view from the databse
        private void PopulateMenuItems()
        {
            DataTable Items = eventDB.LoadViewAllEvent();
            dgvTable.DataSource = Items;
        }
    }
}
