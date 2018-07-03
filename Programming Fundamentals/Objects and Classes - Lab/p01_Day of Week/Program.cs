using System;
using System.Globalization;

namespace p01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dateTime = DateTime.ParseExact(input,"d-M-yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine(dateTime.DayOfWeek);
        }
    }
}