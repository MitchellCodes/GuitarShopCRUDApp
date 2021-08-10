using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GuitarShopCRUDApp
{
    public partial class GuitarShopContext : DbContext
    {
        public GuitarShopContext()
            : base("name=GuitarShopContext")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.Line1)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Line2)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.ItemPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderItem>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.ShipAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CardNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CardExpires)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(19, 4);
        }
    }
}
