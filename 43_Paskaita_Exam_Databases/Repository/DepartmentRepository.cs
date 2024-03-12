using _43_Paskaita_Exam_Databases.Models;
using _43_Paskaita_Exam_Databases.Repository.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases.Repository
{
    internal class DepartmentRepository : IDepartmentRepository
    {
        private readonly UniversityContext _context;

        public DepartmentRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateDepartment(Department department2)
        {
            _context.Departments.Add(department2);
            _context.SaveChanges();
        }

        public void AddStudentsAndLecturesToExistingDepartment(List<Student> students, List<Lecture> lectures, Department department)
        {
            Department existingDepartment = _context.Departments.FirstOrDefault(d => d.DepartmentId == department.DepartmentId);
            if (existingDepartment != null)
                foreach (var student in students)
                {
                    if (!existingDepartment.Students.Any(s => s.Name == student.Name))
                    {
                        existingDepartment.Students.Add(student);
                    }
                }

            foreach (var lecture in lectures)
            {
                if (!existingDepartment.Lectures.Any(l => l.Name == lecture.Name))
                {
                    existingDepartment.Lectures.Add(lecture);
                }
            }

            _context.SaveChanges();
        }


    }



}

