using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _36_Paskaita_EntityFrameworkProject.Database.Models;

namespace _36_Paskaita_EntityFrameworkProject.Database
{
    internal class BookContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=BookDatabase;Trusted_Connection=True");
    }
}
