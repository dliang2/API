using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using StoreFront.Models;

namespace StoreFront.Models
{
    public class StoreFrontDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public StoreFrontDBContext(DbContextOptions<StoreFrontDBContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("StoreFront");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ShoppingCart> ShoppingCart { get; set; } = null!;
    }
}
