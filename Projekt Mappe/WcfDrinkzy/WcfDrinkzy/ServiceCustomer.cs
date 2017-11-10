using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellayer;
using BusinessLayer;

namespace WcfDrinkzy
{
    
    class ServiceCustomer : IServiceCustomer
    {
        CustomerController CusCtr = new CustomerController();

        public void CreateCustomer(Customer Customer)
        {
            CusCtr.Add(Customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            CusCtr.Remove(customer);
        }

        public IEnumerable<Customer> GetCustomer(string name)
        {
            return CusCtr.Find(name);
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            return CusCtr.GetAll();
        }
    }
}
