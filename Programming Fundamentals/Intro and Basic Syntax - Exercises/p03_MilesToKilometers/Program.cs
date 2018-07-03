using System;

namespace p03_MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var kilometers = double.Parse(Console.ReadLine()) * 1.60934;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}