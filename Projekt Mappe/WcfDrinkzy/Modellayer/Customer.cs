using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual Menucard Menucard { get; set; }
        public virtual Announcement Announcement { get; set; }
    }
}
