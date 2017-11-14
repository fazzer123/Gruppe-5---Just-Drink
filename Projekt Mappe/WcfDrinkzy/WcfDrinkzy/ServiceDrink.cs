using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellayer;
using BusinessLayer;

namespace WcfDrinkzy
{
    class ServiceDrink : IServiceDrink
    {
        DrinkController dCtr = new DrinkController();

        public void CreateDrink(Drink Drink)
        {
            dCtr.Add(Drink);
        }

        public void DeleteDrink(Drink Drink)
        {
            dCtr.Remove(Drink);
        }

        public IEnumerable<Drink> GetDrink(string name)
        {
            return dCtr.Find(name);
        }

        public IEnumerable<Drink> GetDrinkList()
        {
            return dCtr.GetAll();
        }
    }
}
