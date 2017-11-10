namespace DataaccessLayer
{
    using Modellayer;
    using System;
    using System.Data.Entity;
    using System.Linq;
    
    public class DbContext : System.Data.Entity.DbContext
    {

        public DbContext()
            : base("name=DbContext")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Menucard> Menucards { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Announcement> Annoucements { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }

}