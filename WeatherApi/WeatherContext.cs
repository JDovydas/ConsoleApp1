using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WeatherApi.Models;

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
