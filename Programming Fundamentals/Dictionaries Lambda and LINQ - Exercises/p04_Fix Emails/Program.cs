using System;
using System.Collections.Generic;

namespace p04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            var name = Console.ReadLine();
            while (name != "stop")
            {
                var email = Console.ReadLine();
                if (!email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    dict[name] = email;
                }


                name = Console.ReadLine();
            }
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}