using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {

        public static void WeatherforCity()
        {
            {
                 //Set up Configuration
                 var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                 IConfigurationRoot configuration = builder.Build();

                string apiKey = configuration.GetSection("AppSettings")["ApiKey"];
                var client = new HttpClient();
                Console.WriteLine("Enter in a city: ");
                var cityName = Console.ReadLine();

                //end point from documentation $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
                var weatherMapURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
                string weatherResponse = client.GetStringAsync(weatherMapURL).Result;
                JObject weatherObject = JObject.Parse(weatherResponse);
                Console.WriteLine($"It is {weatherObject["main"]["temp"]} degrees Fahrenheit in {cityName}");
            
            }

        }
    }
}
