using System;

namespace p03_ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                var userNum = decimal.Parse(Console.ReadLine());
                sum += userNum;
            }
            Console.WriteLine(sum);
        }
    }
}