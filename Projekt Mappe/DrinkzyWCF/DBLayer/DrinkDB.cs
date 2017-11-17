using ModelLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class DrinkDB
    {
        private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void CreateDrink(Drink drink)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.Drink(driName, driDescription, driPrice, driImg) values(@driName, @driDescription, @driPrice, @driImg)";
                    //cmd.Parameters.AddWithValue("id", entity.Id);
                    cmd.Parameters.AddWithValue("driName", drink.Name);
                    cmd.Parameters.AddWithValue("driDescription", drink.Description);
                    cmd.Parameters.AddWithValue("driPrice", drink.Price);
                    cmd.Parameters.AddWithValue("driImg", drink.Img);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Drink GetDrink(int id)
        {
            Drink drink = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Drink Where id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        drink = new Drink
                        {
                            ID = (int)Reader["id"],
                            Name = (string)Reader["driName"],
                            Description = (string)Reader["driDescription"],
                            Price = (decimal)Reader["driPrice"],
                            Img = (string)Reader["driImg"]
                        };
                    }
                }
            }
            return drink;
        }
        public IEnumerable<Drink> getAllDrinks()
        {
            List<Drink> drinkList = new List<Drink>();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Drink";
                    var Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        Drink d = new Drink
                        {
                            ID = (int)Reader["id"],
                            Name = (string)Reader["driName"],
                            Description = (string)Reader["driDescription"],
                            Price = (decimal)Reader["driPrice"],
                            Img = (string)Reader["driImg"]

                        };
                        drinkList.Add(d);
                    }
                }

            }
            return drinkList;
        }
    }
}
