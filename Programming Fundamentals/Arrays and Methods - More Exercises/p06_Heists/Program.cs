using System;
using System.Linq;

namespace p06_Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var jewelGoldPrice = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long profit = 0;
            long expences = 0;
            var token = string.Empty;
            var command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "Jail" && command[1] != "Time")
            {
                token = command[0];
                for (int i = 0; i < token.Length; i++)
                {
                    if (token[i] == '%')
                    {
                        profit += jewelGoldPrice[0];
                    }
                    if (token[i] == '$')
                    {
                        profit += jewelGoldPrice[1];
                    }
                }
                expences += long.Parse(command[1]);
                command = Console.ReadLine().Split(' ');
            }
            if (profit >= expences)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {Math.Abs(profit - expences)}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(profit - expences)}.");
            }
        }
    }
}