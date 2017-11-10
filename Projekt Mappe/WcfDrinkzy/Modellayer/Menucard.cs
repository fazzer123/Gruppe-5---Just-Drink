using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
    public class Menucard
    {
        public int ID { get; set; }
        public virtual List<Drink> Drinks { get; set; }
    }
}
