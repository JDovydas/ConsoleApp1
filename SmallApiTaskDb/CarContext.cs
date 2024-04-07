using Microsoft.EntityFrameworkCore;
using SmallApiTaskDb.Models;

namespace SmallApiTaskDb
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {

        }
    }
}
