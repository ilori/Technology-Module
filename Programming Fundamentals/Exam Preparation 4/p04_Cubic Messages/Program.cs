using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_Cubic_Messages
{
    class Program
    {
        public static void Main()
        {
            var regex = new Regex(@"^(\d+)([a-zA-Z]+)([^a-zA-Z]*)$");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }
                var n = int.Parse(Console.ReadLine());
                var match = regex.Match(input);
                var firstNumbers = match.Groups[1].Value;
                var message = match.Groups[2].Value;
                var secondNumbers = match.Groups[3].Value;
                if (message.Length == n)
                {
                    var verification = new string((firstNumbers + secondNumbers).Where(char.IsDigit)
                        .Select(x => int.Parse(x.ToString()))
                        .Select(x => x >= 0 && x < message.Length ? message[x] : ' ').ToArray()
                    );


                    Console.WriteLine($"{message} == {verification}");
                }
            }
        }
    }
}