using System;
using System.Text.RegularExpressions;

namespace p03PhoenixGrid
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"^([^_\s]{3}\.)*[^_\s]{3}$");

            while (input != "ReadMe")
            {
                if (regex.Match(input).Success && isPalindrome(input))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                input = Console.ReadLine();
            }
        }

        private static bool isPalindrome(string input)
        {
            var i = 0;
            var k = input.Length - 1;
            while (true)
            {
                if (i > k)
                {
                    return true;
                }
                var a = input[i];
                var b = input[k];
                if (a != b)
                {
                    return false;
                }
                i++;
                k--;
            }
        }
    }
}