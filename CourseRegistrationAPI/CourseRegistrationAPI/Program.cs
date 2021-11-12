
using CourseRegistrationAPI.Services;

using CourseRegistrationAPI.Data;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

using System.IO;

using System.Diagnostics;

using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string json = File.ReadAllText("appsettings.json");
            JObject jo = JObject.Parse(json);
            AppsettingsSingleton.Instance = new();

            AppsettingsSingleton.Instance = JsonConvert.DeserializeObject<AppsettingsSingleton>(jo["AppSettings"].ToString());
            
           

            //Tvingar fram databas, ifall den inte existerar redan.
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    RegCourseDBContext _context = services.GetRequiredService<RegCourseDBContext>();

                    _context.Database.EnsureCreated();
                }
                catch (Exception epicFail)
                {
                    Debug.WriteLine(epicFail.Message);
                }
            }
            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
