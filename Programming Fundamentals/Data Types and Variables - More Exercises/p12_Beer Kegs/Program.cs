using System;

namespace p12_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var biggestKeg = string.Empty;
            var biggest = decimal.MinValue;
            for (int i = 0; i < n; i++)
            {
                var model = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                var area = (decimal) (Math.PI * Math.Pow(radius, 2) * height);
                if (area > biggest)
                {
                    biggestKeg = model;
                    biggest = area;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}