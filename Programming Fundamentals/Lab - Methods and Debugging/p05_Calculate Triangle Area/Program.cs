using System;

namespace p05_Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetTriangleArea(width,height));
        }

        private static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}