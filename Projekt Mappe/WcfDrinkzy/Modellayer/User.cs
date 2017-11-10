using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual Wallet Wallet { get; set; }
        public virtual Favourite Favourite { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Invoice> Invoices { get; set; }
    }
}
