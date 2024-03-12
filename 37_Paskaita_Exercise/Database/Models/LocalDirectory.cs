using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Paskaita_Exercise.Database.Models
{
    internal class LocalDirectory
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string Name { get; set; }
        public string FullPath { get; set; }
        public List<LocalFile> Files { get; set; } = new List<LocalFile>();
    }
}
