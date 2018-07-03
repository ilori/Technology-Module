using System;
using System.Collections.Generic;

namespace p01_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ');
            var counts = new SortedDictionary<double, int>();
            foreach (var num in nums)
            {
                var parsed = double.Parse(num);
                if (counts.ContainsKey(parsed))
                {
                    counts[parsed]++;
                }
                else
                {
                    counts[parsed] = 1;
                }
            }
            foreach (var num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");   
            }
        }
    }
}