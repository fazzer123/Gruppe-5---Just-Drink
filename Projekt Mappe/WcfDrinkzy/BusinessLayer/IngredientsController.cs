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
    public class IngredientsController : ICRUD<Ingredients>
    {
        IngredientRepository iRep = new IngredientRepository();

        public void Add(Ingredients entity)
        {
            iRep.Add(entity);
        }

        public IEnumerable<Ingredients> Find(string queryString)
        {
            return iRep.Find(queryString);
        }

        public Ingredients Get(int id, bool includeRelations)
        {
            return iRep.Get(id, includeRelations);
        }

        public IEnumerable<Ingredients> GetAll()
        {
            return iRep.GetAll();
        }

        public void Remove(Ingredients entity)
        {
            iRep.Remove(entity);
        }

        public void Update(Ingredients entity)
        {
            iRep.Update(entity);
        }
    }
}
