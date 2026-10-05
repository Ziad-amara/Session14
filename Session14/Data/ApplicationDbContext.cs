using Microsoft.EntityFrameworkCore;
using Session14.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session14.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server = ziyad-amara\\DEPI2SQLSERVER; Database = Task_C#_Session14_E_Commerce; Trusted_Connection = true; TrustServerCertificate = true; ");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderId, od.ProductId });
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
