using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
    public class Invoice
    {
        public int ID { get; set; }
        public virtual Order Order { get; set; }
    }
}
