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

        public User GetUserByUserName(string username, string password)
        {
            IEnumerable<User> users = new List<User>();
            users = uDb.getAllUsers();
            Boolean found = false;
            User user = null;
            int t = 0;

            while (!found)
            {
                for(int i = 0 ; i < users.Count(); i++)
                {
                    if(users.ElementAt(i).UserName == username && users.ElementAt(i).Password == password)
                    {
                        user = users.ElementAt(i);
                        found = true;
                    }
                }
                found = true;
            }
            return user;
        }

        public bool Login(string username, string password)
        {
            return uDb.Login(username, password);
        }
    }
}
    

