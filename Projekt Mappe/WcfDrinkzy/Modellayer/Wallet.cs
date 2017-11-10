using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
   public class Wallet
    {
        public int ID { get; set; }
        public double Balance { get; set; }
        public double MaxBalance { get; set; }
        public double MinBalance { get; set; }
        public DateTime LockTime { get; set; }
    }
}
