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
        public virtual Invoice Invoice { get; set; }
        public virtual User User { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
