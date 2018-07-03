using System;

namespace p01Resurrection
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var totalLenght = (decimal) Math.Pow(long.Parse(Console.ReadLine()), 2);
                var totalWidth = decimal.Parse(Console.ReadLine());
                var wingLenght = long.Parse(Console.ReadLine());

                var totalYears = totalLenght * (totalWidth + 2 * wingLenght);

                Console.WriteLine(totalYears);
            }
        }
    }
}