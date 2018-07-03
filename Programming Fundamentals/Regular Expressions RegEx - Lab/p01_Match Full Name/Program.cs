using System;
using System.Text.RegularExpressions;

namespace p01_Match_Full_Name
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            var match = regex.Matches(input);

            foreach (var m in match)
            {
                Console.Write(m + " ");
            }
        }
    }
}