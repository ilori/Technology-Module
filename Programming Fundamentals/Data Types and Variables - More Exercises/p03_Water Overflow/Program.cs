using System;

namespace p03_Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var limit = 0;
            for (int i = 0; i < n; i++)
            {
                var litersQuantity = int.Parse(Console.ReadLine());
                limit += litersQuantity;
                if (limit > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    limit -= litersQuantity;
                }
            }
            Console.WriteLine(limit);
        }
    }
}