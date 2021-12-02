using CourseRegistrationAPI.Data;
using CourseRegistrationAPI.Models;
using CourseRegistrationAPI.Models.DTOs;
using CourseRegistrationAPI.Services;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseRegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly RegCourseDBContext _context;
        private readonly IGoogleAuthService _authService;

        public AuthController(RegCourseDBContext context, IGoogleAuthService authService)
        {
            _context = context;
            _authService = authService;

        }
        
        // POST api/auth/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginCredsDTO creds)
        {
            if (creds == null)
                return BadRequest("no creds received");

            try
            {
                User u = await _context.Users.FirstOrDefaultAsync(u => u.Email == creds.Email);
                
                if (u != null && u.Password == SecurityService.Hasher(creds.Password, u.Salt))
                {
                    string token = SecurityService.CreateToken(u.UserId);


                    var response = Ok(token);
                    
                    return response;
                }
            }
            catch(Exception epicFail)
            {
                Debug.WriteLine(epicFail.Message);
                return BadRequest(epicFail.Message);
            }

            return Forbid("Wrong creds!");
        }
        //api/auth/googlelogin
        [HttpPost("googlelogin")]
        public async Task<IActionResult> GoogleLogin([FromBody]GoogleTokenDTO dto)
            {

            string googleToken = dto.GoogleToken;
            if (String.IsNullOrWhiteSpace(googleToken))
                return BadRequest("No token received");

            try
            {
                User u = await _authService.AuthenticateUserAsync(googleToken);
                if(u!= null)
                {
                    return Ok(SecurityService.CreateToken(u.UserId));
                }
            }
            catch(Exception epicFail)
            {
                Debug.WriteLine(epicFail.Message);
                return BadRequest(epicFail.Message);
            }

            return Forbid("Wrong creds!");
        }


        

    }
}
