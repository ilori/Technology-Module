using System;

namespace p09_Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var lengthOfFirstPair = LenghtOfLine(x1, y1, x2, y2);
            var lengthOfSecondPair = LenghtOfLine(x3, y3, x4, y4);
            var result = String.Empty;
            if (lengthOfFirstPair >= lengthOfSecondPair)
            {
                result = ClosestPointToCenter(x1, y1, x2, y2);
                Console.WriteLine(result);
            }
            else
            {
                result = ClosestPointToCenter(x3, y3, x4, y4);
                Console.WriteLine(result);
            }
        }

        static double LenghtOfLine(double x1, double y1, double x2, double y2)
        {
            var xDifference = Math.Abs(x1 - x2);
            var yDifference = Math.Abs(y1 - y2);
            var line = Math.Sqrt(Math.Pow(xDifference, 2) + Math.Pow(yDifference, 2));
            return line;
        }

        static string ClosestPointToCenter(double x1, double y1, double x2, double y2)
        {
            var coordinates = String.Empty;
            if (Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(x2, 2) + Math.Pow(y2, 2))
            {
                coordinates = $"({x1}, {y1})({x2}, {y2})";
            }
            else
            {
                coordinates = $"({x2}, {y2})({x1}, {y1})";
            }
            return coordinates;
        }
    }
}