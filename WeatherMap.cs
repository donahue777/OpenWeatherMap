using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMap
{
    public class WeatherMap
    {
        public static double GetTemp(string APICall)
        {
            HttpClient client = new HttpClient();

            string response = client.GetStringAsync(APICall).Result;

            double temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            return temp;
        }
    }
}
