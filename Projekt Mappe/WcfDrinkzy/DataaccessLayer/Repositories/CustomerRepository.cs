using DataaccessLayer.Interface;
using Modellayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataaccessLayer.Repositories
{
    public class CustomerRepository : ICRUD<Customer>
    {
        DbContext db = new DbContext();

        public void Add(Customer entity)
        {
            db.Customers.Add(entity);
            db.SaveChanges();
        }

        public IEnumerable<Customer> Find(string queryString)
        {
            return db.Customers.Where(x => x.Name.ToLower().Contains(queryString.ToLower()));
        }

        public Customer Get(int id, bool includeRelations)
        {
            return db.Customers.Find(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return db.Customers;
        }

        public void Remove(Customer entity)
        {
            db.Customers.Remove(entity);
            db.SaveChanges();
        }

        public void Update(Customer entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
