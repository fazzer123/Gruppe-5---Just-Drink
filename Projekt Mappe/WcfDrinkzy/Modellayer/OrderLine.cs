using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
    public class OrderLine
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
        public virtual Drink Drink { get; set; }
        public virtual Order Order { get; set; }
    }
}
