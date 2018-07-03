using System;

namespace p01_CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());
            var years = centuries * 100;
            var days = (int) (years * 365.2422);
            var hours = 24 * days;
            var minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}