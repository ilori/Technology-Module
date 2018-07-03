using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_Population_Counter
{
    class Program
    {
        public static void Main(string[] args)
        {
            var countryAndPopulation = new Dictionary<string, Dictionary<string, double>>();

            var input = Console.ReadLine().Split('|').ToList();
            while (input[0] != "report")
            {
                var country = input[1];
                var city = input[0];
                var population = double.Parse(input[2]);

                if (!countryAndPopulation.ContainsKey(country))
                {
                    countryAndPopulation.Add(country, new Dictionary<string, double>());
                }

                if (!countryAndPopulation[country].ContainsKey(city))
                {
                    countryAndPopulation[country].Add(city, population);
                }
                input = Console.ReadLine().Split('|').ToList();
            }

            var orderedCountries = countryAndPopulation.OrderByDescending(c => c.Value.Values.Sum());

            foreach (var country in orderedCountries)
            {
                var orderedCities = country.Value.OrderByDescending(c => c.Value);
                Console.WriteLine("{0} (total population: {1})", country.Key, country.Value.Sum(c => c.Value));
                foreach (var city in orderedCities)
                {
                    Console.WriteLine("=>" + city.Key + ": " + city.Value);
                }
            }
        }
    }
}