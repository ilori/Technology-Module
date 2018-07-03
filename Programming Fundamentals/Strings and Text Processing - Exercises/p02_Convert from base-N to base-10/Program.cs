using System;
using System.Linq;
using System.Numerics;

namespace p02_Convert_from_base_N_to_base_10
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();

            var firstNumber = numbers[0];
            var secondNumber = numbers[1];
            var index = 0;
            BigInteger finalResult = 0;
            while (secondNumber > 0)
            {
                var remainder = secondNumber % 10;
                var multiplier = remainder * MathPow(firstNumber, index);
                finalResult += multiplier;
                secondNumber /= 10;
                index++;
            }
            Console.WriteLine(finalResult);
        }

        private static BigInteger MathPow(BigInteger baseN, BigInteger index)
        {
            BigInteger number = 1;

            for (int i = 0; i < index; i++)
            {
                number = number * baseN;
            }
            return number;
        }
    }
}