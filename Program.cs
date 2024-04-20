using Newtonsoft.Json.Linq;
using System;

namespace OpenWeatherMap
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");

            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your zipcode");
            
            string zipCode = Console.ReadLine();

            string APICall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

            Console.WriteLine();

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(APICall)} degrees fahrenheit in your location.");
        }
    }
}