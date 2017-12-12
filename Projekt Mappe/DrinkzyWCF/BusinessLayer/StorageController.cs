using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;
using System.Reflection;

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

        public void UpdateDrinkAmount(int orderID)
        {
            Order order = oCtr.GetOrder(orderID);
            foreach (var ol in order.OrderLines)
            {
                if (ol.Drink.GetType() == typeof(Drink))
                {
                    Storage storage = sDb.getDrinkStorageByDrinkAndStorage(ol.Drink.ID, order.Customer.ID);
                    storage.Amount = storage.Amount - ol.Amount;

                    sDb.UpdateDrinkStorage(storage);
                }

                else if (ol.Drink.GetType() == typeof(Alchohol))
                {
                    Storage storage = sDb.getAlchoholStorageByDrinkAndStorage(ol.Drink.ID, order.Customer.ID);
                    storage.Amount = storage.Amount - ol.Amount;

                    sDb.UpdateAlchoholStorage(storage);
                }

                else if (ol.Drink.GetType() == typeof(HelFlask))
                {
                    Storage storage = sDb.getHelflaskStorageByHelflaskAndStorage(ol.Drink.ID, order.Customer.ID);
                    storage.Amount = storage.Amount - ol.Amount;

                    sDb.UpdateHelflaskStorage(storage);
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
            return sDb.getDrinkStorageByDrinkAndStorage(drinkID, cusID);
        }

        public Storage getAlchoholStorageByDrinkAndStorage(int alchID, int cusID)
        {
            return sDb.getAlchoholStorageByDrinkAndStorage(alchID, cusID);
        }

        public Storage getHelflaskStorageByHelflaskAndStorage(int flaskID, int cusID)
        {
            return sDb.getHelflaskStorageByHelflaskAndStorage(flaskID, cusID);
        }
    }
}
