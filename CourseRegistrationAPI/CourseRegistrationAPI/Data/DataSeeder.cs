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
				new User { UserId = 1, FirstName = "Oskar", LastName = "Puustinen", Email = "Oskar@Puustinen.com", Password = SecurityService.Hasher("123", salt), Salt = salt },
				new User { UserId = 2, FirstName = "Nikola", LastName = "Pavlovic", Email = "Nikola@Pavlovic.com", Password = SecurityService.Hasher("123", salt), Salt = salt },
				new User { UserId = 3, FirstName = "Hafsa", LastName = "Sheik", Email = "Hafsa@Sheik.com", Password = SecurityService.Hasher("123", salt), Salt = salt },
				new User { UserId = 4, FirstName = "Erik", LastName = "Sundberg", Email = "Erik@Sundberg.com", Password = SecurityService.Hasher("123", salt), Salt = salt }
				);
			modelbuilder.Entity<Course>().HasData(
				new Course { AvailableSpots = 2, CourseId = 1, StartDate = DateTime.Now.AddDays(20), EndDate = DateTime.Now.AddDays(90), StudyPace = 100, ImageSrc = "https://i1.wp.com/www.hyrobygg.se/wp-content/uploads/2016/03/js-logo.png?fit=500%2C500&ssl=1", Subject = "Javascript", CourseInfo = "Du kommer lära dig webbprogrammeringsspråket JavaScript och dess tillhörande verktyg på djupet. Du kommer även skapa applikationer med en kodbas för Android och iOS, och publicera applikationer på marknader." },
				new Course { AvailableSpots = 3, CourseId = 2, StartDate = DateTime.Now.AddDays(30), EndDate = DateTime.Now.AddDays(120), StudyPace = 50, ImageSrc = "https://cdn.pixabay.com/photo/2017/08/05/11/16/logo-2582748_640.png", Subject = "HTML", CourseInfo = "Kursen syftar till att ge studerande kunskaper samt färdigheter inom webbutveckling med hjälp av HTML5 och CSS3 samt hur man skriver semantisk HTML som validerar och är sökmotoroptimerad." },
				new Course { AvailableSpots = 4, CourseId = 3, StartDate = DateTime.Now.AddDays(10), EndDate = DateTime.Now.AddDays(60), StudyPace = 100, ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/React-icon.svg/1280px-React-icon.svg.png", Subject = "React", CourseInfo = "React är ett JavaScript-bibliotek som används för att bygga användargränssnitt. Det utvecklades till en början av en utvecklare på Facebook men är släppt med öppen källkod. Under React-kursen får du lära dig hur du utvecklar med hjälp av React-biblioteket." },
				new Course { AvailableSpots = 4, CourseId = 4, StartDate = DateTime.Now.AddDays(5), EndDate = DateTime.Now.AddDays(65), StudyPace = 25, ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/4/49/Redux.png", Subject = "Redux", CourseInfo = "Redux är ett bibliotek som tillhandahåller en förutsägbar tillståndscontainer för JavaScript-appar och som ofta används som komplement till React. I den här kursen kommer du att lära dig allt om state-hantering med Redux och närbesläktade verktyg." },
				//new Course { AvailableSpots = 10, CourseId = 5, StartDate = DateTime.Now.AddDays(15), EndDate = DateTime.Now.AddDays(55), StudyPace = 100, ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/C_Sharp_wordmark.svg/120px-C_Sharp_wordmark.svg.png", Subject = "C#", CourseInfo = "Kursen skall ge goda kunskaper i syntax och programmeringsteknik i det objektorienterade programspråket C#(C-sharp) och grunderna i . NET ramverket/klassbibllioteket. Vidare skall den ge förståelse för och användning av begrepp som finns i objektorientering och hur detta stöds i C#." },
				//new Course { AvailableSpots = 5, CourseId = 6, StartDate = DateTime.Now.AddDays(2), EndDate = DateTime.Now.AddDays(32), StudyPace = 100, ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/121px-Python-logo-notext.svg.png", Subject = "Python", CourseInfo = "Redux är ett bibliotek som tillhandahåller en förutsägbar tillståndscontainer för JavaScript-appar och som ofta används som komplement till React. I den här kursen kommer du att lära dig allt om state-hantering med Redux och närbesläktade verktyg." },
				new Course { AvailableSpots = 7, CourseId = 7, StartDate = DateTime.Now.AddDays(15), EndDate = DateTime.Now.AddDays(75), StudyPace = 75, ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Vue.js_Logo_2.svg/220px-Vue.js_Logo_2.svg.png", Subject = "Vue.js", CourseInfo = "Vue.js är känt för sin låga inlärningskurva, flexibilitet och prestanda. Denna kurs avser ge dig goda grunder för att bygga allt ifrån enkla webbapplikationer till större system som kommunicerar med servrar med Vue." },
				new Course { AvailableSpots = 10, CourseId = 8, StartDate = DateTime.Now.AddDays(7), EndDate = DateTime.Now.AddDays(37), StudyPace = 100, ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Angular_full_color_logo.svg/250px-Angular_full_color_logo.svg.png", Subject = "Angular", CourseInfo = "Angular är ett open source ramverk för webbutveckling som tagits fram av Google. Det är inte att blanda ihop med AngularJS. Under en Angular-kurs får du lära dig hur du enkelt bygger flexibla och dynamiska webbapplikationer." }

				);

			modelbuilder.Entity<Registration>().HasData(
				new Registration { CourseId = 3, UserId = 1 },
				new Registration { CourseId = 1, UserId = 2 },
				new Registration { CourseId = 1, UserId = 3 }
				);
		}
	}
}
