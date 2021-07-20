//using Savitar.Web.Models;
//using System;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Savitar.Web.Services.Data
//{
//    public class WeatherForecastService
//    {
//        private static readonly string[] Summaries = new[]
//        {
//            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//        };

//        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
//        {
//            var rng = new Random();
//            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
//            {
//                Date = startDate.AddDays(index),
//                TemperatureC = rng.Next(-20, 55),
//                Summary = Summaries[rng.Next(Summaries.Length)]
//            }).ToArray());
//        }

//        public Task<Client[]> GetClientsAsync()
//        {
//            return Task.FromResult(ClientsAndProjects.GetAll().ToArray());
//        }

//        public Task<ProjectTechnology[]> GetProjectTechnologies()
//        {
//            return Task.FromResult(Technologies.GetAll().ToArray());
//        }

//        public Task<Service[]> GetServicesAsync()
//        {
//            return Task.FromResult(Data.Services.GetAll().ToArray());
//        }
//    }
//}
