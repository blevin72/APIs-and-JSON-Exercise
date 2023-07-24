using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void CurrentWeather()
        {
            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your zipcode");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperials&appid={APIkey}";
            Console.WriteLine();

            Console.WriteLine($"The current temperature is {WeatherMap.GetTemp(apiCall)} degrees F in your location. ");
        }
    }
}
