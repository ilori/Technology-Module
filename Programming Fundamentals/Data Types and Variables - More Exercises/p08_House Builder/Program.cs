using System;
using System.Numerics;

namespace p08_House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            var secondNum = BigInteger.Parse(Console.ReadLine());
            BigInteger total = 0;
            if (firstNum >= sbyte.MinValue && firstNum <= sbyte.MaxValue)
            {
                total = (firstNum * 4) + (secondNum * 10);
            }
            else
            {
                total = secondNum * 4 + firstNum * 10;
            }
            Console.WriteLine(total);
        }
    }
}