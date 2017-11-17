﻿using System;
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
                        cmd.CommandText = "Insert Into dbo.DrinkzyCustomer(CusName, CusImg, CusRegion, CusAddress, CusPhone, CusEmail) values(@CusName, @CusImg, @CusRegion, @CusAdress, @CusPhone, @CusEmail)";
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

        public Customer GetCustomer(int id)
        {
            Customer customer = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From DrinkzyCustomer Where id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        customer = new Customer
                        {
                            ID = (int)Reader["id"],
                            CusName = (string)Reader["CusName"],
                            Img = (string)Reader["CusImg"],
                            Region = (string)Reader["CusRegion"],
                            Address = (string)Reader["CusAddress"],
                            Phone = (string)Reader["CusPhone"],
                            Email = (string)Reader["CusEmail"]
                        };
                    }
                }
            }
            return customer;
        }

    public IEnumerable<Customer> GetAllCustomers()
            {
                List<Customer> CustomerList = new List<Customer>();
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM DrinkzyCustomer";
                        var Reader = cmd.ExecuteReader();

                        while (Reader.Read())
                        {
                            Customer c = new Customer
                            {
                                CusName = (string)Reader["CusName"],
                                Img = (string)Reader["CusImg"],
                                Region = (string)Reader["CusRegion"],
                                Address = (string)Reader["CusAddress"],
                                Phone = (string)Reader["CusPhone"],
                                Email = (string)Reader["CusEmail"]

                            };
                            CustomerList.Add(c);
                        }
                    }

                }
                return CustomerList;
            }
        }
    }

