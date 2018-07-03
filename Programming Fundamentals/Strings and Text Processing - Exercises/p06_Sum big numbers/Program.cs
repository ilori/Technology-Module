using System;
using System.Linq;
using System.Text;

namespace p06_Sum_big_numbers
{
    class Program
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart('0');
            var secondNumber = Console.ReadLine().TrimStart('0');

            if (firstNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }
            else
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }

            byte currentNumber = 0;
            var finalResult = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                var sum = (byte) (byte.Parse(firstNumber[i].ToString()) + byte.Parse(secondNumber[i].ToString()) +
                                  currentNumber);
                currentNumber = (byte) (sum / 10);
                var remainder = (byte) (sum % 10);
                finalResult.Append(remainder);
                if (i == 0 && currentNumber != 0)
                {
                    finalResult.Append(currentNumber);
                }
            }

            var result = finalResult.ToString().ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(new string(result));
        }
    }
}