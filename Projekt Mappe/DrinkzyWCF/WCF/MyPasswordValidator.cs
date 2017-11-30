using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel;
using System.IdentityModel.Selectors;
using System.ServiceModel;
using BusinessLayer;
using ModelLayer;

namespace WCF
{
    public class MyPasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == "SuperStudent" && password == "1234")
            {

            }
            else
            {
                throw new FaultException<Exception>(new Exception("Incorrect Login"), "Invalid login attempt");
            }
        }
    }
}
