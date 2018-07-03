using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p05_Match_Numbers
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");
            var matces = regex.Matches(input).Cast<Match>().Select(x => x.Value).ToList();

            Console.WriteLine(string.Join(" ",matces));
        }
    }
}