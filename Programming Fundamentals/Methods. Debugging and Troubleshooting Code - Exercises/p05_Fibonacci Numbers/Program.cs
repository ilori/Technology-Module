using System;

namespace p05_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("1");
                return;
            }
            else if (number == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(Fibonaccinumber(number));
            }
        }

        private static int Fibonaccinumber(int number)
        {
            int a = 1;
            int b = 1;
            int c;
            for (int i = 2; i <= number; i++)
            {
                c = a + b;
                a = b;
                b = c;
                if (i == number)
                {
                    return c;
                }
            }
            return 0;
        }
    }
}