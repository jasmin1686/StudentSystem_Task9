﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem_Task9.StudentSystem.Models
{
    public enum ResourceType
    {
        Video,
        Presentation,
        Document
    }

    internal class Resource
    {
        public int ResourceId { get; set; }

        [MaxLength(50)]

        public string Name { get; set; }
        [Unicode(false)]
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
