using System;
using System.Linq;
using System.Numerics;

namespace p01_Convert_from_base_10_to_base_N
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            var firstNum = numbers[0];
            var secondNum = numbers[1];
            var finalResult = string.Empty;
            if (firstNum >= 2 && firstNum <= 10)
            {
                while (secondNum > 0)
                {
                    var remainder = secondNum % firstNum;
                    secondNum /= firstNum;

                    finalResult += remainder.ToString();
                }
                Console.WriteLine(string.Join("", finalResult.Reverse()));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}