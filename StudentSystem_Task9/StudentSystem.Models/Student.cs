using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem_Task9.StudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(10)]
        [Unicode (false)]
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }
        
        public List<Homework> Homeworks { get; set; }
    }
}
