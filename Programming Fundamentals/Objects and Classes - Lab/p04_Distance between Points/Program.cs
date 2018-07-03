using System;
using System.Linq;

namespace p04_Distance_between_Points
{
    class Program
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        static void Main(string[] args)
        {
            var firstPointXY = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var firstPoint = new Point(firstPointXY[0], firstPointXY[1]);
            var secondPointXY = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var secondPoint = new Point(secondPointXY[0], secondPointXY[1]);

            var result = CalculateDifference(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");
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