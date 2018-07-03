using System;
using System.Linq;

namespace p08_Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var productNames = Console.ReadLine().Split(' ').ToArray();
            var quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            var command = Console.ReadLine().Split(' ');
            var totalSum = 0m;
            var quantityLeft = 0L;
            var count = 0;
            while (command[0] != "done")
            {
                for (int i = 0; i < quantity.Length; i++)
                {
                    if (command[0] == productNames[i] && quantity[i] > 0 && long.Parse(command[1]) <= quantity[i])
                    {
                        totalSum = decimal.Parse(command[1]) * price[i];
                        quantityLeft = quantity[i];
                        quantityLeft -= long.Parse(command[1]);
                        quantity[i] = quantityLeft;
                        count++;
                        Console.WriteLine($"{productNames[i]} x {command[1]} costs {totalSum:f2}");
                        
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine($"We do not have enough {command[0]}");
                }
                count = 0;
                quantityLeft = 0L;
                totalSum = 0m;
                command = Console.ReadLine().Split(' ');
            }
        }
    }
}