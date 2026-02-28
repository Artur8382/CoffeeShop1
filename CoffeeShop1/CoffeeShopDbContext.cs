using CoffeeShop;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop1
{
    public class CoffeeShopDbContext : DbContext
    {
        public CoffeeShopDbContext(DbContextOptions<CoffeeShopDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<LoyaltyPoints> LoyaltyPoints { get; set; }
        public DbSet<Barista> Baristas { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<OrderProductTopping> OrderProductToppings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Name).IsRequired().HasMaxLength(100);
                entity.Property(u => u.Type).IsRequired();
            });

            // LoyaltyPoints
            modelBuilder.Entity<LoyaltyPoints>(entity =>
            {
                entity.HasKey(lp => lp.Id);
                entity.HasOne(lp => lp.User)
                      .WithOne(u => u.LoyaltyPoints)
                      .HasForeignKey<LoyaltyPoints>(lp => lp.UserId);
            });

            // Barista
            modelBuilder.Entity<Barista>(entity =>
            {
                entity.HasKey(b => b.Id);
                entity.Property(b => b.Name).IsRequired().HasMaxLength(100);
            });

            // Product
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
            });

            // ProductSize
            modelBuilder.Entity<ProductSize>(entity =>
            {
                entity.HasKey(ps => ps.Id);
                entity.Property(ps => ps.Size).IsRequired().HasMaxLength(50);
                entity.Property(ps => ps.Price).HasColumnType("decimal(10,2)");
                entity.HasOne(ps => ps.Product)
                      .WithMany(p => p.Sizes)
                      .HasForeignKey(ps => ps.ProductId);
            });

            // Topping
            modelBuilder.Entity<Topping>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Name).IsRequired().HasMaxLength(100);
                entity.Property(t => t.Price).HasColumnType("decimal(10,2)");
            });

            // Order
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Timestamp).IsRequired();
                entity.Ignore(o => o.Price); // computed property, not stored
                entity.HasOne(o => o.User)
                      .WithMany(u => u.Orders)
                      .HasForeignKey(o => o.UserId);
                entity.HasOne(o => o.Barista)
                      .WithMany(b => b.Orders)
                      .HasForeignKey(o => o.BaristaId);
            });

            // OrderProduct
            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.HasKey(op => op.Id);
                entity.Property(op => op.Price).HasColumnType("decimal(10,2)");
                entity.Property(op => op.Quantity);
                entity.HasOne(op => op.Order)
                      .WithMany(o => o.OrderProducts)
                      .HasForeignKey(op => op.OrderId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(op => op.Product)
                      .WithMany()
                      .HasForeignKey(op => op.ProductId)
                      .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(op => op.ProductSize)
                      .WithMany()
                      .HasForeignKey(op => op.ProductSizeId)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            // OrderProductTopping
            modelBuilder.Entity<OrderProductTopping>(entity =>
            {
                entity.HasKey(opt => opt.Id);
                entity.Property(opt => opt.Price).HasColumnType("decimal(10,2)");
                entity.Property(op => op.Quantity);
                entity.HasOne(opt => opt.OrderProduct)
                      .WithMany(op => op.OrderProductToppings)
                      .HasForeignKey(opt => opt.OrderProductId);
                entity.HasOne(opt => opt.Topping)
                      .WithMany(t => t.OrderProductToppings)
                      .HasForeignKey(opt => opt.ToppingId);
            });
        }
    }
}
