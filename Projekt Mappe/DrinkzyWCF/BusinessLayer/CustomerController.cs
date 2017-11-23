using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;

namespace BusinessLayer
{
    public class CustomerController
    {
        CustomerDB cDb;

        public CustomerController()
        {
            cDb = new CustomerDB();
        }

        public void CreateCustomer(Customer customer)
        {
            cDb.CreateCustomer(customer);
        }

        public Customer GetCustomer(int id)
        {
            return cDb.GetCustomer(id);
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return cDb.GetAllCustomers();
        }

        public void UpdateCustomer(Customer customer)
        {
            cDb.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int customerID)
        {
            cDb.DeleteCustomer(customerID);
        }
            
    }
}

