using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data.SqlClient;

namespace DBLayer
{
    public class FavoritesDB
    {
        private DrinkDB ddb = new DrinkDB();
        private UserDB userDB = new UserDB();

        private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void CreateFavorites(Favorites favorites)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.Favorites(userID) values(@userID)";
                    //cmd.Parameters.AddWithValue("id", OrderLine.ID);
                    cmd.Parameters.AddWithValue("userID", favorites.User.ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AddDrink(User user, Drink drink)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.FavoritesDrinks(favoritesID, drinkID) values(@favoritesID, @drinkID)";
                    //cmd.Parameters.AddWithValue("id", OrderLine.ID);
                    cmd.Parameters.AddWithValue("favoritesID", user.ID);
                    cmd.Parameters.AddWithValue("drinkID", drink.ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Favorites GetFavoritesByUserID(int id)
        {
            Favorites favorites = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Favorites Where userID = @userID";
                    cmd.Parameters.AddWithValue("userID", id);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        favorites = new Favorites
                        {
                            ID = (int)Reader["id"],
                            User = userDB.GetUser((int)Reader["userID"]),
                            Drinks = GetAllDrinksByUser((int)Reader["id"])
                        };
                    }
                }
            }
            return favorites;
        }

        public List<Drink> GetAllDrinksByUser(int favoritesId)
        {
            List<Drink> DrinksList = new List<Drink>();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM FavoritesDrinks WHERE favoritesID = @favoritesID";
                    cmd.Parameters.AddWithValue("favoritesID", favoritesId);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Drink drink = ddb.GetDrink((int)Reader["drinkID"]);
                        DrinksList.Add(drink);
                    }
                }
            }
            return DrinksList;
        }
    }
}
