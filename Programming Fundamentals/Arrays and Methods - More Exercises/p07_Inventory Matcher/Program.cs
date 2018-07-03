using System;
using System.Linq;

namespace p07_Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var productNames = Console.ReadLine().Split(' ').ToArray();
            var quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            var command = Console.ReadLine();
            while (command != "done")
            {
                for (int i = 0; i < productNames.Length; i++)
                {
                    if (command == productNames[i])
                    {
                        Console.WriteLine(
                            $"{productNames[i]} costs: {price[i]}; Available quantity: {quantity[i]}");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}