using System;
using System.Linq;
using System.Numerics;

namespace p01_Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var min = numbers.Min();
            var max = numbers.Max();
            var sum = numbers.Sum();
            var average = numbers.Average();
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}