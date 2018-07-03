using System;
using System.Linq;

namespace p05_Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var finalNums = new double[numbers.Length];
            for (int i = 0; i < finalNums.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    finalNums[i] = Math.Abs(numbers[i] + 0.5);
                    Console.WriteLine($"{numbers[i]} => {Math.Truncate(finalNums[i])}");
                }
                else
                {
                    finalNums[i] = Math.Abs(numbers[i] - 0.5);
                    Console.WriteLine($"{numbers[i]} => -{Math.Truncate(finalNums[i])}");
                }
            }
            
        }
    }
}