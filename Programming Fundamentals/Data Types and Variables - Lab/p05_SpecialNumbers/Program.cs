using System;

namespace p05_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var sum = 0;
                var digits = i;
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                if (isSpecial)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}