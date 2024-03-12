using _37_Paskaita_Exercise.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Paskaita_Exercise.Database
{
    internal class MsSqlDb : DbContext
    {
        public DbSet<LocalDirectory> Directories { get; set; }
        public DbSet<LocalFile> Files { get; set; }
        public DbSet<FileTag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ManyToMany;Trusted_Connection=True");


    }
}
