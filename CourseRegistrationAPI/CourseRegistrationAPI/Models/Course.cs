using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Subject { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]

        public DateTime StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]

        public DateTime EndDate { get; set; }
        [Required]
        public int StudyPace { get; set; }
        public ICollection<Registration> Registrations { get; set; }
    }
}
