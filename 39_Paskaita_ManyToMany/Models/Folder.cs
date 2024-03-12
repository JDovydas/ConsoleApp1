using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Paskaita_ManyToMany.Models
{
    internal class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentFolderId { get; set; }
        public List<FileInformation> FolderFileInformation { get; set; }
    }
}
