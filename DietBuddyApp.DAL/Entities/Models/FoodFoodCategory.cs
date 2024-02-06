using DietBuddyApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.DAL.Entities.Models
{
    public class FoodFoodCategory 
    {
        public int FoodID { get; set; }
        public virtual Food Food { get; set; }
        public int FoodCategoryID { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
    }
}
