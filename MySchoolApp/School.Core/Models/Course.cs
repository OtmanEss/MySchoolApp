using System;
using System.Collections.Generic;

namespace School.Core.Models
{
    public class Course:BaseClass
    {
        public string Name { get; set; }

        public List<Student> Students { get; set; }

        public Teacher Teacher { get; set; }
    }
}