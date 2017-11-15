using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ModelLayer;
using System.Threading.Tasks;

namespace WCF
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        void CreateUser(User user);

        [OperationContract]
        User GetUser(string UserName);

        [OperationContract]
        IEnumerable<User> getAllUsers();
    }
}
