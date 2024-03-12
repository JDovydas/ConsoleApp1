using _43_Paskaita_Exam_Databases.Models;
using _43_Paskaita_Exam_Databases.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases.Repository
{
    internal class LectureRepository : ILectureRepository
    {

        private readonly UniversityContext _context;

        public LectureRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateLecture(Lecture lecture)
        {
            _context.Lectures.Add(lecture);
            _context.SaveChanges();
        }


        public void CreateLectureAndAssignToDepartment(Lecture lecture, Department department)
        {
            var existingDepartment = _context.Departments.FirstOrDefault(d => d.DepartmentId == department.DepartmentId);
            if (existingDepartment != null)
            {
                var existingLecture = existingDepartment.Lectures.FirstOrDefault(l => l.Name == lecture.Name);
                if (existingLecture == null)
                {
                    existingDepartment.Lectures.Add(lecture);
                    _context.SaveChanges();
                }
            }
        }



        public IEnumerable<Lecture> DisplayLecturesInSelectedDepartment(Department department)
        {
            return _context.Lectures.Where(l => l.Departments.Contains(department)).ToList();
        }

        public IEnumerable<Lecture> DisplayLecturesByStudent(Student student)
        {
            return _context.Lectures.Where(l => l.Students.Contains(student)).ToList();
        }



    }
}
