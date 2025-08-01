
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
    }

    
}