﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace WCF
{
    [ServiceContract]
    interface IFavoritesService
    {
        [OperationContract]
        void createFavorites(Favorites fav);

        [OperationContract]
        Favorites GetFavoritesByUserID(int id);

        [OperationContract]
        List<Drink> GetAllDrinksByUser(int id);

        [OperationContract]
        void addDrink(User user, Drink drink);
    }
}