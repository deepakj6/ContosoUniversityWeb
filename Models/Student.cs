using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversityWeb.Models
{
     [Table("Student")]
    public class Student
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("FirstMidName")]
        public string FirstMidName { get; set; }
        [Column("EnrollmentDate")]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
