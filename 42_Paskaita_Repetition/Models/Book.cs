using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _42_Paskaita_Repetition.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public virtual List<Author> Authors { get; set; } //Lists automatically map since Authors have many books

        //Foreign Key would be needed if we do not use List:
        //[ForeignKey("Author")]
        //public Guid AuthorId { get; set; }
        //public virtual Author Author { get; set; }

    }
}
