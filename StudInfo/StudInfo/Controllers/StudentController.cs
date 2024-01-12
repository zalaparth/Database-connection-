using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using StudInfo.Models;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace StudInfo.Controllers
{
    [Route("StudentInfo")]
    public class StudentController : Controller
    {
        public Context _Context { get; set; }
        public StudentController(Context context)
        {
            _Context = context;
        }
        [HttpGet]
        public List<Student> Get()
        {  
            var getdata = _Context.Students.ToList();
            return getdata;
        }

        [HttpPost]
        public Student insertdata([FromBody] Student student)
        {
            var adddata = _Context.Students.Add(student);
            _Context.SaveChanges();
            return student;
        }
    }
}
