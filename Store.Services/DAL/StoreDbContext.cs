using Store.Models;
using System.Data.Entity;

namespace Store.Services.DAL
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext() : base("StoreConnection")
        {
            Database.SetInitializer(new StoreDbInitializer());
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}