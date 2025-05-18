using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data
{
    public class DataContext : DbContext,IDataContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Report> WorkDay { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.UserName)
                .IsUnique();
        }
    }
}
