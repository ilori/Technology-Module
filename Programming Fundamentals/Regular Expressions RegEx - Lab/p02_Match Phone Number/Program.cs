using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p02_Match_Phone_Number
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"\+\b([359]{3})\b([ |\-])(2)\2(\d{3})\2(\d){4}\b");

            var match = regex.Matches(input).Cast<Match>().Select(x => x.Value.Trim()).ToList();

            Console.WriteLine(string.Join(", ", match));
        }
    }
}