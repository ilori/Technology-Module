using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_Circles_Intersection
{
    class Program
    {
        static void Main()
        {
            var firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point firstCenter = new Point(firstInput[0], firstInput[1]);
            Point secondCenter = new Point(secondInput[0], secondInput[1]);

            Circle firstCircle = new Circle(firstCenter, firstInput[2]);
            Circle secondCircle = new Circle(secondCenter, secondInput[2]);
            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }


    public class Circle
    {
        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public Point Center { get; set; }
        public int Radius { get; set; }


        public static bool Intersect(Circle c1, Circle c2)
        {
            var d = Point.CalculateDistance(c1.Center, c2.Center);
            if (d <= c1.Radius + c2.Radius)
            {
                return true;
            }
            return false;
        }
    }


    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }


        public static int CalculateDistance(Point p1, Point p2)
        {
            return (int) Math.Sqrt(((p1.X - p2.X) * (p1.X - p2.X)) + ((p1.Y - p2.Y) * (p1.Y - p2.Y)));
        }
    }
}