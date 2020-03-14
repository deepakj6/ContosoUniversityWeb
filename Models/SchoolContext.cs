using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContosoUniversityWeb.Models
{
    public partial class SchoolContext : DbContext
    {
       public SchoolContext(DbContextOptions options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Instructor> Instructors { get; set; }

        //public DbSet<Courseassignment> Courseassignments { get; set; }
       // public DbSet<Officeassignment> Officeassignments { get; set; }


    }
}
