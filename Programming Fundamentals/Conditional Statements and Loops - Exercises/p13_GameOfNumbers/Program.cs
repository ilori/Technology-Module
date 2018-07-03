using System;

namespace p13_GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());
            bool isFound = false;
            var combinations = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    if (isFound)
                    {
                        break;
                    }
                    combinations++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicNum}");
                        isFound = true;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        }
    }
}