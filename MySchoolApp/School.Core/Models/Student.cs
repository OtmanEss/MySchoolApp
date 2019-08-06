using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Models
{
    public class Student:BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public string Adress { get; set; }       
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Image { get; set; }

        //public string Class_Id { get; set; }
        public Course Class { get; set; }
    }
}
