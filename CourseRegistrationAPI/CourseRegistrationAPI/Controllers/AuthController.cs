using CourseRegistrationAPI.Data;
using CourseRegistrationAPI.Models;
using CourseRegistrationAPI.Services;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
        
        // POST api/<AuthController>
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginCredsDTO creds)
        {
            if (creds == null)
                return BadRequest("no creds received");

            try
            {
                User u = await _context.Users.FirstOrDefaultAsync(u => u.Email == creds.Email);
                if(u.Password == creds.Password)
                {
                    string token = CreateToken(u.UserId);
                    return Ok(token);
                }
            }
            catch(Exception epicFail)
            {
                Debug.WriteLine(epicFail.Message);
                return BadRequest(epicFail.Message);
            }

            return Forbid("Wrong creds!");
        }

        [HttpPost("googlelogin")]
        public async Task<IActionResult> GoogleLogin([FromBody] string googleToken )
        {
            if (String.IsNullOrWhiteSpace(googleToken))
                return BadRequest("No token received");

            try
            {
                User u = await _authService.AuthenticateUserAsync(googleToken);
                if(u!= null)
                {
                    return Ok(CreateToken(u.UserId));
                }
            }
            catch(Exception epicFail)
            {
                Debug.WriteLine(epicFail.Message);
                return BadRequest(epicFail.Message);
            }

            return Forbid("Wrong creds!");
        }


        private string CreateToken(int userId)
        {
            var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, SecurityService.Encrypt(AppsettingsSingleton.Instance.JwtEmailEncryption, userId.ToString())),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AppsettingsSingleton.Instance.JwtSecret));
            var tokenCreds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddMinutes(55), signingCredentials: tokenCreds);
            return new JwtSecurityTokenHandler().WriteToken(token);

        }

    }
}
