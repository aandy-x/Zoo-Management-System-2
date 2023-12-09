using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management_System
{
    internal class DietPlan
    {
        private string dietTypeOfFood;
        private string dietFeedingSchedule;

        public DietPlan() {
            dietTypeOfFood = string.Empty;
            dietFeedingSchedule = string.Empty;
        }

        public DietPlan(string dietTypeOfFood, string dietFeedingSchedule)
        {
            this.dietTypeOfFood = dietTypeOfFood;
            this.dietFeedingSchedule = dietFeedingSchedule;
        }

        public string DietTypeOfFood
        {
            get { return dietTypeOfFood; }
            set { dietTypeOfFood = value; }
        }

        public string DietFeedingSchedule
        {
            get { return dietFeedingSchedule; }
            set { dietFeedingSchedule = value; }
        }

    }
}
