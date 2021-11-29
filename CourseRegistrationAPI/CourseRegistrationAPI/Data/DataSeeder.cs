using CourseRegistrationAPI.Models;
using CourseRegistrationAPI.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Data
{
    public static class DataSeeder
    {
        //TODO: Ta reda på hur man seedar en redan migrerad databas, lösningen finns i program!!
        public static void Seed(this ModelBuilder modelbuilder)
        {

            string salt = SecurityService.GetSalt(); //Fullösning.
            modelbuilder.Entity<User>().HasData(
                new User { UserId = 1, FirstName = "Oskar", LastName = "Pustinen", Email = "Oskar@Pustinen.com", Password = SecurityService.Hasher("123", salt), Salt = salt },
                new User { UserId = 2, FirstName = "Nikola", LastName = "Pavlovic", Email = "Nikola@Pavlovic.com", Password = SecurityService.Hasher("123", salt), Salt = salt },
                new User { UserId = 3, FirstName = "Hafsa", LastName = "Sheik", Email = "Hafsa@Sheik.com", Password = SecurityService.Hasher("123", salt), Salt = salt },
                new User { UserId = 4, FirstName = "Eerik", LastName = "Sundberg", Email = "Erik@Sundberg.com", Password = SecurityService.Hasher("123", salt), Salt = salt}
                );
            modelbuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(90), StudyPace = 100, ImageSrc= "https://i1.wp.com/www.hyrobygg.se/wp-content/uploads/2016/03/js-logo.png?fit=500%2C500&ssl=1", Subject = "Javascript", CourseInfo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed." },
                new Course { CourseId = 2, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(90), StudyPace = 100, ImageSrc= "https://cdn.pixabay.com/photo/2017/08/05/11/16/logo-2582748_640.png", Subject = "HTML", CourseInfo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed." },
                new Course { CourseId = 3, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(90), StudyPace = 100, ImageSrc= "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/React-icon.svg/1280px-React-icon.svg.png", Subject = "React", CourseInfo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed." },
                new Course { CourseId = 4, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(90), StudyPace = 100, ImageSrc= "https://upload.wikimedia.org/wikipedia/commons/4/49/Redux.png", Subject = "Redux", CourseInfo= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed." }
                );
            modelbuilder.Entity<Registration>().HasData(
                new Registration { CourseId = 1, UserId = 1}              
                );
        }
    }
}
