using System;
using System.Text.RegularExpressions;

namespace p07_Hideout
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (true)
            {
                var command = Console.ReadLine().Split();
                var regex = new Regex($@"\{command[0]}{{{command[1]},}}");
                var match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine(
                        $"Hideout found at index {input.IndexOf(match.Value, StringComparison.Ordinal)} and it is with size {match.Value.Length}!");
                    break;
                }
            }
        }
    }
}