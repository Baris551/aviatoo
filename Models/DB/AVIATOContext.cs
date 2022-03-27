using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
#nullable disable
namespace aviato.Models.DB
{
    public partial class AVIATOContext : DbContext
    {
        public AVIATOContext()
        {
        }

        public AVIATOContext(DbContextOptions<AVIATOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<Trend> Trends { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-15PO7V46\\SQLEXPRESS;Database=AVIATO;User Id=sa;Password=password");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Aktif).HasColumnName("aktif");

                entity.Property(e => e.Price)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProductName).HasMaxLength(50);
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("Register");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.KullanıcıAd)
                    .HasMaxLength(50)
                    .HasColumnName("Kullanıcı Ad");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<Trend>(entity =>
            {
                entity.ToTable("Trend");

                entity.Property(e => e.Price)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
