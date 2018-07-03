using System;
using System.Numerics;

namespace p13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorial(n));
        }

        private static BigInteger GetFactorial(double d)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= d; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}