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
    public class OrderLineDB
    {
        private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void CreateOrderLine(OrderLine OrderLine)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into dbo.OrderLine(id, amount, totalPrice) values(@id, @amount, @totalPrice)";
                    cmd.Parameters.AddWithValue("id", OrderLine.ID);
                    cmd.Parameters.AddWithValue("amount", OrderLine.Amount);
                    cmd.Parameters.AddWithValue("totalPrice", OrderLine.TotalPrice);
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
                            TotalPrice = (Double)Reader["totalPrice"],
                            
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
                            TotalPrice = (Double)Reader["TotalPrice"],

                        };
                        OrderLineList.Add(ol);
                    }
                }

            }
            return OrderLineList;
        }
    }
}
