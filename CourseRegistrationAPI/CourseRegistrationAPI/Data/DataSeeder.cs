using CourseRegistrationAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI.Data
{
    public static class DataSeeder
    {
        //TODO: Ta reda på hur man seedar en redan migrerad databas!!
        //TODO: 
        public static void Seed(this ModelBuilder modelbuilder)
        {       


            modelbuilder.Entity<User>().HasData(
                new User { UserId = 1, FirstName = "Oskar", LastName = "Pustinen", Email = "Oskar@Pustinen.com", Password = "123", },
                new User { UserId = 2, FirstName = "Nikola", LastName = "Pavlovic", Email = "Nikola@Pavlovic.com", Password = "123", },
                new User { UserId = 3, FirstName = "Hafsa", LastName = "Sheik", Email = "Hafsa@Sheik.com", Password = "123", },
                new User { UserId = 4, FirstName = "Eerik", LastName = "Sundberg", Email = "Erik@Sundberg.com", Password = "123", }
                );
            modelbuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(90), StudyPace = 100, Subject = "Javascript", CourseInfo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed." },
                new Course { CourseId = 2, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(90), StudyPace = 100, Subject = "HTML", CourseInfo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed." },
                new Course { CourseId = 3, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(90), StudyPace = 100, Subject = "React", CourseInfo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed." },
                new Course { CourseId = 4, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(90), StudyPace = 100, Subject = "Redux", CourseInfo= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed." }
                );
            modelbuilder.Entity<Registration>().HasData(
                new Registration { CourseId = 1, UserId = 1}              
                );
        }
    }
}
