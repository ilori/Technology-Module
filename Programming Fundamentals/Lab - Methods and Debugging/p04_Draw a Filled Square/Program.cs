using System;

namespace p04_Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintFooterRow(n);
        }

        private static void PrintFooterRow(int n)
        {
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine(new string('-', 2 * n));
            }
        }

        private static void PrintMiddleRow(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        private static void PrintHeaderRow(int n)
        {
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine(new string('-', 2 * n));
            }
        }
    }
}