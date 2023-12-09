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
    public partial class FrmAddEvents : Form
    {
        EventDB eventDB = new EventDB();
        public FrmAddEvents()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FrmAddEvents_Load(object sender, EventArgs e)
        {
            dgvTable.DataSource = eventDB.GetAllEventFields();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text;
            if (string.IsNullOrWhiteSpace(eventName))
            {
                lblError.Text = ("The event name cannot be empty.");
                lblError.Visible = true;
                return;
            }

            string eventDate = txtEventDate.Text;
            if (string.IsNullOrWhiteSpace(eventDate))
            {
                lblError.Text = ("The event date cannot be empty.");
                lblError.Visible = true;
                return;
            }

            string eventDescription = txtEventDescription.Text;
            if (string.IsNullOrWhiteSpace(eventDescription))
            {
                lblError.Text = ("The event description cannot be empty.");
                lblError.Visible = true;
                return;
            }

            string eventImage = txtEventImage.Text;
            if (string.IsNullOrWhiteSpace(eventImage))
            {
                lblError.Text = ("The event image cannot be empty.");
                lblError.Visible = true;
                return;
            }

            Events events = new Events(eventName, eventDate, eventDescription, eventDate);
            eventDB.InsertEvent(events.EventName, events.EventDate, events.EventDescription, events.EventDate);
            dgvTable.DataSource = eventDB.GetAllEventFields();

        }
    }
}
