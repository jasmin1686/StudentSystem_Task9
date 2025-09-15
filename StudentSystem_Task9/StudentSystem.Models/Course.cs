using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem_Task9.StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        [MaxLength(80)]

        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
     
        
        public List<Homework> Homeworks { get; set; }
        public List<Resource> Resources { get; set; }
        
       

    }
}
