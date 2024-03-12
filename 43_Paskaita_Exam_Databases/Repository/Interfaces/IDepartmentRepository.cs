using _43_Paskaita_Exam_Databases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases.Repository.Interfaces
{
    internal interface IDepartmentRepository
    {
        public void AddStudentsAndLecturesToExistingDepartment(List<Student> students, List<Lecture> lectures, Department department);
        public void CreateDepartment(Department department);

    }
}
