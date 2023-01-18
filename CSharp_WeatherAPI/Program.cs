
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CSharp_WeatherAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter city name: ");
            string CityName = Console.ReadLine();
            WeatherInfo(CityName);
            //string CityName = "Baku";
            //GetWeatherIfno(CityName);
        }

        static string GetWeatherIfno(string cityName)
        {
            string URL = "https://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&appid=PrivateKey";
            WebClient client = new WebClient();
            return client.DownloadString(URL);
            //Console.WriteLine(URL);
        }
        static void WeatherInfo(string JSONurl)
        {
            JObject weather = JObject.Parse(JSONurl);
            Console.WriteLine("Temperature: " + weather["main"]["temp"] + "K");
        }
    }
}