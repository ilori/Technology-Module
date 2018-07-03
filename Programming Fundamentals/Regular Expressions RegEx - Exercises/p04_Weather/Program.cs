using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_Weather
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var results = new Dictionary<string, Weather>();
            while (input != "end")
            {
                var regex = new Regex(@"([A-Z]{2})(\d+.\d+)([A-z]+)\b\|");
                var matches = regex.Matches(input);
                var countryCode = string.Empty;
                var avarageTemperature = 0d;
                var typeOfWeather = string.Empty;

                foreach (Match match in matches)
                {
                    countryCode = match.Groups[1].ToString();
                    var temp = match.Groups[2].ToString();
                    avarageTemperature = double.Parse(temp);
                    typeOfWeather = match.Groups[3].ToString();
                }
                if (results.ContainsKey(countryCode))
                {
                    results[countryCode].AvarageTemperature = avarageTemperature;
                    results[countryCode].TypeOfWeater = typeOfWeather;
                }
                if (!results.ContainsKey(countryCode) && countryCode != "")
                {
                    results[countryCode] = new Weather();
                    results[countryCode].AvarageTemperature = avarageTemperature;
                    results[countryCode].TypeOfWeater = typeOfWeather;
                }

                input = Console.ReadLine();
            }
            foreach (var weather in results.OrderBy(x => x.Value.AvarageTemperature))
            {
                Console.WriteLine(
                    $"{weather.Key} => {weather.Value.AvarageTemperature:f2} => {weather.Value.TypeOfWeater}");
            }
        }
    }

    public class Weather
    {
        public double AvarageTemperature { get; set; }
        public string TypeOfWeater { get; set; }
    }
}