using System;
using BusinessLayer;
using ModelLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public class UserService : IUserService
    {
        UserController UserCtr;

        public UserService()
        {
            UserCtr = new UserController();
        }
        public void CreateUser(User user)
        {
            UserCtr.CreateUser(user);
        }

        public User GetUser(int id)
        {
            return UserCtr.GetUser(id);
        }

        public IEnumerable<User> getAllUsers()
        {
            return UserCtr.getAllUsers();
        }
    }
}
