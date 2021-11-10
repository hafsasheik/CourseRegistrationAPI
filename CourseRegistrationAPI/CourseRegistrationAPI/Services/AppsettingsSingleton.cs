using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CourseRegistrationAPI.Services
{
    public class AppsettingsSingleton
    {
        public static AppsettingsSingleton Instance { get; set; } //Singleton.
        public string JwtSecret { get; set; }
        public string GoogleClientId { get; set; }
        public string GoogleClientSecret { get; set; }
        public string JwtEmailEncryption { get; set; }
    }
}
