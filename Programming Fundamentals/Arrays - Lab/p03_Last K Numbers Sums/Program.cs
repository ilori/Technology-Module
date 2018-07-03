using System;

namespace p03_Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var k = long.Parse(Console.ReadLine());
            var numArray = new long[n];
            numArray[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                var startIndex = Math.Max(0, i - k);

                for (long j = startIndex; j < i; j++)
                {
                    sum += numArray[j];
                }
                numArray[i] = sum;
            }

            Console.WriteLine(string.Join(" ", numArray));
        }
    }
}