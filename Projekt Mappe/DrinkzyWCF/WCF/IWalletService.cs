using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    [ServiceContract]
    public interface IWalletService
    {
        [OperationContract]
        void CreateWallet(Wallet wallet);

        [OperationContract]
        Wallet GetWallet(int id);

        [OperationContract]
        IEnumerable<Wallet> GetAllWallet();
    }
}
