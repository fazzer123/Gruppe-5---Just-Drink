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

        public User GetUser(int id)
        {
            return uDb.GetUser(id);
        }
        public IEnumerable<User> getAllUsers()
        {
            return uDb.getAllUsers();
        }
        public void UpdateUser(User user)
        {
            uDb.UpdateUser(user);
        }
        public void DeleteUser(int UserID)
        {
            uDb.DeleteUser(UserID);
        }

        public bool Login(string username, string password)
        {
            return uDb.Login(username, password);
        }
    }
}
    

