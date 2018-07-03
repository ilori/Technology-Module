using System;
using System.Text.RegularExpressions;

namespace p03Trainegram
{
    class Program
    {
        static void Main()
        {
            var regex = new Regex(@"^(<\[[^a-zA-Z0-9]*\]\.)(\.\[[a-zA-Z0-9]*\]\.)*?$");
            var input = Console.ReadLine();

            while (input != "Traincode!")
            {
                if (regex.Match(input).Success)
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}