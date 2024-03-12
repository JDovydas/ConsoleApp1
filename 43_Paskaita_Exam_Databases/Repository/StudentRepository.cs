using _43_Paskaita_Exam_Databases.Models;
using _43_Paskaita_Exam_Databases.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases.Repository
{
    internal class StudentRepository : IStudentRepository
    {
        private readonly UniversityContext _context;

        public StudentRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }


        public void CreateStudentAndAssignToDepartmentAndLectures(Student student, Department department, List<Lecture> lectures)
        {
            var existingDepartment = _context.Departments.FirstOrDefault(d => d.DepartmentId == department.DepartmentId);
            if (existingDepartment != null)
            {
                student.Department = existingDepartment;
                student.Lectures.AddRange(lectures);
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

        public void StudentToHaveOnlyNewDepartmentLecturesAssigned(Student student, Department newDepartment)
        {
            var existingStudent = _context.Students.FirstOrDefault(s => s.Id == student.Id);
            var existingDepartment = _context.Departments.FirstOrDefault(d => d.DepartmentId == newDepartment.DepartmentId);
            if (existingStudent != null && existingDepartment != null)
            {
                existingStudent.Lectures.Clear();
                existingStudent.Department = existingDepartment;
                foreach (var lecture in existingDepartment.Lectures)
                {
                    existingStudent.Lectures.Add(lecture);
                }
                _context.SaveChanges();


            }


        }

        public IEnumerable<Student> DisplayStudentsInSelectedDepartment(Department department)
        {
            return _context.Students.Where(s => s.Department.DepartmentId == department.DepartmentId).ToList();
        }


    }
}
