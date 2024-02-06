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
    public class UserRepository : IRepository<User>
    {
        DietBuddyContext db = new DietBuddyContext();
        public void Add(User item)
        {
            db.Users.Add(item);
            db.SaveChanges();
        }

        public void Delete(User item)
        {
            db.Users.Remove(item);
            db.SaveChanges();
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public User GetBuId(int id)
        {
            return db.Users.Find(id);
        }

        public void Update(User item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        //kayıt olurken email sadece 1 kişi özelinde kayıt olmalı
        public bool IsEmailExist(string email)
        {
            return db.Users.Any(u => u.EMail.Equals(email));
        }

        //login için
        public User Login(string email, string password)
        {
            var loggedInUser = db.Users.FirstOrDefault(u => u.EMail.Equals(email) && u.Password.Equals(password));

            return loggedInUser;
        }

        // Veritabanından e-posta adresine göre kullanıcıyı getir
        public User GetUserByEmail(string email)
        {
            return db.Users.FirstOrDefault(u => u.EMail.Equals(email));
        }
    }
}
