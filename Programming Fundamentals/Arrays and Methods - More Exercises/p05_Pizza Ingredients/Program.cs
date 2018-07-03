using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaIngrediants = Console.ReadLine().Split();
            var searchLenght = int.Parse(Console.ReadLine());
            var word = string.Empty;
            var count = 0;
            var finalPizzaIngrediants = new List<string>();
            for (int i = 0; i < pizzaIngrediants.Length; i++)
            {
                word = pizzaIngrediants[i];
                if (word.Length == searchLenght)
                {
                    Console.WriteLine($"Adding {word}.");
                    count++;
                    finalPizzaIngrediants.Add(word);
                    if (finalPizzaIngrediants.Count == 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", finalPizzaIngrediants)}.");
        }
    }
}