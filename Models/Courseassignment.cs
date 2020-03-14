using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversityWeb.Models
{
    [Table("Courseassignment")]
    public class Courseassignment
    {
        /*[Key]
        public int Id { get; set; }*/

        [Column("InstructorID")]
        public int InstructorId { get; set; }

        [Column("CourseID")]
        public int CourseId { get; set; }

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
