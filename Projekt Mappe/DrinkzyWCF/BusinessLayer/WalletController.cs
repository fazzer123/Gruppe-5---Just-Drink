using DBLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class WalletController
    {
        WalletDB wDb;

        public WalletController()
        {
            wDb = new WalletDB();
        }

        public void CreateWallet(Wallet wallet)
        {
            wDb.CreateWallet(wallet);
        }

        public Wallet GetWallet(int id)
        {
            return wDb.GetWallet(id);
        }
        public IEnumerable<Wallet> GetAllWallets()
        {
            return wDb.GetAllWallets();
        }

        public void UpdateBalanceByUserID(decimal Balance, int userID)
        {
            wDb.updateBalanceByUserID(Balance, userID);
        }
    }
}
