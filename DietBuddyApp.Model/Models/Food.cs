using DietBuddyApp.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.Model.Models
{
    public class Food : Base
    {
        public string Name { get; set; }
        public double Calory { get; set; }
        public double Carbohydrate { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public byte[]? FoodPictureByte { get; set; }
        public string? StringPicture { get; set; }
        public virtual ICollection<FoodFoodCategory> FoodFoodCategories { get; set; } = new List<FoodFoodCategory>();
        public virtual ICollection<FoodMeal> FoodMeals { get; set; } = new List<FoodMeal>();
    }
}
