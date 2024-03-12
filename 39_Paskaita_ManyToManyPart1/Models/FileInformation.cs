using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Paskaita_ManyToManyPart1.Models
{
    internal class FileInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public string FullPath { get; set; }
    }
}
