using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.Data;

namespace ContosoUniversityWeb.Models
{
    [Table("Instructor")]
    public class Instructor
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("HireDate")]        
        public DateTime HireDate { get; set; }

        public Officeassignment Officeassignment { get; set; }
        public ICollection<Courseassignment> Courseassignment { get; set; }
        public ICollection<Department> Department { get; set; }
    }
}
