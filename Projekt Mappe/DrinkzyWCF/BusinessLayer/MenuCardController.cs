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

        public void createMenuCard(int CuID)
        {
            db.CreateMenuCard(CuID);
        }

        public void AddDrink(MenuCard mc, int drinkID)
        {
            db.AddDrink(mc, drinkID);
        }

        public MenuCard GetMenu(int cusId)
        {
            return db.GetMenuCardByCustomerID(cusId);
        }

        public List<Drink> getAllDrinksByMenucard(int menID)
        {
            return db.GetAllDrinksByCustomer(menID);
        }

        public void DeleteDrinkFromMenu(int menuID, int drinkid)
        {
            db.DeleteDrinkFromMenu(menuID, drinkid);
        }

    }
}
