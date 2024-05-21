/*
using Microsoft.EntityFrameworkCore;

namespace DiamondPlaza.BusinessObject.Models
{
    public class DiamondPlazeContext : DbContext
    {
        public DiamondPlazeContext(DbContextOptions<DiamondPlazeContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Wages> Wages { get; set; }
        public DbSet<Warranty> Warranties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuring Customer-Account relationship
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Account)
                .WithMany()
                .HasForeignKey(c => c.AccountId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuring Order-OrderItem relationship
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItem)
                .WithOne()
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring OrderItem-Warranty relationship
            modelBuilder.Entity<OrderItem>()
                .HasMany(oi => oi.Warranthy)
                .WithOne()
                .HasForeignKey(w => w.OrderItemId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring ProductType-Wages relationship
            modelBuilder.Entity<ProductType>()
                .HasMany(pt => pt.Wage)
                .WithOne()
                .HasForeignKey(w => w.ProductTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring ProductMaterial composite key and relationships
            modelBuilder.Entity<ProductMaterial>()
                .HasKey(pm => new { pm.ProductId, pm.MaterialId });

            modelBuilder.Entity<ProductMaterial>()
                .HasOne(pm => pm.Product)
                .WithMany(p => p.ProductMaterials)
                .HasForeignKey(pm => pm.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductMaterial>()
                .HasOne(pm => pm.Material)
                .WithMany(m => m.ProductMaterials)
                .HasForeignKey(pm => pm.MaterialId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring Product-ProductType relationship
            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductType)
                .WithMany(pt => pt.Products)
                .HasForeignKey(p => p.ProductTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuring unique constraints and indexes
            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Id)
                .IsUnique()
                .HasDatabaseName("IX_Customer_Email");

            modelBuilder.Entity<Account>()
                .HasIndex(a => a.Username)
                .IsUnique()
                .HasDatabaseName("IX_Account_Username");

            modelBuilder.Entity<Product>()
                .HasIndex(p => new { p.Name, p.ProductTypeId })
                .IsUnique()
                .HasDatabaseName("IX_Product_Name_ProductTypeId");

            // Additional configurations if needed
        }
    }
}
*/
