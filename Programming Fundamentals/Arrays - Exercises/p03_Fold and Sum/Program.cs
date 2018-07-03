using System;
using System.Linq;

namespace p03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var n = numbers.Length / 4;
            var innerNumbers = new int[2 * n];
            var outerNumbers = new int[2 * n];
            var sum = new int[2 * n];
            for (int i = 0; i < 2 * n; i++)
            {
                innerNumbers[i] = numbers[i + n];
            }
            for (int i = 0; i < n; i++)
            {
                outerNumbers[i] = numbers[n - 1 - i];
                outerNumbers[i + n] = numbers[numbers.Length - 1 - i];
            }
            for (int i = 0; i < 2 * n; i++)
            {
                sum[i] = innerNumbers[i] + outerNumbers[i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}