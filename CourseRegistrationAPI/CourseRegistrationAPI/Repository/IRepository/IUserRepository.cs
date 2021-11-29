using CourseRegistrationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool RegisterUser(string firstname, string lastname, string email, string password, string salt);
        bool IsUniqueUser(string email);
        User AuthenticateUser(string username, string password);
        ICollection<Registration> GetCoursesByUser(int id);
        bool RegisterToCourseByUser(int Courseid, int Userid);
        bool UnRegisterToCourseByUser(int Courseid, int Userid);
        bool GetCourseDate(int courseid);
        object GetUser(int userId);
    }
}
