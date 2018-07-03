using System;

namespace p08_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdd(n));
        }

        static int GetOddSum(int n)
        {
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetEvenSum(int n)
        {
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetMultipleOfEvenAndOdd(int n)
        {
            int sumEvens = GetEvenSum(n);
            int sumOdd = GetOddSum(n);
            return sumEvens * sumOdd;
        }
    }
}