using System;
using System.Linq;

namespace p06_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = numbers.Length / 4;
            var firstLeftRow = numbers.Take(k).Reverse().ToArray();
            var firstRightRow = numbers.Reverse().Take(k).ToArray();
            var firstRow = firstLeftRow.Concat(firstRightRow);
            var secondRow = numbers.Skip(k).Take(2 * k).ToArray();
            var sum = firstRow.Select((x, index) => x + secondRow[index]);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}