﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Paskaita_EntityFramework.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> StudentCourses { get; set; }
    }
}
