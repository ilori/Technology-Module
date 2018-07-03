using System;

namespace p03_BackInThirtyMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine()) + 30;
            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours -= 24;
            }
            if (minutes >= 10)
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
        }
    }
}