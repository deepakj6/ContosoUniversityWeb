using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversityWeb.Models
{
    [Table("Course")]
    public class Course
    {
        [Column("CourseID")]
        public int CourseId { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Credits")]
        public int Credits { get; set; }

        //public ICollection<Courseassignment> Courseassignment { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
