using DataaccessLayer.Interface;
using DataaccessLayer.Repositories;
using Modellayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerController : ICRUD<Customer>
    {
        CustomerRepository cRep = new CustomerRepository();

        public void Add(Customer entity)
        {
            cRep.Add(entity);
        }

        public IEnumerable<Customer> Find(string queryString)
        {
            return cRep.Find(queryString);
        }

        public Customer Get(int id, bool includeRelations)
        {
            return cRep.Get(id, includeRelations);
        }

        public IEnumerable<Customer> GetAll()
        {
            return cRep.GetAll();
        }

        public void Remove(Customer entity)
        {
            cRep.Remove(entity);
        }

        public void Update(Customer entity)
        {
            cRep.Update(entity);
        }
    }
}
