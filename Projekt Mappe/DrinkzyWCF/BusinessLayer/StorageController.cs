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

        public StorageController()
        {
            sDb = new StorageDB();
        }

        public void CreateStorage(Storage Storage)
        {
            sDb.CreateStorage(Storage);
        }

        public Storage GetStorage(int ID)
        {
            return sDb.GetStorage(ID);
        }
        public IEnumerable<Storage> GetAllStorages()
        {
            return sDb.GetAllStorages();
        }
    }
}
