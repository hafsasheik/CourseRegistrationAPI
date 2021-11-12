using CourseRegistrationAPI.Models;
using Google.Apis.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Services
{
    public interface IGoogleAuthService
    {
        public Task<User> AuthenticateUserAsync(string googleToken);
    }
}
