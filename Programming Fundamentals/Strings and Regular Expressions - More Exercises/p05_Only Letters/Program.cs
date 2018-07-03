using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p05_Only_Letters
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"(\d+)([A-za-z])");
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                input = input.Replace(match.Groups[1].ToString(), match.Groups[2].ToString());
            }
            Console.WriteLine(input);
        }
    }
}