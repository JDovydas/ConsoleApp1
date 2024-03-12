using _43_Paskaita_Exam_Databases_WithUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases_WithUi.Repository.Interfaces
{
    internal interface IDepartmentRepository
    {
        public void CreateDepartment(Department department);

        public void AddStudentsAndLecturesToExistingDepartment(Student student, Department department); //, List<Student> Students, List<Lecture> lectures

    }
}
