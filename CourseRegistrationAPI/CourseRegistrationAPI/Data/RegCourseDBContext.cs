using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseRegistrationAPI.Models;

namespace CourseRegistrationAPI.Data
{
    public class RegCourseDBContext: DbContext
    {
        public RegCourseDBContext(DbContextOptions options)
        : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<User> Users { get; set; }




    }



}
