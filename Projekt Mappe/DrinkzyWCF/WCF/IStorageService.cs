﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.ServiceModel;
namespace WCF
{
    [ServiceContract]
    public interface IStorageService
    {
        [OperationContract]
        void CreateStorage(Storage storage);
        [OperationContract]
        Storage GetStorage(int id);

        [OperationContract]
        Storage GetDrinkStorage(int cusID, int drinkID);

        [OperationContract]
        void UpdateStorageDrink(int CusID, int orderID);

        [OperationContract]
        IEnumerable<Storage> GetAllStorages();

        [OperationContract]
        Storage getStorageByDrinkAndStorage(int drinkID, int cusID);

        [OperationContract]
        Storage getAlchoholStorageByDrinkAndStorage(int alchID, int cusID);

        [OperationContract]
        Storage getHelflaskStorageByHelflaskAndStorage(int flaskID, int cusID);
    }
}
