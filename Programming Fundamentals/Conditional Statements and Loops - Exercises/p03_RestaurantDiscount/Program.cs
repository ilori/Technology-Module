using System;

namespace p03_RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var hallName = String.Empty;
            var price = 0.0;
            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                price = 2500;
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";
                price = 5000;
            }
            else if (groupSize <= 120)
            {
                hallName = "Great Hall";
                price = 7500;
            }
            if (package == "Normal")
            {
                price += 500;
                price -= price * 0.05;
                price = price / groupSize;
            }
            else if (package == "Gold")
            {
                price += 750;
                price -= price * 0.1;
                price = price / groupSize;
            }
            else if (package == "Platinum")
            {
                price += 1000;
                price -= price * 0.15;
                price = price / groupSize;
            }
            if (hallName == String.Empty)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                
            }
            else
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {price:F2}$");
            }
        }
    }
}