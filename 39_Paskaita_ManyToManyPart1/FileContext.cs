using _39_Paskaita_ManyToManyPart1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _39_Paskaita_ManyToManyPart1
{
    internal class FileContext : DbContext
    {
        public DbSet<FileInformation> Files { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=CourseDatabasePart1;Trusted_Connection=True");
        }
    }
}
