using Microsoft.AspNetCore.Mvc;
using SystemAdmissionManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SystemAdmissionManagement.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {

        public static List<StudentAdmissionDetails> studentAdmissionDetails = new List<StudentAdmissionDetails>
        {
            new StudentAdmissionDetails { StudentID = 1, StudentName = "John Doe", StudentClass = "10th Grade", DateOfJoining = DateTime.Now },
            new StudentAdmissionDetails { StudentID = 2, StudentName = "Charlie Kirk", StudentClass = "19th Grade", DateOfJoining = DateTime.Now }
        };

        // GET: api/<StudentAdmissionController>
        [HttpGet("GetStudentDetail")]
        public IEnumerable<StudentAdmissionDetails> Get()
        {
            return studentAdmissionDetails;
        }

        // GET api/<StudentAdmissionController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<StudentAdmissionController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<StudentAdmissionController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<StudentAdmissionController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
