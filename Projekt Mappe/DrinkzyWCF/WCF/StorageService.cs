using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using BusinessLayer;

namespace WCF
{
    public class StorageService : IStorageService
    {
        StorageController sCtr;

        public StorageService()
        {
            sCtr = new StorageController();
        }

        public void CreateStorage(Storage storage)
        {
            sCtr.CreateStorage(storage);
        }

        public IEnumerable<Storage> GetAllStorages()
        {
           return sCtr.GetAllStorages();
        }

        public Storage GetDrinkStorage(int cusID, int drinkID)
        {
            return sCtr.GetDrinkStorage(cusID, drinkID);
        }

        public Storage GetStorage(int id)
        {
            return sCtr.GetStorage(id);
        }

        public Storage getStorageByDrinkAndStorage(int drinkID, int cusID)
        {
            return sCtr.getStorageByDrinkAndStorage(drinkID, cusID);
        }

        public void UpdateStorageDrink(int CusID, int orderID)
        {
            sCtr.UpdateDrinkAmount(CusID, orderID);
        }
    }
}
