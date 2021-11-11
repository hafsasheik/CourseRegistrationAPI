using CourseRegistrationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Repository.IRepository
{
    public interface ICourseRepository
    {
        ICollection<Course> GetCourses();
        Course GetCourseDetails(int Id);
    }
}
