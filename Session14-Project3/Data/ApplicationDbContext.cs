using Microsoft.EntityFrameworkCore;
using Session14_Project3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session14_Project3.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ziyad-amara\\DEPI2SQLSERVER; Database = Task_C#_Session14_HealthCareSystem; Trusted_Connection = true; TrustServerCertificate = true; ");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .HasKey(a => new { a.PatientId, a.DoctorId });
        }

        public DbSet<Patient> Patients { get; set; } = null!;
        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<Appointment> Appointments { get; set; } = null!;
    }
}
