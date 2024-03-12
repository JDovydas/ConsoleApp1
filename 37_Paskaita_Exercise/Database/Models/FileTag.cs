using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Paskaita_Exercise.Database.Models
{
    internal class FileTag
    {
        public int Id { get; set; }
        public string TagWord { get; set; }
        public List<LocalFile> Files { get; set; } = new();
    }
}
