using System;

namespace p04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;
            if (month == "May" || month == "October")
            {
                studioPrice = 50.0 * nights;
                doublePrice = 65.0 * nights;
                suitePrice = 75.0 * nights;
                if (nights > 7 && month == "October")
                {
                    studioPrice -= 50;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60.0 * nights;
                doublePrice = 72.0 * nights;
                suitePrice = 82.0 * nights;
                if (nights > 7 && month == "September")
                {
                    studioPrice -= 60;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68.0 * nights;
                doublePrice = 77.0 * nights;
                suitePrice = 89.0 * nights;
            }
            if (nights > 7 && (month == "May" || month == "October"))
            {
                studioPrice -= studioPrice * 0.05;
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                doublePrice -= doublePrice * 0.1;
            }
            else if (nights > 14 && (month == "July" || month == "August" || month == "December"))
            {
                suitePrice -= suitePrice * 0.15;
            }
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");
        }
    }
}