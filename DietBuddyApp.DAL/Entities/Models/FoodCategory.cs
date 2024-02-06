using DietBuddyApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.DAL.Entities.Models
{
    public class FoodCategory : Base
    {
        public string Name { get; set; }
        public virtual ICollection<FoodFoodCategory> FoodFoodCategorys { get; set; } = new List<FoodFoodCategory>();
    }
}
