using BusinessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class DrinkService : IDrinkService
    {
        DrinkController DrinkCtr;

        public DrinkService()
        {
            DrinkCtr = new DrinkController();
        }
        public void CreateDrink(Drink drink)
        {
            DrinkCtr.CreateDrink(drink);
        }

        public Drink GetDrink(int id)
        {
            return DrinkCtr.GetDrink(id);
        }
        public IEnumerable<Drink> getAllDrinks()
        {
            return DrinkCtr.getAllDrinks();
        }
    }
}
