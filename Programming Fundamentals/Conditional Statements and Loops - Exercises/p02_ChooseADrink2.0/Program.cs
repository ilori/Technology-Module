using System;

namespace p02_ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var proffesion = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var price = 0.0;
            var drink = String.Empty;
            switch (proffesion)
            {
                case "Athlete":
                    drink = "Water";
                    price = quantity * 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    price = quantity * 1.00;
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    price = quantity * 1.70;
                    break;
                default:
                    drink = "Tea";
                    price = quantity * 1.20;
                    break;
            }
            Console.WriteLine($"The {proffesion} has to pay {price:F2}.");
        }
    }
}