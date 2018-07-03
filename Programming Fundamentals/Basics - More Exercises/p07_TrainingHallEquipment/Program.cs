using System;

namespace p07_TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var itemsToBuy = int.Parse(Console.ReadLine());
            var subTotal = 0d;
            for (int i = 0; i < itemsToBuy; i++)
            {
                var itemsName = Console.ReadLine();
                var itemsPrice = double.Parse(Console.ReadLine());
                var itemsQuantity = int.Parse(Console.ReadLine());
                if (itemsQuantity > 1)
                {
                    Console.WriteLine($"Adding {itemsQuantity} {itemsName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemsQuantity} {itemsName} to cart.");
                }
                subTotal+=itemsPrice * itemsQuantity;
            }
            Console.WriteLine($"Subtotal: ${subTotal:f2}");
            if (subTotal <= budget)
            {
                Console.WriteLine("Money left: ${0:f2}",Math.Abs(subTotal-budget));
            }
            else
            {
                Console.WriteLine("Not enough. We need ${0:f2} more.",Math.Abs(subTotal-budget));
            }
        }
    }
}