using System;
using System.Globalization;

namespace p01_Sino_The_Walker
{
    class Program
    {
        public static void Main()
        {
            var leavingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var numberOfSteps = double.Parse(Console.ReadLine()) % 86400;
            var timeInSeconds = double.Parse(Console.ReadLine()) % 86400;
            var totalTime = leavingTime.AddSeconds(numberOfSteps * timeInSeconds);
            Console.WriteLine($"Time Arrival: {totalTime:HH:mm:ss}");
        }
    }
}