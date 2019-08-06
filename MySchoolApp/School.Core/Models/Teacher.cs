using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Core.Models
{
    public class Teacher:BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }
        public int Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
    }
}