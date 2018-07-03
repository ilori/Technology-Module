using System;

namespace p12_TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var boundaryNum = int.Parse(Console.ReadLine());
            var sum = 0;
            var combinations = 0;
            for (int i = firstNum; i >= 1; i--)
            {
                for (int j = 1; j <= secondNum ; j++)
                {
                    if (sum >= boundaryNum)
                    {
                        break;
                    }
                    sum += 3 * (i * j);
                    combinations++;
                }
            }
            if (sum >= boundaryNum)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum} >= {boundaryNum}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}