using DBLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DrinkController
    {
        DrinkDB dDb;

        public DrinkController()
        {
            dDb = new DrinkDB();
        }

        public void CreateDrink(Drink drink)
        {
            dDb.CreateDrink(drink);
        }

        public Drink GetDrink(int id)
        {
            return dDb.GetDrink(id);
        }

        public IEnumerable<Drink> getAllDrinks()
        {
            return dDb.getAllDrinks();
        }

        public IEnumerable<Drink> searchDrinks(string search)
        {
            List<Drink> drinks = new List<Drink>();
            string search2 = search.ToLower().Trim();

            foreach (Drink d in dDb.getAllDrinks())
            {
                if(d.Description.ToLower().Contains(search2) || d.Name.ToLower().Contains(search2))
                {
                    drinks.Add(d);
                }
            }

            return drinks;
        }
    }
}
