using _43_Paskaita_Exam_Databases.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases
{
    public class UniversityContext : DbContext //private
    {
        public UniversityContext()
        {
        }
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {
        }


        public virtual DbSet<Department> Departments { get; set; } //PREVIOUSLY IT WAS public DbSet<Department> Departments
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            if (!optionsBuilder.IsConfigured) //will be used if not configured only - will use inMemory as a primary option
            {
                optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=UniversityDatabase;Trusted_Connection=True");
            }
        }




    }
}

