using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
    public class Storage
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public int MinAmount { get; set; }
        public virtual Drink Drink { get; set; }
    }
}
