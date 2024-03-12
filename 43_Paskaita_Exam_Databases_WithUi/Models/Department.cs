using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases_WithUi.Models
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public virtual List<Student> Students { get; set; }

        public virtual List<Lecture> Lectures { get; set; }
    }
}
