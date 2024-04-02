using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public virtual List<Student> Students { get; set; } = new List<Student>();

        public virtual List<Lecture> Lectures { get; set; } = new List<Lecture>();
    }
}
