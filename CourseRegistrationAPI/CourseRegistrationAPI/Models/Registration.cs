using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
