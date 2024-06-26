﻿using _43_Paskaita_Exam_Databases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases.Repository.Interfaces
{
    public interface ILectureRepository //internal
    {
        public void CreateLecture(Lecture lecture);
        public void CreateLectureAndAssignToDepartment(Lecture lecture, Department department);
        public IEnumerable<Lecture> DisplayLecturesInSelectedDepartment(Department department);
        public IEnumerable<Lecture> DisplayLecturesByStudent(Student student);

    }
}
