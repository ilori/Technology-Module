using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace p03_Rage_Quit
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"(\D+)(\d+)");
            var result = new StringBuilder();
            var matches = regex.Match(input);
            while (matches.Success)
            {
                var word = matches.Groups[1].Value.ToUpper();
                var count = int.Parse(matches.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
                matches = matches.NextMatch();
            }
            var uniqueNumbers = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueNumbers}");
            Console.WriteLine($"{result}");
        }
    }
}