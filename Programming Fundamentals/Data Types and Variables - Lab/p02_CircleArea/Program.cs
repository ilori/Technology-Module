using System;

namespace p02_CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI * r * r:f12}");
        }
    }
}