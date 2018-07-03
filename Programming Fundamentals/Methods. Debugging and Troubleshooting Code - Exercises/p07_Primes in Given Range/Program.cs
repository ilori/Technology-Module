using System;
using System.Collections.Generic;

namespace p07_Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var stopNum = int.Parse(Console.ReadLine());
            var numbers = String.Join(", ", GetPrimeNumbers(startNum, stopNum).ToArray());
            Console.WriteLine(numbers);
        }

        private static List<int> GetPrimeNumbers(int startNum, int stopNum)
        {
            var result = new List<int>();
            for (int i = startNum; i <= stopNum; i++)
            {
                var isPrime = !(i < 2);
                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}