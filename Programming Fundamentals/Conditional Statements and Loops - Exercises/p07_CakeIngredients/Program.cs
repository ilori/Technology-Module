using System;

namespace p07_CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            int count = 0;
            while (command != "Bake!")
            {

                count++;
                Console.WriteLine($"Adding ingredient {command}.");
                command = Console.ReadLine();

            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}