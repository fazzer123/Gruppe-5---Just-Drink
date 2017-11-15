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

        public Storage GetStorage(int ID)
        {
            return sCtr.GetStorage(ID);
        }
    }
}
