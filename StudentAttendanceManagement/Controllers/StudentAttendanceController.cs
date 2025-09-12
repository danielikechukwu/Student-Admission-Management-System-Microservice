using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {

        public static List<StudentAttendanceDetails> studentAttendanceDetails = new List<StudentAttendanceDetails>
        {
            new StudentAttendanceDetails { StudentID = 1, StudentName = "John Doe", AttendancePercentage = 83.02 },
            new StudentAttendanceDetails { StudentID = 2, StudentName = "Brad",  AttendancePercentage = 71.02 },
        };

        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetails> Get()
        {
            return studentAttendanceDetails;
        }

        // GET api/<StudentAttendanceController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<StudentAttendanceController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<StudentAttendanceController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<StudentAttendanceController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
