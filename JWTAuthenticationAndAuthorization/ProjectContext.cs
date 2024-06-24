using JWTAuthenticationAndAuthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthenticationAndAuthorization
{
    public class ProjectContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Car> Cars { get; set; }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

    }
}
