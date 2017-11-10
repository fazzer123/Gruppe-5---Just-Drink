using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataaccessLayer.Interface;
using Modellayer;

namespace DataaccessLayer.Repositories
{
    public class UserRepository : ICRUD<User>
    {
        DbContext db = new DbContext();

        public void Add(User entity)
        {
            db.Users.Add(entity);
        }

        public IEnumerable<User> Find(string queryString)
        {
            return db.Users.Where(x => x.LastName.ToLower().Contains(queryString.ToLower()));
        }

        public User Get(int id, bool includeRelations)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public void Remove(User entity)
        {
            db.Users.Remove(entity);
        }

        public void Update(User entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
