using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p05_Key_Replacer
{
    class Program
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine().Split(new[] {'<', '\\', '|'}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var secondInput = Console.ReadLine();
            var keyStart = firstInput[0];
            var keyEnd = firstInput[2];

            var regex = new Regex($@"({keyStart})(.*?)?({keyEnd})");
            var matches = regex.Matches(secondInput);
            var result = string.Empty;
            foreach (Match match in matches)
            {
                result += match.Groups[2].ToString();
            }
            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}