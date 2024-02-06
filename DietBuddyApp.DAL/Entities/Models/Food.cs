using DietBuddyApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.DAL.Entities.Models
{
    public class Food : Base
    {
        public string Name { get; set; }
        public double Measure { get; set; }
        public double Calory { get; set; }
        public double Carbohydrate { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public string Picture { get; set; }
        public virtual ICollection<FoodFoodCategory> FoodFoodCategorys { get; set; } = new List<FoodFoodCategory>();
        

    }
}
