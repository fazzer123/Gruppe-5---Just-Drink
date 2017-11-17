using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;

namespace BusinessLayer
{
    public class FavoritesController
    {
        private FavoritesDB db = new FavoritesDB();

        public void createFavorites(Favorites fav)
        {
            db.CreateFavorites(fav);
        }

        public Favorites GetFavoritesByUserID(int id)
        {
            return db.GetFavoritesByUserID(id);
        }

        public List<Drink> GetAllDrinksByUser(int id)
        {
            return db.GetAllDrinksByUser(id);
        }

        public void addDrink(User user, Drink drink)
        {
            db.AddDrink(user, drink);
        }
    }
}
