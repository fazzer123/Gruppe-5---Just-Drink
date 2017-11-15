using System;
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
        Storage GetStorage(int ID);

        [OperationContract]
        IEnumerable<Storage> GetAllStorages();

    }
}
