using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Services;
using WebApplication3.Model;
using Microsoft.IdentityModel.Protocols;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private ILogger _logger;
        private IStudentList _studentService;
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DormitoryConnectionString"].ConnectionString);


        public StudentController(ILogger<StudentController> logger, IStudentList studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        [HttpGet("/api/student")]
        public ActionResult<List<Student>> GetStudents()
        {


            return _studentService.GetStudents();
        }

        [HttpPost("/api/student/add")]
        public ActionResult<Student> AddStudent(Student student)
        {
            _studentService.AddStudent(student);
            return student;
        }

        [HttpPut("/api/student/{id}")]
        public ActionResult<Student> UpdateStudent(string id, Student student)
        {
            _studentService.UpdateStudent(id, student);
            return student;
        }

        [HttpDelete("/api/student/{id}")]
        public ActionResult<string> DeleteStudent(string id)
        {
            _studentService.DeleteStudent(id);
            return id;
        }
    }
}
