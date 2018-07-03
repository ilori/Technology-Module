using System;
using System.Linq;

namespace p11_Equal_Sums__Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var leftSum = 0;
            var rightSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                leftSum = 0;
                for (int j = i; j > 0; j--)
                {
                    var next = j - 1;
                    if (j > 0)
                    {
                        leftSum += numbers[next];
                    }
                }
                rightSum = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    var next = j + 1;
                    if (j < numbers.Length - 1)
                    {
                        rightSum += numbers[next];
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}