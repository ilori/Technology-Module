using System;

namespace p04_Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = Console.ReadLine();
            var value = double.Parse(Console.ReadLine());
            var finalValue = 0d;
            switch (unit)
            {
                case "miles":
                    finalValue = 1.6 * value;
                    Console.WriteLine($"{value} miles = {finalValue:f2} kilometers");
                    break;
                case "inches":
                    finalValue = 2.54 * value;
                    Console.WriteLine($"{value} inches = {finalValue:f2} centimeters");
                    break;
                case "feet":
                    finalValue = 30d * value;
                    Console.WriteLine($"{value} feet = {finalValue:f2} centimeters");
                    break;
                case "yards":
                    finalValue = 0.91 * value;
                    Console.WriteLine($"{value} yards = {finalValue:f2} meters");
                    break;
                case "gallons":
                    finalValue = 3.8 * value;
                    Console.WriteLine($"{value} gallons = {finalValue:f2} liters");
                    break;
            }
        }
    }
}