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

        public void CreateStorage(Storage Storage)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.Storage(id, stoAmount, stoMaxAmount, stoMinAmount) values(@id, @stoAmount, @stoMaxAmount, @stoMinAmount)";
                    cmd.Parameters.AddWithValue("id", Storage.ID);
                    cmd.Parameters.AddWithValue("stoAmount", Storage.Amount);
                    cmd.Parameters.AddWithValue("stoMaxAmount", Storage.MaxAmount);
                    cmd.Parameters.AddWithValue("stoMinAmount", Storage.MinAmount);
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
                            Amount = (int)Reader["stoAmount"],
                            MaxAmount = (int)Reader["stoMaxAmount"],
                            MinAmount = (int)Reader["stoMinAmount"]
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
                            Amount = (int)Reader["stoAmount"],
                            MaxAmount = (int)Reader["stoMaxAmount"],
                            MinAmount = (int)Reader["stoMinAmount"]

                        };
                        StorageList.Add(s);
                    }
                }

            }
            return StorageList;
        }
    }
}
