using System;

namespace p10_Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var firstChar = char.Parse(Console.ReadLine());
                sum += firstChar;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}