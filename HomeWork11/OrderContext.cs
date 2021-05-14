using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;
using Order;

namespace HomeWork11
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
              new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order.Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order.Order>().Property(o => o.OrderID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<OrderDetails>().Property(o => o.OrderDetailID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
