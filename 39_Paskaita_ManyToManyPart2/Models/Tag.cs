using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Paskaita_ManyToManyPart2.Models
{
    internal class Tag
    {
        public string Id { get; set; }
        public string Name { get; set; }
        //[ForeignKey("FileInformation")]
        public List<FileInformation> Files { get; set; }


    }
}
