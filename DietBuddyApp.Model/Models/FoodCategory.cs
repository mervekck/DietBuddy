using DietBuddyApp.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.Model.Models
{
    public class FoodCategory : Base
    {
        public string Name { get; set; }
        public virtual ICollection<FoodFoodCategory> FoodFoodCategories { get; set; } = new List<FoodFoodCategory>();
    }
}
