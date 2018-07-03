using System;

namespace p01_ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var proffesion = Console.ReadLine();
            var drink = String.Empty;
            switch (proffesion)
            {
                case "Athlete":
                    drink = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    break;
                default:
                    drink = "Tea";
                    break;
            }
            Console.WriteLine($"{drink}");
        }
    }
}