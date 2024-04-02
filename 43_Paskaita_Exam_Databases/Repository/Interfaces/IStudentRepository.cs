using _43_Paskaita_Exam_Databases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases.Repository.Interfaces
{
    public interface IStudentRepository ////internal
    {
        public void CreateStudent(Student student);
        public void CreateStudentAndAssignToDepartmentAndLectures(Student student, Department department, List<Lecture> lectures);
        public void StudentToHaveOnlyNewDepartmentLecturesAssigned(Student student, Department newDepartment);
        public void TransferStudentToAnotherDepartment(Student Student, Department newDepartment);
        public IEnumerable<Student> DisplayStudentsInSelectedDepartment(Department department);

    }
}
