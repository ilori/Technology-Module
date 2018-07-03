using System;
using System.Globalization;
using System.Numerics;

namespace p01_Softuni_Coffee_Orders
{
    class Program
    {
        public static void Main()
        {
            var orderCount = int.Parse(Console.ReadLine());
            var totalMoney = 0m;
            for (int i = 0; i < orderCount; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var date = Console.ReadLine().Split('/');
                var capsuleCount = int.Parse(Console.ReadLine());
                var year = int.Parse(date[2]);
                var month = int.Parse(date[1]);
                var days = DateTime.DaysInMonth(year, month);
                var price = days * pricePerCapsule * capsuleCount;


                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalMoney += price;
            }
            Console.WriteLine($"Total: ${totalMoney:f2}");
        }
    }
}