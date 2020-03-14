using ContosoUniversityWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversityWeb
{
    [Route("/studs")]
    public class HomeController : ControllerBase
    {
        private readonly SchoolContext context;

        public HomeController(SchoolContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult List()
        {
            try
            {
                var output = context.Students.ToList();
                return Ok(output);
            }
            catch(Exception ex)
            {
                return NotFound();
            }

        }
    }
}
