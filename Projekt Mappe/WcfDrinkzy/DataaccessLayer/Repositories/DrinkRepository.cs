using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataaccessLayer.Interface;
using Modellayer;

namespace DataaccessLayer.Repositories
{
    public class DrinkRepository : ICRUD<Drink>
    {
        DbContext db = new DbContext();

        public void Add(Drink entity)
        {
            db.Drinks.Add(entity);
            db.SaveChanges();
        }

        public IEnumerable<Drink> Find(string queryString)
        {
             return db.Drinks.Where(x => x.Name.ToLower().Contains(queryString.ToLower()));
        }

        public Drink Get(int id, bool includeRelations)
        {
            return db.Drinks.Find(id);
        }

        public IEnumerable<Drink> GetAll()
        {
            return db.Drinks;
        }

        public void Remove(Drink entity)
        {
            db.Drinks.Remove(entity);
            db.SaveChanges();
        }

        public void Update(Drink entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
