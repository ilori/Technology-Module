using System;

namespace p06_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeCheck();
        }

        private static void PrimeCheck()
        {
            var n = long.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime && n != 0 && n != 1)
            {
                Console.WriteLine("True");
                ;
            }
            else
            {
                Console.WriteLine("False");
                ;
            }
        }
    }
}