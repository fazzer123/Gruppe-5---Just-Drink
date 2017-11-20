using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace WCF
{
    [ServiceContract]
    interface IMenuCardService
    {
        [OperationContract]
        void createMenuCard(MenuCard menuCard);

        [OperationContract]
        void addDrink(Customer cus, Drink drink);
        [OperationContract]
        MenuCard GetMenuByCustomerID(int cusId);
        [OperationContract]
        List<Drink> getAllDrinksByMenucard(int menID);
    }
}
