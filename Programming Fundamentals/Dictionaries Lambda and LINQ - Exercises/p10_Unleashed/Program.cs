using System;
using System.Collections.Generic;
using System.Linq;

namespace p10_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalProfit = new Dictionary<string, Dictionary<string, long>>();

            var singerInformation = ReadInformation();

            while (!singerInformation[0].Equals("End"))
            {
                if (!singerInformation[0][singerInformation[0].Length - 1].Equals(' '))
                {
                    singerInformation = ReadInformation();
                }
                else
                {
                    var leftPart = singerInformation[0].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    var rightPart = singerInformation[1].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    var singer = string.Join(" ", leftPart);


                    if (rightPart.Length - 2 > 0)
                    {
                        var cityAsString = new string[rightPart.Length - 2];

                        for (int i = 0; i < cityAsString.Length; i++)
                        {
                            cityAsString[i] = rightPart[i];
                        }

                        int ticketPrice, ticketCount;
                        var profit = 0l;

                        if (int.TryParse(rightPart[rightPart.Length - 1], out ticketCount) &&
                            int.TryParse(rightPart[rightPart.Length - 2], out ticketPrice))
                        {
                            profit = ticketPrice * ticketCount;
                            var newCity = string.Join(" ", cityAsString);
                            AddCity(totalProfit, newCity);
                            AddProfit(totalProfit, newCity, singer, profit);
                            singerInformation = ReadInformation();
                        }
                        else
                        {
                            singerInformation = ReadInformation();
                        }
                    }
                    else
                    {
                        singerInformation = ReadInformation();
                    }
                }
            }

            PrintProfit(totalProfit);
        }

        private static string[] ReadInformation()
        {
            var singerInfo = Console.ReadLine().Split('@').ToArray();
            return singerInfo;
        }

        private static void PrintProfit(Dictionary<string, Dictionary<string, long>> cityProfit)
        {
            foreach (var cityEntry in cityProfit)
            {
                Console.WriteLine(cityEntry.Key);

                foreach (var singerProfit in cityEntry.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singerProfit.Key} -> {singerProfit.Value}");
                }
            }
        }

        private static void AddProfit(Dictionary<string, Dictionary<string, long>> cityProfit, string newCity,
            string singer, long profit)
        {
            if (!cityProfit[newCity].ContainsKey(singer))
            {
                cityProfit[newCity].Add(singer, 0);
            }
            cityProfit[newCity][singer] += profit;
        }

        private static void AddCity(Dictionary<string, Dictionary<string, long>> cityProfit, string newCity)
        {
            if (!cityProfit.ContainsKey(newCity))
            {
                cityProfit.Add(newCity, new Dictionary<string, long>());
            }
        }
    }
}