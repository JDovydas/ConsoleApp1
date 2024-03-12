using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Paskaita_ManyToMany.Models
{
    internal class FileInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public string FullPath { get; set; }
        [ForeignKey("Folder")]
        public int FolderId { get; set; }
        //public List<Folder> FileFolders { get; set; }

    }
}
