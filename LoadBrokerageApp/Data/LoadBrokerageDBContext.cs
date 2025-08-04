
using LoadBrokerageApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LoadBrokerageApp.Data 
{
    public class LoadBrokerageDBContext : DbContext
    {
        public LoadBrokerageDBContext(DbContextOptions<LoadBrokerageDBContext> options) : base(options)
        {
        }

        public DbSet<Shippers> Shippers { get; set; }
        public DbSet<Loads> Loads { get; set; }
        public DbSet<Carriers> Carriers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Shippers>()
                .Property(s => s.ShippersId)
                .HasDefaultValueSql("uuid_generate_v4()");

            modelBuilder.Entity<Carriers>()
                .Property(c => c.CarriersId)
                .HasDefaultValueSql("uuid_generate_v4()");

            modelBuilder.Entity<Loads>()
                .Property(l => l.LoadsId)
                .HasDefaultValueSql("uuid_generate_v4()");
        }
    }

    
}