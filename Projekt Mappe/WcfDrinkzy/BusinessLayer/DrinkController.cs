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
    

    public class DrinkController : ICRUD<Drink>
    {
        DrinkRepository dRep = new DrinkRepository();

        public void Add(Drink entity)
        {
            dRep.Add(entity);
        }

        public IEnumerable<Drink> Find(string queryString)
        {
            return dRep.Find(queryString);
        }

        public Drink Get(int id, bool includeRelations)
        {
            return dRep.Get(id, includeRelations);
        }

        public IEnumerable<Drink> GetAll()
        {
            return dRep.GetAll();
        }

        public void Remove(Drink entity)
        {
            dRep.Remove(entity);
        }

        public void Update(Drink entity)
        {
            dRep.Update(entity);
        }
    }
}
