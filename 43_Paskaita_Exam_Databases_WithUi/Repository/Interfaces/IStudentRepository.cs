using _43_Paskaita_Exam_Databases_WithUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases_WithUi.Repository.Interfaces
{
    internal interface IStudentRepository
    {
        public void CreateStudentAndAssignToDepartment(Student student, Department department);

        public void TransferStudentToAnotherDepartment(Student Student, Department department);

        public IEnumerable<Student> DisplayStudentsInDepartment(Department department);

    }
}
