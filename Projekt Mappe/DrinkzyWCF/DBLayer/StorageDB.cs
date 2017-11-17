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
    public class StorageDB
    {
        private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private DrinkDB drinkDB = new DrinkDB();
        private CustomerDB cusDB = new CustomerDB();

        public void CreateStorage(Storage Storage)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.Storage(id, Amount, MaxAmount, MinAmount, drinkID, customerID) values(@id, @stoAmount, @stoMaxAmount, @stoMinAmount, @drinkID, @customerID)";
                    cmd.Parameters.AddWithValue("id", Storage.ID);
                    cmd.Parameters.AddWithValue("Amount", Storage.Amount);
                    cmd.Parameters.AddWithValue("MaxAmount", Storage.MaxAmount);
                    cmd.Parameters.AddWithValue("MinAmount", Storage.MinAmount);
                    cmd.Parameters.AddWithValue("drinkID", Storage.Drink.ID);
                    cmd.Parameters.AddWithValue("customerID", Storage.Customer.ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Storage GetStorage(int ID)
        {
            Storage Storage = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Storage Where id = @id";
                    cmd.Parameters.AddWithValue("id", ID);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Storage = new Storage
                        {
                            ID = (int)Reader["id"],
                            Amount = (int)Reader["Amount"],
                            MaxAmount = (int)Reader["MaxAmount"],
                            MinAmount = (int)Reader["MinAmount"],
                            Drink = drinkDB.GetDrink((int)Reader["drinkID"]),
                            Customer = cusDB.GetCustomer((int)Reader["customerID"])
                        };
                    }
                }
            }
            return Storage;
        }
        public IEnumerable<Storage> GetAllStorages()
        {
            List<Storage> StorageList = new List<Storage>();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Storage";
                    var Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        Storage s = new Storage
                        {
                            ID = (int)Reader["id"],
                            Amount = (int)Reader["Amount"],
                            MaxAmount = (int)Reader["MaxAmount"],
                            MinAmount = (int)Reader["MinAmount"],
                            Drink = drinkDB.GetDrink((int)Reader["drinkID"]),
                            Customer = cusDB.GetCustomer((int)Reader["customerID"])
                        };
                        StorageList.Add(s);
                    }
                }

            }
            return StorageList;
        }
    }
}
