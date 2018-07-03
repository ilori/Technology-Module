using System;

namespace p01_Sweet_Dessert
{
    class Program
    {
        public static void Main()
        {
            var moneyAvailable = decimal.Parse(Console.ReadLine());
            var numberOfGuests = decimal.Parse(Console.ReadLine());
            var pricePerBanana = decimal.Parse(Console.ReadLine());
            var pricePerEgg = decimal.Parse(Console.ReadLine());
            var berriesPerKiloPrice = decimal.Parse(Console.ReadLine());
            var totalDishes = Math.Ceiling(numberOfGuests / 6);
            var totalMoneyNeeded = (totalDishes * (2 * pricePerBanana)) + (totalDishes * (4 * pricePerEgg)) +
                                   (totalDishes * (0.2m * berriesPerKiloPrice));
            if (totalMoneyNeeded > moneyAvailable)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalMoneyNeeded-moneyAvailable:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalMoneyNeeded:f2}lv.");
            }
        }
    }
}