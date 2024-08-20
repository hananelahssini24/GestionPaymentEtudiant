using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionPaymentsEtudients.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionPaymentsEtudients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly ApplicationDbContext DbContext;
        public StudentController(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllstudents()
        {
            var allStudents = DbContext.students.ToList();
            return Ok(allStudents);
        }



    }
}
