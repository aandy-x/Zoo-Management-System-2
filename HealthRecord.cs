using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management_System
{
    internal class HealthRecord
    {

        private string healthRecordBehaviorNote;
        private string healthRecordMedicalHistory;
        private string healthRecordVetVisits;
        private DateTime healthRecordDate;

        public HealthRecord()
        {
            healthRecordBehaviorNote = string.Empty;
            healthRecordMedicalHistory = string.Empty;
            healthRecordVetVisits = string.Empty;
            healthRecordDate = DateTime.MinValue;
        }

        public HealthRecord(string healthRecordBehaviorNote, string healthRecordMedicalHistory, string healthRecordVetVisits, DateTime healthRecordDate)
        {
            this.healthRecordBehaviorNote = healthRecordBehaviorNote;
            this.healthRecordMedicalHistory = healthRecordMedicalHistory;
            this.healthRecordVetVisits = healthRecordVetVisits;
            this.healthRecordDate = healthRecordDate;
        }

        public string HealthRecordBehaviorNote
        {
            get { return healthRecordBehaviorNote; }
            set { healthRecordBehaviorNote = value; }
        }

        public string HealthRecordMedicalHistory
        {
            get { return healthRecordMedicalHistory; }
            set { healthRecordMedicalHistory = value; }
        }

        public string HealthRecordVetVisits
        {
            get { return healthRecordVetVisits; }
            set { healthRecordVetVisits = value; }
        }

        public DateTime HealthRecordDate
        {
            get { return healthRecordDate; }
            set { healthRecordDate = value; }
        }
    }
}
