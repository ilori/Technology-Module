using System;

namespace p11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfFigure = Console.ReadLine().ToLower();
            switch (typeOfFigure)
            {
                case "triangle":
                    Console.WriteLine("{0:f2}", GetTriangleArea());
                    break;
                case "square":
                    Console.WriteLine("{0:f2}", GetSquareArea());
                    break;
                case "rectangle":
                    Console.WriteLine("{0:f2}", GetRectangleArea());
                    break;
                case "circle":
                    Console.WriteLine("{0:f2}", GetCircleArea());
                    break;
            }
        }

        private static double GetCircleArea()
        {
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * (Math.Pow(radius, 2));
            return area;
        }

        private static double GetRectangleArea()
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());
            var area = sideA * sideB;
            return area;
        }

        private static double GetSquareArea()
        {
            var side = double.Parse(Console.ReadLine());
            var area = Math.Pow(side, 2);
            return area;
        }

        private static double GetTriangleArea()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = (side * height) / 2d;
            return area;
        }
    }
}