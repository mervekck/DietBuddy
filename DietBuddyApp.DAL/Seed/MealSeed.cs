using DietBuddyApp.DAL.Entities.Enums;
using DietBuddyApp.DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.DAL.Seed
{
    public class MealSeed 
    {
        public void AddMealData(ModelBuilder modelBuilder)
        {
            var mealNames = Enum.GetNames(typeof(Meals));

            modelBuilder.Entity<Meal>().HasData(
                mealNames.Select((mealName, index) => new Meal { ID = index + 1, Name = Enum.Parse<Meals>(mealName) })
            );
            //modelBuilder.Entity<Meal>().HasData(
            //    new Meal { ID = 1, Name = Meals.Breakfast },
            //    new Meal { ID = 2, Name = Meals.Lunch },
            //    new Meal { ID = 3, Name = Meals.Dinner },
            //    new Meal { ID = 4, Name = Meals.Snack }
            //    );
        }
    }
}
