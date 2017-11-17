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
    public class MenuCardDB
    {
        private DrinkDB ddb = new DrinkDB();
        private CustomerDB cusDB = new CustomerDB();

        private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void CreateMenuCard(MenuCard menu)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.MenuCard(customerID) values(@customerID)";
                    //cmd.Parameters.AddWithValue("id", OrderLine.ID);
                    cmd.Parameters.AddWithValue("customerID", menu.Customer.ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddDrink(Customer customer, Drink drink)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.MenucardDrinks(customerID, drinkID) values(@customerID, @drinkID)";
                    //cmd.Parameters.AddWithValue("id", OrderLine.ID);
                    cmd.Parameters.AddWithValue("customerID", customer.ID);
                    cmd.Parameters.AddWithValue("drinkID", drink.ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public MenuCard GetMenuCardByCustomerID(int id)
        {
            MenuCard menuCard = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From MenuCard Where customerID = @customerID";
                    cmd.Parameters.AddWithValue("customerID", id);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        menuCard = new MenuCard
                        {
                            ID = (int)Reader["id"],
                            Customer = cusDB.GetCustomer((int)Reader["customerID"]),
                            Drinks = GetAllDrinksByCustomer((int)Reader["customerID"])
                        };
                    }
                }
            }
            return menuCard;
        }

        public List<Drink> GetAllDrinksByCustomer(int cusId)
        {
            List<Drink> DrinksList = new List<Drink>();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM MenucardDrinks WHERE customerID = @customerID";
                    cmd.Parameters.AddWithValue("customerID", cusId);
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
