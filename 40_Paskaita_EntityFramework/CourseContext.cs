
using Microsoft.EntityFrameworkCore;
using _40_Paskaita_EntityFramework.Models;

namespace _40_Paskaita_EntityFramework
{
    internal class CourseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=CourseDatabase;Trusted_Connection=True");

    }
}
