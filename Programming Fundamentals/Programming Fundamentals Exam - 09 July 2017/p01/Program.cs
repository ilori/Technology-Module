using System;

namespace p01
{
    class Program
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var m = long.Parse(Console.ReadLine());
            var y = long.Parse(Console.ReadLine());
            var pokes = 0;
            var remainder = n * 0.5;
            while (m <= n)
            {
                n = n - m;
                pokes++;
                if (remainder == n && n != 0 && y != 0)
                {
                    n = n / y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(pokes);
        }
    }
}