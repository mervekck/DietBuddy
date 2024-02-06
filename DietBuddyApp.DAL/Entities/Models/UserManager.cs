using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.DAL.Entities.Models
{
    public class UserManager
    {
        private static User _currentUser;

        public static User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }
    }
}
