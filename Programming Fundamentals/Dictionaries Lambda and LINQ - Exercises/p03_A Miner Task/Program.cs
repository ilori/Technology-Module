using System;
using System.Collections.Generic;
using System.Numerics;

namespace p03_A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, long>();
            var command = Console.ReadLine();
            while (command != "stop")
            {
                var quantity = long.Parse(Console.ReadLine());
                if (!dict.ContainsKey(command))
                {
                    dict[command] = 0;
                }

                dict[command] += quantity;
                command = Console.ReadLine();
            }
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}