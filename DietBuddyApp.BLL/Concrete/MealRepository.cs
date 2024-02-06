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
    public class MealRepository : IRepository<Meal>
    {
        DietBuddyContext db = new DietBuddyContext();
        public void Add(Meal item)
        {
            db.Meals.Add(item);
            db.SaveChanges();
        }

        public void Delete(Meal item)
        {
            db.Meals.Remove(item);
            db.SaveChanges();
        }

        public List<Meal> GetAll()
        {
            return db.Meals.ToList();
        }

        public Meal GetBuId(int id)
        {
            return db.Meals.Find(id);
        }

        public void Update(Meal item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
