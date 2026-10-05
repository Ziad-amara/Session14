using Microsoft.EntityFrameworkCore;
using Session14_Project2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session14_Project2.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ziyad-amara\\DEPI2SQLSERVER; Database = Task_C#_Session14_Library; Trusted_Connection = true; TrustServerCertificate = true; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>()
                .HasKey(p => new {p.BookId , p.BorrowerId});
        }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Borrower> Borrowers { get; set; } = null!;
        public DbSet<Loan> Loans { get; set; } = null!;
    }
}
