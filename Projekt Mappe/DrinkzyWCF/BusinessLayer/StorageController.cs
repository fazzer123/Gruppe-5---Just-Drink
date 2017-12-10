using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;


namespace BusinessLayer
{
   public class StorageController
    {
        StorageDB sDb;
        OrderController oCtr;

        public StorageController()
        {
            sDb = new StorageDB();
            oCtr = new OrderController();
        }

        public void CreateStorage(Storage Storage)
        {
            sDb.CreateStorage(Storage);
        }

        public Storage GetStorage(int ID)
        {
            return sDb.GetStorage(ID);
        }

        public Storage GetDrinkStorage(int Cusid, int drinkID)
        {
            return sDb.GetDrinkStorage(Cusid, drinkID);
        }

        public void UpdateDrinkAmount(int CusID, int orderID)
        {
            Order order = oCtr.GetOrder(orderID);
            foreach (var ol in order.OrderLines)
            {
                if (ol.Drink.GetType() == typeof(Drink))
                {
                    Storage storage = sDb.GetDrinkStorage(CusID, ol.Drink.ID);
                    int newAmount = storage.Amount - ol.Amount;

                    sDb.UpdateDrinkStorage(storage.ID, ol.Drink.ID, newAmount);
                }

                else if (ol.Drink.GetType() == typeof(Alchohol))
                {
                    Storage storage = sDb.GetAlchoholStorage(CusID, ol.Drink.ID);
                    int newAmount = storage.Amount - ol.Amount;

                    sDb.UpdateAlchoholStorage(storage.ID, ol.Drink.ID, newAmount);
                }

                else if (ol.Drink.GetType() == typeof(HelFlask))
                {
                    Storage storage = sDb.GetHelflaskStorage(CusID, ol.Drink.ID);
                    int newAmount = storage.Amount - ol.Amount;

                    sDb.UpdateHelflaskStorage(storage.ID, ol.Drink.ID, newAmount);
                }
            }
        }

        public IEnumerable<Storage> GetAllStorages()
        {
            return sDb.GetAllStorages();
        }

        public int getCheckAmount(int id)
        {
            int amount = sDb.GetStorage(id).Amount;

            return amount;
        }

        public Storage getStorageByDrinkAndStorage(int drinkID, int cusID)
        {
            return sDb.getStorageByDrinkAndStorage(drinkID, cusID);
        }
    }
}
