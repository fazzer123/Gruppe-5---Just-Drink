using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DBLayer;

namespace BusinessLayer
{
    public class MenuCardController
    {
        private MenuCardDB db = new MenuCardDB();

        public void createMenuCard(MenuCard m)
        {
            db.CreateMenuCard(m);
        }

        public void AddDrink(Customer c, Drink d)
        {
            db.AddDrink(c, d);
        }

        public MenuCard GetMenu(int cusId)
        {
            return db.GetMenuCardByCustomerID(cusId);
        }

        public List<Drink> getAllDrinksByMenucard(int menID)
        {
            return db.GetAllDrinksByCustomer(menID);
        }

    }
}
