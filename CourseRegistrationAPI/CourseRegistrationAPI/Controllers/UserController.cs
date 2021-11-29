using CourseRegistrationAPI.Models;
using CourseRegistrationAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseRegistrationAPI.Services;

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

        [UserAuth]
        [HttpGet("CoursesForUser")]
        public IActionResult GetCoursesForUser() 
        {
            int userId = int.Parse(HttpContext.Items["extractId"].ToString()); //bättre att dra id ur token.
            var Courses = _uRepo.GetCoursesByUser(userId);
            var response = Ok(Courses);
            Response.Headers.Add("Access-Control-Expose-Headers", "NewToken");
            //ovan måste läggas till för att FE ska kunna läsa headers under cors.
            Response.Headers.Add("NewToken", HttpContext.Items["newToken"].ToString());
            return response; 
        }



        [HttpPost("registerUser")]
        public IActionResult RegisterUser([FromBody] User addeduser)
        {
            bool userEmailExists = _uRepo.IsUniqueUser(addeduser.Email);
            
            if (!userEmailExists)
            {
                return BadRequest(new { message = "This email is already registered" });
            }

            addeduser.Salt = SecurityService.GetSalt();
            var user = _uRepo.RegisterUser(addeduser.FirstName, addeduser.LastName, addeduser.Email, SecurityService.Hasher(addeduser.Password, addeduser.Salt), addeduser.Salt);

            if (!user)
            {
                return BadRequest(new { message = "Error while registering" });
            }

            return Ok();
        }

        [UserAuth]
        [HttpPost("RegisterCourse")]
        public IActionResult RegisterCourseByUser([FromBody] Registration registration)
        {
            registration.UserId = int.Parse(HttpContext.Items["extractId"].ToString()); //bättre att dra id ur token.
            if (registration == null)
            {
                return BadRequest(new { message = "Registration to course failed" });
            }

            _uRepo.RegisterToCourseByUser(registration.CourseId, registration.UserId);

            var response = CreatedAtAction("GetCoursesForUser", registration);
            Response.Headers.Add("Access-Control-Expose-Headers", "NewToken");
            //Denna måste läggas till för att FE ska kunna läsa headers under cors.
            Response.Headers.Add("NewToken", HttpContext.Items["newToken"].ToString());
            
            return Ok();

        }

        [HttpDelete]
        public IActionResult UnRegisterCourseByUser([FromBody] Registration registration)
        {
            _uRepo.UnRegisterToCourseByUser(registration.CourseId, registration.UserId);

            return Ok(); 
        }

    }
}
