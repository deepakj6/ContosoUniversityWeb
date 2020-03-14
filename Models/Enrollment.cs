using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversityWeb.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    [Table("Enrollment")]
    public class Enrollment
    {
        [Column("EnrollmentID")]
        public int EnrollmentId { get; set; }

        [Column("CourseID")]
        public int CourseId { get; set; }

        [Column("StudentID")]
        public int StudentId { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        [Column("Grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
