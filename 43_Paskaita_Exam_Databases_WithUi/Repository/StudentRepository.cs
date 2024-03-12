using _43_Paskaita_Exam_Databases_WithUi.Models;
using _43_Paskaita_Exam_Databases_WithUi.Repository.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases_WithUi.Repository
{
    internal class StudentRepository : IStudentRepository
    {
        private readonly UniversityContext _context;

        public StudentRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateStudentAndAssignToDepartment(Student student, Department department)
        {
            var existingDepartment = _context.Departments.FirstOrDefault(d => d.DepartmentId == department.DepartmentId);
            if (existingDepartment != null)
            {
                student.Department = existingDepartment;
                _context.Students.Add(student);
                _context.SaveChanges();

            }
        }

        public void TransferStudentToAnotherDepartment(Student student, Department newDepartment)
        {
            var existingStudent = _context.Students.FirstOrDefault(s => s.Id == student.Id);
            var existingDepartment = _context.Departments.FirstOrDefault(d => d.DepartmentId == newDepartment.DepartmentId);
            if (existingStudent != null && existingDepartment != null)
            {
                existingStudent.Department = newDepartment;
                _context.SaveChanges();
            }

        }

        public IEnumerable<Student> DisplayStudentsInDepartment(Department department)
        {
            return _context.Students.Where(s => s.Department.DepartmentId == department.DepartmentId).ToList();
        }


    }
}
