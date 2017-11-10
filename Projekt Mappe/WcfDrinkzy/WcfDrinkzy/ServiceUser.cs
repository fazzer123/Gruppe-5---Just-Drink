using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellayer;
using BusinessLayer;

namespace WcfDrinkzy
{
    class ServiceUser : IServiceUser
    {
        UserController uCtr = new UserController(); 
        public void CreateUser(User User)
        {
            uCtr.Add(User);
        }

        public void DeleteUser(User User)
        {
            uCtr.Remove(User);
        }

        public IEnumerable<User> GetUser(string name)
        {
            return uCtr.Find(name);
        }

        public IEnumerable<User> GetUserList()
        {
            return uCtr.GetAll();
        }
    }
}
