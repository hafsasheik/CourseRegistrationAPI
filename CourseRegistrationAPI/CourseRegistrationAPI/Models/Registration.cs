using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public User User { get; set; }
        public Course Course { get; set; }
    }
}
