using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Paskaita_Exercise.Database.Models
{
    internal class LocalFile
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string Name { get; set; }
        public string FullPath { get; set; }
        public long Size { get; set; }
        [ForeignKey("Directory")]
        public int DirectoryId { get; set; }
        public LocalDirectory Directory { get; set; }
        public List<FileTag> Tags { get; set; } = new();

        public LocalFile()
        {

        }

    }
}
