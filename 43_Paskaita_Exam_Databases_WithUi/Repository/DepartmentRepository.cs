using _43_Paskaita_Exam_Databases_WithUi.Models;
using _43_Paskaita_Exam_Databases_WithUi.Repository.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases_WithUi.Repository
{
    internal class DepartmentRepository : IDepartmentRepository
    {
        private readonly UniversityContext _context;

        public DepartmentRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public void UpdateDepartment(Department department)
        {
            _context.Departments.Attach(department);
            _context.SaveChanges();
        }

        public void AddStudentsAndLecturesToExistingDepartment(Student studemt, Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

    }
}
