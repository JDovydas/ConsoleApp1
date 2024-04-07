using System.Collections.Generic;
using WeatherApi.Models;
using Microsoft.EntityFrameworkCore;

namespace WeatherApi
{
    public class WeatherContext : DbContext
    {
        public DbSet<Weather> Weather { get; set; }

        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {

        }

    }

}
