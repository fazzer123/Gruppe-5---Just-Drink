using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using BusinessLayer;

namespace WCF
{
    class FavoritesService : IFavoritesService
    {
        FavoritesController fCtr = new FavoritesController();

        public void addDrink(int userId, int drinkId)
        {
            fCtr.addDrink(userId, drinkId);
        }

        public void createFavorites(Favorites fav)
        {
            fCtr.createFavorites(fav);
        }

        public List<Drink> GetAllDrinksByUser(int id)
        {
            return fCtr.GetAllDrinksByUser(id);
        }

        public Favorites GetFavoritesByUserID(int id)
        {
            return fCtr.GetFavoritesByUserID(id);
        }
    }
}
