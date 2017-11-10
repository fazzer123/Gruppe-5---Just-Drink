using Modellayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfDrinkzy
{
    [ServiceContract]
    interface IServiceUser
    {
        [OperationContract]
        IEnumerable<User> GetUser(string name);

        [OperationContract]
        IEnumerable<User> GetUserList();

        [OperationContract]
        void CreateUser(User User);

        [OperationContract]
        void DeleteUser(User User);
    }
}
