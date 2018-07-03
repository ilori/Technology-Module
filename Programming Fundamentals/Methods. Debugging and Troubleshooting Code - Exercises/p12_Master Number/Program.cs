using System;
using System.IO;

namespace p12_Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if (IsSymmetric(i) && SumOfDigits(i) % 7 == 0 && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int input)
        {
            var text = input.ToString();
            for (int i = 0; i < text.Length; i++)
            {
                int digit = text[i] - '0';
                if (digit % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static int SumOfDigits(int input)
        {
            var sum = 0;
            while (input > 0)
            {
                sum += input % 10;
                input /= 10;
            }
            return sum;
        }

        private static bool IsSymmetric(int input)
        {
            var text = input.ToString();
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}