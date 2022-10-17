using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedView.Model;

namespace BackendAPI.Data
{
    public class ECommerceDBContext : IdentityDbContext
    {
        public ECommerceDBContext(DbContextOptions<ECommerceDBContext> options) : base(options) { }
        public DbSet<Customer> customers { get; set; }
        public DbSet<CustomerAccount> customerAccounts { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductSite> productSites { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Get connection to local server (Instead of getting connection at Program.cs)
            // But it still needs to be setted AddDbContext
            optionsBuilder.UseSqlServer("Server=.;Database=Ecommerce;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
