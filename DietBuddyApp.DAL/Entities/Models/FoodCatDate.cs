using DietBuddyApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.DAL.Entities.Models
{
    public class FoodCatDate : Base
    {
        public int UserId { get; set; }
        public string Date { get; set; }
        public string Meal { get; set; }
        public string FoodCategory { get; set; }
        public string Food { get; set; }
        public string Measure { get; set; }
        public string TotalCalories { get; set; }
        public string TotalFat { get; set; }
        public string TotalProtein { get; set; }
        public string TotalCarbs { get; set; }
    }
}
