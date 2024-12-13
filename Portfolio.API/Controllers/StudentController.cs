using Microsoft.AspNetCore.Mvc;
using Portfolio.API.Models;

namespace Portfolio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {

        [HttpGet("GetStudents")]
        ///[Route("GetStudents")]
        public IEnumerable<Student> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Student
            {
                StudentId = index,
                FirstName = "John",
                LastName = "Smith " + index
            })
            .ToArray();
        }
    }
}
