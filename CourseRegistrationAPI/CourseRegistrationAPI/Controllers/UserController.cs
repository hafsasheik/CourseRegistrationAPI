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
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _uRepo;
        public UserController(IUserRepository uRepo)
        {
            _uRepo = uRepo;
        }

        //Authenticate user action with google of some sort..


        [HttpGet]
        public IActionResult GetCoursesForUser(int userid) 
        {
            var Courses = _uRepo.GetCoursesByUser(userid);
            return Ok(Courses); 
        }



        [HttpPost("registerUser")]
        public IActionResult RegisterUser([FromBody] User addeduser)
        {
            bool ifUserEmailExists = _uRepo.IsUniqueUser(addeduser.Email);
            
            if (!ifUserEmailExists)
            {
                return BadRequest(new { message = "This email is already registered" });
            }

            var user = _uRepo.RegisterUser(addeduser.FirstName, addeduser.LastName, addeduser.Email, addeduser.Password);

            if (!user)
            {
                return BadRequest(new { message = "Error while registering" });
            }

            return Ok();
        }


        [HttpPost("registerCourse")]
        public IActionResult RegisterCourseByUser([FromBody] Registration registration)
        {
            if (registration == null)
            {
                return BadRequest(new { message = "Registration to course failed" });
            }

            _uRepo.RegisterToCourseByUser(registration.CourseId, registration.UserId);


            return CreatedAtAction("GetCoursesForUser", registration);

        }

        [HttpDelete]
        public IActionResult UnRegisterCourseByUser([FromBody] Registration registration)
        {
            _uRepo.UnRegisterToCourseByUser(registration.CourseId, registration.UserId);

            return Ok(); 
        }

    }
}
