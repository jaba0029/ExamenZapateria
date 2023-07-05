using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapateria_Models
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("Shop")
        {
        }

        public virtual DbSet<Stores> stores { get; set; }
        public virtual DbSet<Articles> articles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Articles>()
                     .Property(x => x.Price)
                     .HasPrecision(18, 2);
        }
    }
}
