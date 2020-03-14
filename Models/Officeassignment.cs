using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversityWeb.Models
{

    [Table("Officeassignment")]
    public class Officeassignment
    {
/*        [Key]
        public int Id { get; set; }*/
        public int InstructorId { get; set; }
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}
