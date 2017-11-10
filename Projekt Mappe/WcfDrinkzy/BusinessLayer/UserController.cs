using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataaccessLayer.Interface;
using DataaccessLayer.Repositories;
using Modellayer;

namespace BusinessLayer
{
    public class UserController : ICRUD<User>
    {
        UserRepository uRep = new UserRepository();
        public void Add(User entity)
        {
            uRep.Add(entity);
        }

        public IEnumerable<User> Find(string queryString)
        {
            return uRep.Find(queryString);
        }

        public User Get(int id, bool includeRelations)
        {
            return uRep.Get(id, includeRelations);
        }

        public IEnumerable<User> GetAll()
        {
            return uRep.GetAll();
        }

        public void Remove(User entity)
        {
            uRep.Remove(entity);
        }

        public void Update(User entity)
        {
            uRep.Update(entity);
        }
    }
}
