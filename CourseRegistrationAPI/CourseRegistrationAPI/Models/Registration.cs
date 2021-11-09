using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Models
{
    public class Registration
    {
        //[Key]
        //public int RegistrationId { get; set; }
     
        //[Key]
        public int UserId { get; set; }
        public User User { get; set; }

        //[Key]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
