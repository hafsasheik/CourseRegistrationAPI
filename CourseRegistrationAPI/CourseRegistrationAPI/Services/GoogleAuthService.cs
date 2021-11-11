using CourseRegistrationAPI.Data;
using CourseRegistrationAPI.Models;
using Google.Apis.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Services
{
    public class GoogleAuthService : IGoogleAuthService
    {
        private readonly RegCourseDBContext _context;

        public GoogleAuthService(RegCourseDBContext context)
        {
            _context = context;
            
        }

        public async Task<User> AuthenticateUserAsync(string googleToken)
        {
            try
            {
                var payload = await GoogleJsonWebSignature.ValidateAsync(googleToken, new GoogleJsonWebSignature.ValidationSettings());
                User u = await _context.Users.FirstOrDefaultAsync(u => u.Email == payload.Email);

                return u;
            }
            catch(Exception epicFail)
            {
                Debug.WriteLine(epicFail.Message);
                return null;
            }
            

            
        }
    }
}
