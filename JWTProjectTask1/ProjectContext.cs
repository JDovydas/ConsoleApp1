using JWTProjectTask1.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTProjectTask1
{
    public class ProjectContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Car> Cars { get; set; }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        //public ProjectContext()
        //{

        //}

    }
}
