using Lab_1_fedorus_db.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Lab_1_fedorus_db.Contexts
{
    public class BookStoreDbContext : DbContext
    {

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
        {


        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplyRecord> SupplyRecords { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Payment> Payments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Book-Category many-to-many configuration
            modelBuilder.Entity<BookCategory>()
            .HasKey(bc => new { bc.BookId, bc.CategoryId });

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);

            // Author-Address one-to-one configuration
            modelBuilder.Entity<Author>()
            .HasOne(a => a.Address)
            .WithOne()
            .HasForeignKey<Address>(a => a.AuthorId)
            .OnDelete(DeleteBehavior.Restrict);

            // Customer-Address one-to-one configuration (assuming each customer has one shipping address)
            modelBuilder.Entity<Customer>()
            .HasOne(c => c.ShippingAddress)
            .WithOne()
            .HasForeignKey<Address>(a => a.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);  // Prevent cascade delete for shared address entity

            // Supplier-Address one-to-one configuration (assuming each supplier has one location)
            modelBuilder.Entity<Supplier>()
            .HasOne(s => s.Location)
            .WithOne()
            .HasForeignKey<Address>(a => a.SupplierId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete for shared address entity

            // More configurations can be added for other relationships and constraints
        }
       
        
    }
}
