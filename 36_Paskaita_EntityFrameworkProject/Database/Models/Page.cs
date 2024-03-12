using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Paskaita_EntityFrameworkProject.Database.Models
{
    internal class Page
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Content { get; set; }
        [ForeignKey("Book")]
        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }
        public Page(int number, string content)
        {
            Id = Guid.NewGuid();
            Number = number;
            Content = content;

        }
    }
}
