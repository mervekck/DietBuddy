using DietBuddyApp.BLL.Contract;
using DietBuddyApp.DAL.Context;
using DietBuddyApp.DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.BLL.Concrete
{
    public class FoodRepository : IRepository<Food>
    {
        DietBuddyContext db = new DietBuddyContext();
        public void Add(Food item)
        {
            db.Foods.Add(item);
            db.SaveChanges();
        }

        public void Delete(Food item)
        {
            db.Foods.Remove(item);
            db.SaveChanges();
        }

        public List<Food> GetAll()
        {
            return db.Foods.ToList();
        }

        public Food GetBuId(int id)
        {
            return db.Foods.Find(id);
        }

        public void Update(Food item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public string GetFoodImage(int foodID)
        {
            // Yemek Id'sine göre veritabanından resim dosya yolunu al
            var food = db.Foods.Find(foodID);
            return food?.Picture;
        }
    }
}
