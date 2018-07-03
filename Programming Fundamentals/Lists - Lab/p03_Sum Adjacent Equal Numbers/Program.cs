using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var sum = 0d;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    sum = numbers[i] + numbers[i - 1];
                    numbers.RemoveAt(i - 1);
                    numbers.RemoveAt(i - 1);
                    numbers.Insert(i-1,sum);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}