using DietBuddyApp.DAL.Entities.Models;
using DietBuddyApp.DAL.Seed;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Emit;

namespace DietBuddyApp.DAL.Context
{
    public class DietBuddyContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategorys { get; set; }
        public virtual DbSet<FoodFoodCategory> FoodFoodCategorys { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<FoodCatDate> FoodCatDates { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-JS8IS6GT\\SQLEXPRESS;database=DietBuddyDB;Trusted_Connection=True;TrustServerCertificate=true;");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FoodSeed foodSeed = new FoodSeed();
            FoodCategorySeed foodCategorySeed = new FoodCategorySeed();
            FoodFoodCategorySeed foodFoodCategorySeed = new FoodFoodCategorySeed();
            MealSeed mealSeed = new MealSeed();

            modelBuilder.Entity<FoodFoodCategory>().HasKey(ffc => new { ffc.FoodID, ffc.FoodCategoryID });
            

            modelBuilder.Entity<User>(e =>
            {
                e.Property(e => e.ID).HasColumnName("ID").UseIdentityColumn(1, 1);
                e.Property(e => e.FirstName).HasMaxLength(50);
                e.Property(e => e.LastName).HasMaxLength(50);
                e.HasIndex(e => e.EMail).IsUnique();
                e.Property(e => e.EMail).HasMaxLength(25).IsRequired();
                e.Property(e => e.Password).IsRequired();
            });

            modelBuilder.Entity<FoodCategory>(e =>
            {
                e.Property(e => e.ID).HasColumnName("ID").UseIdentityColumn(1, 1);
                e.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Food>(e =>
            {
                e.Property(e => e.ID).HasColumnName("ID").UseIdentityColumn(1, 1);
                e.Property(e => e.Name).HasMaxLength(50).IsRequired();
            });

            foodSeed.AddFoodData(modelBuilder);
            foodCategorySeed.AddFoodCategoryData(modelBuilder);
            foodFoodCategorySeed.AddFoodFoodCategoryData(modelBuilder);
            mealSeed.AddMealData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
        
    }
}
