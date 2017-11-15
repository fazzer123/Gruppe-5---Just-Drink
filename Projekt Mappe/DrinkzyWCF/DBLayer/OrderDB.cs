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
    public class OrderDB
    {
        private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void CreateOrder(Order Order)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.Order(id, totalprice, discount, orderDate, status) values(@id, @totalprice, @discount, @orderDate,status)";
                    cmd.Parameters.AddWithValue("id", Order.ID);
                    cmd.Parameters.AddWithValue("totalprice", Order.TotalPrice);
                    cmd.Parameters.AddWithValue("discount", Order.Discount);
                    cmd.Parameters.AddWithValue("orderDate", Order.Date);
                    cmd.Parameters.AddWithValue("status", Order.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Order GetOrder(int ID)
        {
            Order Order = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Select * From Order Where id = @id";
                    cmd.Parameters.AddWithValue("id", ID);
                    var Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Order = new Order
                        {

                            ID = (int)Reader["id"],
                            TotalPrice = (int)Reader["totalprice"],
                            Discount = (int)Reader["discount"],
                            Date = (DateTime)Reader["orderDate"],
                            Status = (string)Reader["status"]
                        };
                    }
                }
            }
            return Order;
        }
        public IEnumerable<Order> GetAllOrders()
        {
            List<Order> OrderList = new List<Order>();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Order";
                    var Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        Order o = new Order
                        {
                            ID = (int)Reader["id"],
                            TotalPrice = (int)Reader["totalprice"],
                            Discount = (int)Reader["discount"],
                            Date = (DateTime)Reader["orderDate"],
                            Status = (string)Reader["status"]

                        };
                        OrderList.Add(o);
                    }
                }

            }
            return OrderList;
        }
    }
}
