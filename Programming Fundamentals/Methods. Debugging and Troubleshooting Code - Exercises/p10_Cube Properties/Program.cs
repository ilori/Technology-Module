using System;

namespace p10_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            if (type == "face")
            {
                GetFace(side);
            }
            else if (type == "space")
            {
                GetSpace(side);
            }
            else if (type == "volume")
            {
                GetVolume(side);
            }
            else if (type == "area")
            {
                GetArea(side);
            }
        }

        private static void GetArea(double side)
        {
            Console.WriteLine("{0:f2}", 6 * Math.Pow(side, 2));
        }

        private static void GetVolume(double side)
        {
            Console.WriteLine("{0:f2}", Math.Pow(side, 3));
        }

        private static void GetSpace(double side)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(3 * Math.Pow(side, 2)));
        }

        private static void GetFace(double side)
        {
            Console.WriteLine("{0:f2}",Math.Sqrt(2 * Math.Pow(side,2)));
        }
    }
}