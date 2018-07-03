using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var number = 0;
            var sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                number = numbers[i].ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');
                sum += number;
                number = 0;
            }
            Console.WriteLine(sum);
        }
    }
}