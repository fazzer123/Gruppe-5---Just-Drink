using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataaccessLayer.Interface;
using Modellayer;

namespace DataaccessLayer.Repositories
{
    public class IngredientRepository : ICRUD<Ingredients>
    {
        DbContext db = new DbContext();

        public void Add(Ingredients entity)
        {
            db.Ingredientses.Add(entity);
        }

        public IEnumerable<Ingredients> Find(string queryString)
        {
            return db.Ingredientses.Where(x => x.Name.ToLower().Contains(queryString.ToLower())); 
        }

        public Ingredients Get(int id, bool includeRelations)
        {
            return db.Ingredientses.Find(id);
        }

        public IEnumerable<Ingredients> GetAll()
        {
            return db.Ingredientses;
        }

        public void Remove(Ingredients entity)
        {
            db.Ingredientses.Remove(entity);
        }

        public void Update(Ingredients entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges(); 
        }
    }
}
