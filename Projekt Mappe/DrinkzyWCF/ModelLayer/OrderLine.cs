using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
    public class OrderLine
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public double TotalPrice { get; set; }


        public OrderLine(int ID, int Amount, double TotalPrice)
        {
            this.ID = ID;
            this.Amount = Amount;
            this.TotalPrice = TotalPrice;
        }
        public OrderLine()
        {

        }
    }
}