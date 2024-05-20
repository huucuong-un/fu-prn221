
/*
using DiamondPlaze.BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DiamondPlaze.BusinessObject.Models
{
    public partial class DatabaseDpContext : DbContext
    {
        public DatabaseDpContext()
        {
        }

        public DatabaseDpContext(DbContextOptions<DatabaseDpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(""); // You should provide your connection string here
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(2000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Username).HasMaxLength(2000);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("AccountRole");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(2000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(2000);

                entity.Property(e => e.Code).HasMaxLength(2000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Mail).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Phone).HasMaxLength(2000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Company_Account");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }

}*/