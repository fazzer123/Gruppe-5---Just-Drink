using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using BusinessLayer;

namespace WCF
{
    class MenuCardService : IMenuCardService
    {
        MenuCardController mCtr = new MenuCardController();

        public void addDrink(Customer cus, Drink drink)
        {
            mCtr.AddDrink(cus, drink);
        }

        public void createMenuCard(MenuCard menuCard)
        {
            mCtr.createMenuCard(menuCard);
        }

        public List<Drink> getAllDrinksByMenucard(int menID)
        {
            return mCtr.getAllDrinksByMenucard(menID);
        }

        public MenuCard GetMenuByCustomerID(int cusId)
        {
            return mCtr.GetMenu(cusId);
        }
    }
}
