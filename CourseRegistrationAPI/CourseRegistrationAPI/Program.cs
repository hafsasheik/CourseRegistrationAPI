using CourseRegistrationAPI.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
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
            AppsettingsSingleton.Instance = JsonConvert.DeserializeObject<AppsettingsSingleton>(jo["Appsettings"].ToString());
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
