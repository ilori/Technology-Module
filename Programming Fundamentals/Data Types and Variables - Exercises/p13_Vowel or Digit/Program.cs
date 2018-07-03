using System;

namespace p13_Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = char.Parse(Console.ReadLine());
            bool isVowel = "aeiouAEIOU".IndexOf(input) >= 0;
            if (isVowel)
            {
                Console.WriteLine("vowel");
            }else if (input >= 48 && input <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}