using System;
using System.Linq;

namespace p07_Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sumNumbers = new int[Math.Max(firstNumbers.Length, secondNumbers.Length)];
            for (int i = 0; i < sumNumbers.Length; i++)
            {
                sumNumbers[i] = firstNumbers[i % firstNumbers.Length] + secondNumbers[i % secondNumbers.Length];
            }
            foreach (var number in sumNumbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}