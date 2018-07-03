using System;
using System.Text.RegularExpressions;

namespace p01_Extract_Emails
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"(?<=\s)[a-z0-9]+([.-]\w*)*@[a-z]+([.-]\w*)*(\.[a-z]+)");
            var match = regex.Matches(input);

            foreach (var m in match)
            {
                Console.WriteLine(m);
            }
        }
    }
}