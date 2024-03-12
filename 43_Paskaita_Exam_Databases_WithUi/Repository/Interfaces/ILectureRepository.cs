﻿using _43_Paskaita_Exam_Databases_WithUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Paskaita_Exam_Databases_WithUi.Repository.Interfaces
{
    internal interface ILectureRepository
    {
        public void CreateLectureAndAssignToDepartment(Lecture lecture, Department department);

        public IEnumerable<Lecture> DisplayLecturesInDepartment(Department department);

        public IEnumerable<Lecture> DisplayLecturesByStudent(Student student);

    }
}
