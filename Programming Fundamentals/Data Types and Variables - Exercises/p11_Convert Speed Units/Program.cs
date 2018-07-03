using System;

namespace p11_Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());
            var timeInHours = hours + minutes / 60f + seconds / 3600f;
            var kilometerPerHour = (distance / 1000f) / timeInHours;
            var metersPerSecond = kilometerPerHour / 3.6f;
            var milesPerHour = (distance / 1609f) / timeInHours;
 
            Console.WriteLine("{0}",metersPerSecond);
            Console.WriteLine("{0}",kilometerPerHour);
            Console.WriteLine("{0}",milesPerHour);
        }
    }
}