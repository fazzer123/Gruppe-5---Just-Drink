using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;

namespace BusinessLayer
{
    public class UserController
    {
        UserDB uDb;

        public UserController()
        {
            uDb = new UserDB();
        }

        public void CreateUser(User user)
        {
            uDb.CreateUser(user);
        }

        public User GetUser(string UserName)
        {
            return uDb.GetUser(UserName);
        }
        public IEnumerable<User> getAllUsers()
        {
            return uDb.getAllUsers();
        }
    }
}
    

