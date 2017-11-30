using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public class AuthService : IAuthService
    {
        public bool Login(string username, string password)
        {
            return "SuperStudent" == username && "1234" == password;
        }
    }
}
