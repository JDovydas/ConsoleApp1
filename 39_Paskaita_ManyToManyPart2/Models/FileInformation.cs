using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Paskaita_ManyToManyPart2.Models
{
    internal class FileInformation
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public string FullPath { get; set; }
        public int FolderId { get; set; }
        public virtual Folder Folder { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();

    }
}
