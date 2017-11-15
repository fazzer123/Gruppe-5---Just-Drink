﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using ModelLayer;

namespace WCF
{
    class CustomerService : ICustomerService
    {
        CustomerController cusCtr;
        public CustomerService()
        {
            cusCtr = new CustomerController();
        }
        public void CreateCustomer(Customer customer)
        {
            cusCtr.CreateCustomer(customer);
        }

        public Customer GetCustomer(string CusName)
        {
            return cusCtr.GetCustomer(CusName);
        }
       
        public IEnumerable<Customer> GetAllCustomers()
        {
            return cusCtr.GetAllCustomers();
        }
    }
}
