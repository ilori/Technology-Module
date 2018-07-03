using System;
using System.Text.RegularExpressions;

namespace p04_Match_Dates
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\b(\d{2})([\.\-\/])([A-Z][a-z]{2})\2(\d{4})\b");
            var match = regex.Matches(input);

            foreach (Match m in match)
            {
                Console.WriteLine($"Day: {m.Groups[1]}, Month: {m.Groups[3]}, Year: {m.Groups[4]}");
            }
        }
    }
}