using System;
using ModelLayer;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class CustomerDB
    {
        
            private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            public void CreateCustomer(Customer customer)
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "Insert Into dbo.Drink(CusName, CusImg, CusRegion, CusAddress, CusPhone, CusEmail) values(@CusName, @CusImg, @CusRegion, @CusAdress, @CusPhone, @CusEmail)";
                        //cmd.Parameters.AddWithValue("id", entity.Id);
                        cmd.Parameters.AddWithValue("CusName", customer.CusName);
                        cmd.Parameters.AddWithValue("CusImg", customer.Img);
                        cmd.Parameters.AddWithValue("CusRegion", customer.Region);
                        cmd.Parameters.AddWithValue("CusAddress", customer.Address);
                    cmd.Parameters.AddWithValue("CusPhone", customer.Phone);
                    cmd.Parameters.AddWithValue("CusEmail", customer.Email);
                    cmd.ExecuteNonQuery();
                    }
                }
            }

            public Customer GetCustomer(string CusName)
            {
                Customer customer = null;
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "Select * From Customer Where CusName = @CusName";
                        cmd.Parameters.AddWithValue("CusName", CusName);
                        var Reader = cmd.ExecuteReader();
                        while (Reader.Read())
                        {
                            customer = new Customer
                            {
                                //Id = (int)Reader["id"],
                                CusName = (string)Reader["CusName"],
                                Img = (string)Reader["CusImg"],
                                Region = (string)Reader["CusRegion"],
                                Address = (string)Reader["CusAddress"],
                                Phone = (string)Reader["CusPhones"],
                                Email = (string)Reader["CusEmail"]
                            };
                        }
                    }
                }
                return customer;
            }
        }
    }
}
