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
        private AlchoholDB alchoholDB = new AlchoholDB();
        private HelFlaskDB hfDB = new HelFlaskDB();
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
                    cmd.CommandText = "Select * From Storage Where cusID = @cusID";
                    cmd.Parameters.AddWithValue("cusID", ID);
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

        public int getStorageIDByCustomerID(int cusID)
        {
            int i = 0;

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Storage Where customerID = @customerID";
                    cmd.Parameters.AddWithValue("customerID", cusID);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        i = (int)Reader["id"];
                    }
                }
            }

            return i;
        }

        public Storage getDrinkStorageByDrinkAndStorage(int drinkID, int cusID)
        {
            Storage Storage = null;
            int storageID = getStorageIDByCustomerID(cusID);

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Storage, drinkStorage Where drinkID = @drinkID AND storageID = @storageID AND customerID = @customerID";
                    cmd.Parameters.AddWithValue("drinkID", drinkID);
                    cmd.Parameters.AddWithValue("storageID", storageID);
                    cmd.Parameters.AddWithValue("customerID", cusID);
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

        public Storage getAlchoholStorageByDrinkAndStorage(int alchID, int cusID)
        {
            Storage Storage = null;
            int storageID = getStorageIDByCustomerID(cusID);

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Storage, alchoholStorage Where alchoholID = @alchoholID AND storageID = @storageID AND customerID = @customerID";
                    cmd.Parameters.AddWithValue("alchoholID", alchID);
                    cmd.Parameters.AddWithValue("storageID", storageID);
                    cmd.Parameters.AddWithValue("customerID", cusID);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Storage = new Storage
                        {
                            ID = (int)Reader["id"],
                            Amount = (int)Reader["Amount"],
                            MaxAmount = (int)Reader["MaxAmount"],
                            MinAmount = (int)Reader["MinAmount"],
                            Drink = drinkDB.GetDrink((int)Reader["alchoholID"])
                        };
                    }
                }
            }
            return Storage;
        }

        public Storage getHelflaskStorageByHelflaskAndStorage(int flaskID, int cusID)
        {
            Storage Storage = null;
            int storageID = getStorageIDByCustomerID(cusID);

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Storage, helflaskStorage Where helflaskID = @helflaskID AND storageID = @storageID AND customerID = @customerID";
                    cmd.Parameters.AddWithValue("helflaskID", flaskID);
                    cmd.Parameters.AddWithValue("storageID", storageID);
                    cmd.Parameters.AddWithValue("customerID", cusID);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Storage = new Storage
                        {
                            ID = (int)Reader["id"],
                            Amount = (int)Reader["Amount"],
                            MaxAmount = (int)Reader["MaxAmount"],
                            MinAmount = (int)Reader["MinAmount"],
                            Drink = drinkDB.GetDrink((int)Reader["helflaskID"])
                        };
                    }
                }
            }
            return Storage;
        }

        public Storage GetDrinkStorage(int CusID, int DrinkID)
        {
            Storage Storage = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Storage, drinkStorage Where customerID = @customerID and drinkID = @drinkID";
                    cmd.Parameters.AddWithValue("customerID", CusID);
                    cmd.Parameters.AddWithValue("drinkID", DrinkID);
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

        public Storage GetAlchoholStorage(int CusID, int DrinkID)
        {
            Storage Storage = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Storage, alchoholStorage Where customerID = @customerID and alchoholID = @alchoholID";
                    cmd.Parameters.AddWithValue("customerID", CusID);
                    cmd.Parameters.AddWithValue("alchoholID", DrinkID);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Storage = new Storage
                        {
                            ID = (int)Reader["id"],
                            Amount = (int)Reader["Amount"],
                            MaxAmount = (int)Reader["MaxAmount"],
                            MinAmount = (int)Reader["MinAmount"],
                            Drink = alchoholDB.GetAlchohol((int)Reader["alchoholID"]),
                            Customer = cusDB.GetCustomer((int)Reader["customerID"])
                        };
                    }
                }
            }
            return Storage;
        }

        public Storage GetHelflaskStorage(int CusID, int DrinkID)
        {
            Storage Storage = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Storage, helflaskStorage Where customerID = @customerID and helflaskID = @helflaskID";
                    cmd.Parameters.AddWithValue("customerID", CusID);
                    cmd.Parameters.AddWithValue("helflaskID", DrinkID);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Storage = new Storage
                        {
                            ID = (int)Reader["id"],
                            Amount = (int)Reader["Amount"],
                            MaxAmount = (int)Reader["MaxAmount"],
                            MinAmount = (int)Reader["MinAmount"],
                            Drink = hfDB.GetHelFlask((int)Reader["helflaskID"]),
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

        public void UpdateDrinkStorage(Storage storage)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Update drinkStorage SET Amount = @Amount, MaxAmount = @MaxAmount, MinAmount = @MinAmount  WHERE storageID = @storageID AND drinkID = @drinkID";
                    cmd.Parameters.AddWithValue("Amount", storage.Amount);
                    cmd.Parameters.AddWithValue("MaxAmount", storage.MaxAmount);
                    cmd.Parameters.AddWithValue("MinAmount", storage.MinAmount);
                    cmd.Parameters.AddWithValue("drinkID", storage.Drink.ID);
                    cmd.Parameters.AddWithValue("storageID", storage.ID);                  
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateAlchoholStorage(Storage storage)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Update alchoholStorage SET Amount = @Amount  WHERE storageID = @storageID AND alchoholID = @alchoholID";
                    cmd.Parameters.AddWithValue("storageID", storage.ID);
                    cmd.Parameters.AddWithValue("alchoholID", storage.Drink.ID);
                    cmd.Parameters.AddWithValue("Amount", storage.Amount);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateHelflaskStorage(Storage storage)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Update helflaskStorage SET Amount = @Amount  WHERE storageID = @storageID AND helflaskID = @helflaskID";
                    cmd.Parameters.AddWithValue("storageID", storage.ID);
                    cmd.Parameters.AddWithValue("helflaskID", storage.Drink.ID);
                    cmd.Parameters.AddWithValue("Amount", storage.Amount);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
