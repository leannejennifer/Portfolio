using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.API.Models;

namespace Portfolio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController(IDbContext dbContext) : Controller
    {
        [HttpGet("GetStudents")]
        public ActionResult<IEnumerable<Student>> Get()
        {
            var students = dbContext.GetCollection(typeof(Student));

            if(!students.Any())
            {
                return NotFound();
            }
            else
            {
                return Ok(students);
            } 
                
        }
    }
}
