using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
   public class Order
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public double TotalPrice { get; set; }
        [DataMember]
        public double Discount { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Status { get; set; }


        public Order(int ID, double TotalPrice, double Discount, DateTime Date, String Status)
        {
            this.ID = ID;
            this.TotalPrice = TotalPrice;
            this.Discount = Discount;
            this.Date = Date;
            this.Status = Status;
        }
        public Order()
        {

        }
    }
}
