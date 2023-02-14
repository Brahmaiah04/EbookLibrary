using DemoApi.StudentData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        private IStudentData studentData;
        public ApiController(IStudentData studentData)
        {
            this.studentData = studentData;
        }
        [HttpGet]
        [Route]
        public IActionResult GetStudents()
        {
            return Ok(studentData.GetStudents());
        }
    }
}
