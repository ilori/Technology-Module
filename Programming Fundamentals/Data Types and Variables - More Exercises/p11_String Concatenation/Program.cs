using System;

namespace p11_String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = char.Parse(Console.ReadLine());
            var oddOrEven = Console.ReadLine();
            var times = int.Parse(Console.ReadLine());
            var finalWord = string.Empty;
            for (int i = 1; i <= times; i++)
            {
                var name = Console.ReadLine();
                if (oddOrEven == "odd")
                {
                    if (i % 2 != 0)
                    {
                        finalWord += name + firstChar;
                    }
                }
                else if (oddOrEven == "even")
                {
                    if (i % 2 == 0)
                    {
                        finalWord += name + firstChar;
                    }
                }
            }

            Console.WriteLine($"{finalWord.Remove(finalWord.Length-1)}");
        }
    }
}