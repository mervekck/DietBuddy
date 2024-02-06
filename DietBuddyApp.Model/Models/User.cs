using DietBuddyApp.DAL.Enums;
using DietBuddyApp.Model.Abstract;
using DietBuddyApp.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.DAL.Entities
{
    public class User : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public virtual ICollection<FoodMeal> FoodMeals { get; set; } = new List<FoodMeal>();
    }
}
