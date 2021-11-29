using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Models
{
    public class Course
        //TODO: Lägga till en info propp? 
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [Required]
        public int AvailableSpots { get; set; }
        public int RegisteredStudents { get; set; } = 0;
        public string Subject { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime EndDate { get; set; }

        [Required]
        public int StudyPace { get; set; }
        public string ImageSrc { get; set; }

        public ICollection<Registration> Registrations { get; set; }
        public string CourseInfo { get; set; }
    }
}
