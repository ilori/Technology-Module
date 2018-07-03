using System;
using System.Numerics;

namespace p03_Big_Factorial
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }

        private static BigInteger Factorial(int i)
        {
            BigInteger factorial = 1;
            for (int j = i; j > 0; j--)
            {
                factorial *= j;
            }
            return factorial;
        }
    }
}