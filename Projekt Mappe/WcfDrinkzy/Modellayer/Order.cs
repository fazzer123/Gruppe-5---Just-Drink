using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
    public class Order
    {
        public int ID { get; set; }
        public double TotalPrice { get; set; }
        public double Discount { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public virtual OrderLine OrderLine { get; set; }
        public virtual Drink Drink { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
