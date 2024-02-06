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
    public class FoodCategorySeed 
    {
        public void AddFoodCategoryData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodCategory>().HasData(

                    new FoodCategory { ID = 1, Name = "Breakfast" },
                    new FoodCategory { ID = 2, Name = "Cereal Products" },
                    new FoodCategory { ID = 3, Name = "Dairy Products" },
                    new FoodCategory { ID = 4, Name = "Vegetables" },
                    new FoodCategory { ID = 5, Name = "Snacks" },
                    new FoodCategory { ID = 6, Name = "Fruits" },
                    new FoodCategory { ID = 7, Name = "Boiled Vegetables" },
                    new FoodCategory { ID = 8, Name = "Salads" },
                    new FoodCategory { ID = 9, Name = "Fats" },
                    new FoodCategory { ID = 10, Name = "Soups" },
                    new FoodCategory { ID = 11, Name = "Vegetable Dishes" },
                    new FoodCategory { ID = 12, Name = "Grain and Legume Dishes" },
                    new FoodCategory { ID = 13, Name = "Poultry" },
                    new FoodCategory { ID = 14, Name = "Meat products" },
                    new FoodCategory { ID = 15, Name = "Seafood" }
                );
        }

        
    }
    }
