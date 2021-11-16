using CourseRegistrationAPI.Data;
using CourseRegistrationAPI.Models;
using CourseRegistrationAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly RegCourseDBContext _db;

        public UserRepository(RegCourseDBContext db)
        {
            _db = db;
        }

        //Register/Login

        public bool RegisterUser(string firstname, string lastname, string email, string password)
        {
           
                User user = new User()
                {
                    LastName = lastname,
                    FirstName = firstname,
                    Email = email, 
                    Password = password,
                };

                _db.Users.Add(user);
            return Save(); 
            
        }

        public User AuthenticateUser(string Email, string password)
        {
            var user = _db.Users.SingleOrDefault(x => x.Email == Email && x.Password == password);

            if (user == null)
            {
                return null;
            }

            return user; 
        }



        public bool IsUniqueUser(string email)
        {
            var user = _db.Users.SingleOrDefault(x => x.Email == email);

            // return null if user not found
            if (user == null)
                return true;

            return false;
        }


        // UserActions

        public ICollection<Registration> GetCoursesByUser(int userid)
        {
            //var user = _db.Users.SingleOrDefault(x => x.UserId == userid);
            return _db.Registrations.Where(c => c.UserId == userid).Include(c => c.Course).ToList();
        }


        public bool RegisterToCourseByUser(int courseid, int userid)
        {
            Registration registration = new();
            registration.CourseId = courseid;
            registration.UserId = userid;

            _db.Registrations.Add(registration);
            return Save();

        }


        public bool UnRegisterToCourseByUser(int courseid, int userid)
        {
            Registration registration = new();
            registration.CourseId = courseid;
            registration.UserId = userid;

            _db.Registrations.Remove(registration);
            return Save();
        }

        public int CountRegistrations(int courseid)
        {
            return _db.Registrations.Where(r => r.CourseId == courseid).ToList().Count();
        }



        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
