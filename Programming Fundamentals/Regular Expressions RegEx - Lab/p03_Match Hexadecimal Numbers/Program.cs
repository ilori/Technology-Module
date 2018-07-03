using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03_Match_Hexadecimal_Numbers
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\b(?:0x)?[0-9A-F]+\b");
            var matches = regex.Matches(input).Cast<Match>().Select(x => x.Value).ToList();
            Console.WriteLine(string.Join(" ",matches));
        }
    }
}