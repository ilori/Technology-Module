using System;
using System.Linq;

namespace p02_Email_me
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('@').ToList();
            var firstWord = input[0];
            var secondWord = input[1];
            var sum = 0;
            foreach (var letter in firstWord)
            {
                sum += letter;
            }
            foreach (var letter in secondWord)
            {
                sum -= letter;
            }
            if (sum >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}