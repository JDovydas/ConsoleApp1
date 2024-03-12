using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Paskaita_EntityFrameworkProject.Database.Models
{
    internal class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<Page> Pages { get; set; }
    }
}
