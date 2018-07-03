using System;
using System.Collections.Generic;
using System.Linq;

namespace p09_Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            TypeOfArray(numbers);
        }

        private static void TypeOfArray(int[] numbers)
        {
            var n = numbers.Length;
            if (n == 1)
            {
                One(numbers);
            }
            else if (n % 2 == 0)
            {
                Even(numbers);
            }
            else
            {
                Odd(numbers);
            }
        }

        private static void Odd(int[] numbers)
        {
            Console.WriteLine(
                $"{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}, {numbers[numbers.Length / 2 + 1]}");
        }

        private static void Even(int[] numbers)
        {
            Console.WriteLine($"{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}");
        }

        private static void One(int[] numbers)
        {
            Console.WriteLine(numbers[0]);
        }
    }
}