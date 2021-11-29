using CourseRegistrationAPI.Data;
using CourseRegistrationAPI.Models;
using CourseRegistrationAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public bool RegisterUser(string firstname, string lastname, string email, string password, string salt)
        {

            User user = new User()
            {
                LastName = lastname,
                FirstName = firstname,
                Email = email,
                Password = password,
                Salt = salt
                };

                _db.Users.Add(user);
            return Save(); 
            
        }

        public User GetUser(int id)
        {
            var user = _db.Users.SingleOrDefault(user => user.UserId == id);
            return user;
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


        public bool Save()
        {
            try
            {
                return _db.SaveChanges() >= 0 ? true : false; //Vad gör denna egentligen?
            }
            catch(Exception epicFail) 
            {
                Debug.WriteLine(epicFail.Message);
                return false; //Blir detta rätt?
            }
        }

        public bool GetCourseDate(int courseid)
        {
            var date = _db.Courses.FirstOrDefault(dt => dt.CourseId == courseid);
            
            var coursedate = Convert.ToInt32(Convert.ToString(date.StartDate.Date));
            var todaysDate = Convert.ToInt32(Convert.ToString(DateTime.Now.Date));

            if(coursedate > todaysDate)
            {
                return true; 
            }

            return false; 
        }
    }
}
