﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem_Task9.StudentSystem.Models
{
    [PrimaryKey(nameof(StudentId),nameof(CourseId))]
    internal class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
