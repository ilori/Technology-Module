using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var currentPoint = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                points.Add(new Point(currentPoint[0], currentPoint[1]));
            }
            var minDiff = double.MaxValue;
            Point firstPointMax = null;
            Point secondPointMax = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];
                    var currentDicstance = CalculateDifference(firstPoint, secondPoint);

                    if (currentDicstance < minDiff)
                    {
                        minDiff = currentDicstance;
                        firstPointMax = firstPoint;
                        secondPointMax = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDiff:f3}");
            Console.WriteLine($"({firstPointMax.X}, {firstPointMax.Y})");
            Console.WriteLine($"({secondPointMax.X}, {secondPointMax.Y})");
        }

        public static double CalculateDifference(Point firstPoint, Point secondPoint)
        {
            var firstPointDiff = firstPoint.X - secondPoint.X;
            var secondPointDiff = firstPoint.Y - secondPoint.Y;

            var firstPointPow = Math.Pow(firstPointDiff, 2);
            var secondPointPow = Math.Pow(secondPointDiff, 2);
            var result = Math.Sqrt(firstPointPow + secondPointPow);
            return result;
        }
    }


    
}