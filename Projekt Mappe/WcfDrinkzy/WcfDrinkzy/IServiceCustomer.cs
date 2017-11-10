using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Modellayer;

namespace WcfDrinkzy
{
    [ServiceContract]
    interface IServiceCustomer
    {
        [OperationContract]
        IEnumerable<Customer> GetCustomer(string name);

        [OperationContract]
        IEnumerable<Customer> GetCustomerList();

        [OperationContract]
        void CreateCustomer(Customer Customer);

        [OperationContract]
        void DeleteCustomer(Customer customer);
    }
}
