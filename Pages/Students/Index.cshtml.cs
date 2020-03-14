using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversityWeb.Models;

namespace ContosoUniversityWeb.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly SchoolContext context;

        public IndexModel(SchoolContext context)
        {
            this.context = context;           
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            //Student = await context.Student.ToListAsync();
            Student = await context.Students.ToListAsync();
        }
    }
}
