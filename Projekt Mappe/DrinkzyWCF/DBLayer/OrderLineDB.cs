﻿using ModelLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class OrderLineDB
    {
        DrinkDB ddb = new DrinkDB();
        private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void CreateOrderLine(OrderLine OrderLine, int orderID)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.OrderLine(amount, totalPrice, drinkID, orderID) values(@amount, @totalPrice, @drinkID, @orderID)";
                    //cmd.Parameters.AddWithValue("id", OrderLine.ID);
                    cmd.Parameters.AddWithValue("amount", OrderLine.Amount);
                    cmd.Parameters.AddWithValue("totalPrice", OrderLine.TotalPrice);
                    cmd.Parameters.AddWithValue("drinkID", OrderLine.Drink.ID);
                    cmd.Parameters.AddWithValue("orderID", orderID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public OrderLine GetOrderLine(int ID)
        {
            OrderLine OrderLine = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From OrderLine Where id = @id";
                    cmd.Parameters.AddWithValue("id", ID);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        OrderLine = new OrderLine
                        {

                            ID = (int)Reader["id"],
                            Amount = (int)Reader["amount"],
                            TotalPrice = (decimal)Reader["totalPrice"],
                            Drink = ddb.GetDrink((int)Reader["drinkID"])
                        };
                    }
                }
            }
            return OrderLine;
        }
        public IEnumerable<OrderLine> GetAllOrderLines()
        {
            List<OrderLine> OrderLineList = new List<OrderLine>();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM OrderLine";
                    var Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        OrderLine ol = new OrderLine
                        {
                            ID = (int)Reader["id"],
                            Amount = (int)Reader["amount"],
                            TotalPrice = (decimal)Reader["TotalPrice"],
                            Drink = ddb.GetDrink((int)Reader["drinkID"])

                        };
                        OrderLineList.Add(ol);
                    }
                }
            }
            return OrderLineList;
        }

        public IEnumerable<OrderLine> GetAllOrderLinesByOrderID(int orderID)
        {
            List<OrderLine> OrderLineList = new List<OrderLine>();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM OrderLine WHERE orderID = @orderID";
                    cmd.Parameters.AddWithValue("orderID", orderID);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        OrderLine ol = new OrderLine
                        {
                            ID = (int)Reader["id"],
                            Amount = (int)Reader["amount"],
                            TotalPrice = (decimal)Reader["TotalPrice"],
                            Drink = ddb.GetDrink((int)Reader["drinkID"])
                        };
                        OrderLineList.Add(ol);
                    }
                }
            }
            return OrderLineList;
        }
    }
}
