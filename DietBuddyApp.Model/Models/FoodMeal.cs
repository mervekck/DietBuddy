using DietBuddyApp.DAL.Entities;
using DietBuddyApp.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.Model.Models
{
    public class FoodMeal : Base
    {
        public int FoodID { get; set; }
        public virtual Food Food { get; set; }
        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }
        public DateTime Date { get; set; }
    }
}
