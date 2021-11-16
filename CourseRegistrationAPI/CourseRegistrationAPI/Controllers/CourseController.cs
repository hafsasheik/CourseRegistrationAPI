using CourseRegistrationAPI.Models;
using CourseRegistrationAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly ICourseRepository _uRepo;
        public CourseController(ICourseRepository uRepo)
        {
            _uRepo = uRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetCourses()
        {
            var Courses = _uRepo.GetCourses();
            return Ok(Courses);
        }

     

    }
}
