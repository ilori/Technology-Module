using System;
using System.Numerics;

namespace p14_Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            Console.WriteLine(ZeroesCount(GetFactorial(n)));
        }

        private static int ZeroesCount(BigInteger getFactorial)
        {
            var zeroesCount = 0;
            while (getFactorial % 10 == 0)
            {
                getFactorial /= 10;
                zeroesCount++;
            }
            return zeroesCount;
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