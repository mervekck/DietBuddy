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
    public class FoodCatDateRepository : IRepository<FoodCatDate>
    {
        DietBuddyContext db = new DietBuddyContext();
        public void Add(FoodCatDate item)
        {
            db.FoodCatDates.Add(item);
            db.SaveChanges();
        }

        public void Delete(FoodCatDate item)
        {
            db.FoodCatDates.Remove(item);
            db.SaveChanges();
        }

        public List<FoodCatDate> GetAll()
        {
            return db.FoodCatDates.ToList();
        }

        public FoodCatDate GetBuId(int id)
        {
            return db.FoodCatDates.Find(id);
        }

        public void Update(FoodCatDate item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

    }
}
