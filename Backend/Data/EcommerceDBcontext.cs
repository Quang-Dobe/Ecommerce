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
        public DbSet<ProductInfo> productInfos { get; set; }
        public DbSet<ProductSite> productSites { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Ecommerce;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasKey(c => new { c.customerId, c.productId });
            modelBuilder.Entity<IdentityUserLogin<string>>(builder =>
            {
                builder.HasNoKey();
            });


            modelBuilder.Entity<OrderDetail>()
                .HasKey(c => new { c.customerId, c.productId });
            modelBuilder.Entity<IdentityUserRole<string>>(builder =>
            {
                builder.HasNoKey();
            });

            modelBuilder.Entity<OrderDetail>()
                .HasKey(c => new { c.customerId, c.productId });
            modelBuilder.Entity<IdentityUserToken<string>>(builder =>
            {
                builder.HasNoKey();
            });
        }
    }
}
