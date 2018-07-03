using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}