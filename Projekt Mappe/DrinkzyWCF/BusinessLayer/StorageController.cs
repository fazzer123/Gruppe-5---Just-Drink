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

        /*Denne metode bruges til at ændre amount på storage, den tager order id ind som parameter*/
        public void UpdateDrinkAmount(int orderID)
        {
            /*Her hentes den givne order, som har det id metoden fik med parameteren*/
            Order order = oCtr.GetOrder(orderID);
            foreach (var ol in order.OrderLines)
            {
                /*Her tjekkes hvilken type drink der er på orderlinen, så den trækker det fra i den rigtig database*/
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

        public void UpdateStorages(Storage storage)
        {
            if (storage.Drink.GetType() == typeof(Drink))
            {
                sDb.UpdateDrinkStorage(storage);
            }

            else if (storage.Drink.GetType() == typeof(Alchohol))
            {
               sDb.UpdateAlchoholStorage(storage);
            }

            else if (storage.Drink.GetType() == typeof(HelFlask))
            {
                sDb.UpdateHelflaskStorage(storage);
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

        public IEnumerable<Storage> GetAllDrinkStorage(int cusID)
        {
            return sDb.GetAllDrinkStorages(cusID);
        }

        public IEnumerable<Storage> GetAllAlchoholStorage(int cusID)
        {
            return sDb.GetAllAlchoholStorages(cusID);
        }

        public IEnumerable<Storage> GetAllHelflaskStorage(int cusID)
        {
            return sDb.GetAllHelflaskStorages(cusID);
        }
    }
}
