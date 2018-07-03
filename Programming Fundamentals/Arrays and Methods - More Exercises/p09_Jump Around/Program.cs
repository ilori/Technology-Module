using System;
using System.Linq;

namespace p09_Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i + numbers[i] <= numbers.Length)
                {
                    sum += numbers[i];
                    i += numbers[i] - 1;
                    continue;
                }
                else if (i - numbers[i] >= 0)
                {
                    sum += numbers[i];
                    i -= numbers[i] + 1;
                    continue;
                }
                else
                {
                    sum += numbers[i];
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}