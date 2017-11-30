using BusinessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public class AuthService : IAuthService
    {
        UserController uCtr = new UserController();
        public bool Login(string username, string password)
        {
            User user = uCtr.GetUserByUserName(username, password);
            Boolean auth;
            if (user != null)
            {
                auth = true;
            }
            else { auth = false; }
            return auth;
        }
    }
}
