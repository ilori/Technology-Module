using System;
using System.Linq;

namespace p06_Rectangle_Position
{
    class Program
    {
        static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();
            Console.WriteLine(IsInside(firstRectangle, secondRectangle) ? "Inside" : "Not Inside");
        }


        public static Rectangle ReadRectangle()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rectangle = new Rectangle(input[0], input[1], input[2], input[3]);
            return rectangle;
        }

        public static bool IsInside(Rectangle first, Rectangle second)
        {
            var left = first.Left >= second.Left;
            var right = first.Right <= second.Right;
            var top = first.Top <= second.Top;
            var bottom = first.Bottom >= second.Bottom;

            return left && right && top && bottom;
        }
    }

    
}