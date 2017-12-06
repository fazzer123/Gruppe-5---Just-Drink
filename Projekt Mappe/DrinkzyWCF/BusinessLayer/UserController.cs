﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;

namespace BusinessLayer
{
    public class UserController
    {
        UserDB uDb;

        public UserController()
        {
            uDb = new UserDB();
        }

        public void CreateUser(User user)
        {
            uDb.CreateUser(user);
        }

        public User GetUser(int id)
        {
            return uDb.GetUser(id);
        }
        public IEnumerable<User> getAllUsers()
        {
            return uDb.getAllUsers();
        }
        public void UpdateUser(User user)
        {
            uDb.UpdateUser(user);
        }
        public void DeleteUser(int UserID)
        {
            uDb.DeleteUser(UserID);
        }

        public void createFavoritesAndWallet(int userid)
        {
            User u = GetUser(userid);
            FavoritesController fCtr = new FavoritesController();
            WalletController wCtr = new WalletController();

            if (fCtr.GetFavoritesByUserID(u.ID) == null)
            {
                Favorites f = new Favorites
                {
                    User = u
                };
                fCtr.createFavorites(f);
            }
            if (wCtr.GetWallet(u.ID) == null)
            {
                Wallet w = new Wallet
                {
                    Balance = 0,
                    MinBalance = 0,
                    MaxBalance = 0,
                    LockTime = DateTime.Now,
                    User = u,
                };
                wCtr.CreateWallet(w);
            }
        }

        public User GetUserByUserName(string username, string password)
        {
            IEnumerable<User> users = new List<User>();
            users = uDb.getAllUsers();
            Boolean found = false;
            User user = null;

            while (!found)
            {
                for(int i = 0 ; i < users.Count(); i++)
                {
                    if(users.ElementAt(i).UserName == username && users.ElementAt(i).Password == password)
                    {
                        user = users.ElementAt(i);
                        found = true;
                    }
                }
                found = true;
            }
            return user;
        }

        public bool Login(string username, string password)
        {
            return uDb.Login(username, password);
        }
    }
}
    

