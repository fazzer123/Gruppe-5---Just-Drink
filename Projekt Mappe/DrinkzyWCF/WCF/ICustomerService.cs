using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ModelLayer;

namespace WCF
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        void CreateCustomer(Customer customer);
        [OperationContract]
        Customer GetCustomer(string CusName);

        [OperationContract]

        IEnumerable<Customer> GetAllCustomers();
    }
}
