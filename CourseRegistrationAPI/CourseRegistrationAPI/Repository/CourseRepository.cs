using CourseRegistrationAPI.Data;
using CourseRegistrationAPI.Models;
using CourseRegistrationAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Repository
{
    public class CourseRepository: ICourseRepository
    {
        private readonly RegCourseDBContext _db;

        public CourseRepository(RegCourseDBContext db)
        {
            _db = db;
        }

        public ICollection<Course> GetCourses()
        {
            return _db.Courses.OrderBy(a => a.Subject).ToList();
        }


        public Course GetCourseDetails(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
