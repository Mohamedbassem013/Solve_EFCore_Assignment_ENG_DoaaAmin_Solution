using EFCore_Assignment.Configurations;
using EFCore_Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Assignment.Context
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITIWS; Trusted_Connection = True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent APIs

            //modelBuilder.ApplyConfiguration(new DepartmentConfigurations());
            //modelBuilder.ApplyConfiguration(new InstructorConfigurations());
            //modelBuilder.ApplyConfiguration(new StudentConfigurations());
            //modelBuilder.ApplyConfiguration(new InstructorCourseConfigurations());
            //modelBuilder.ApplyConfiguration(new StudentCourseConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
