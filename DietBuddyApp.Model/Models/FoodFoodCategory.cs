using DietBuddyApp.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.Model.Models
{
    public class FoodFoodCategory 
    {
        public int FoodID { get; set; }
        public virtual Food Food { get; set; }
        public int FoodCategoryID { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
    }
}
