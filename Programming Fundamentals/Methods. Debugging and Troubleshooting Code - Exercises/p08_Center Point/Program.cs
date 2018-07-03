using System;
using System.Collections.Generic;

namespace p08_Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var firstDistance = CalculateDistance(x1, y1);
            var secondDistance = CalculateDistance(x2, y2);
            var result = new List<double>();
            if (firstDistance > secondDistance)
            {
                result.Add(x2);
                result.Add(y2);
            }
            else
            {
                result.Add(x1);
                result.Add(y1);
            }
            Console.WriteLine("("  + String.Join(", ",result)+ ")");
        }

        public static double CalculateDistance(double x, double y)
        {
            var distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }
    }
}