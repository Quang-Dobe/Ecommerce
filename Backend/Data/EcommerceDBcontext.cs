using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedView.Model;


namespace Backend.Data
{
    public class EcommerceDBcontext : IdentityDbContext
    {
        public EcommerceDBcontext(DbContextOptions<EcommerceDBcontext> options) : base(options) { }
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<OrderDetail>()
            //    .HasKey(c => new { c.accountId, c.productId, c.orderId });

            // Just avoid bug :D
            // Bug when using default Identity
            modelBuilder.Entity<IdentityUserLogin<string>>(builder =>
            {
                builder.HasNoKey();
            });
            
            modelBuilder.Entity<IdentityUserRole<string>>(builder =>
            {
                builder.HasNoKey();
            });
            
            modelBuilder.Entity<IdentityUserToken<string>>(builder =>
            {
                builder.HasNoKey();
            });
        }
    }
}
