using System;

namespace p03_MegaPixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var megaPixels = Math.Round(width * height / 1000000.0,1);
            Console.WriteLine($"{width}x{height} => {megaPixels}MP");
        }
    }
}