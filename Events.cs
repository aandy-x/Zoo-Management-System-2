using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management_System
{
    class Events
    {
        private string eventName;
        private string eventDescription;
        private string eventImage;
        private string eventDate;

        public Events()
        {
            eventName = "";
            eventDescription = "";
            eventImage = "";
            eventDate = "";

        }

        public Events(string eventName, string eventDescription, string eventImage, string eventDate)
        {
            this.eventName = eventName;
            this.eventDescription = eventDescription;
            this.eventImage = eventImage;
            this.eventDate = eventDate;
        }

        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }

        public string EventDescription
        {
            get { return eventDescription; }
            set { eventDescription = value; }
        }

        public string EventImage
        {
            get { return eventImage; }
            set { eventImage = value; }
        }

        public string EventDate
        {
            get { return eventDate; }
            set { eventDate = value; }
        }
    }
}
