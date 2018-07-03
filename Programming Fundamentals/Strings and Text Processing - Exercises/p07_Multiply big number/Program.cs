using System;
using System.Text;

namespace p07_Multiply_big_number
{
    class Program
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart('0');
            var secondNumber = byte.Parse(Console.ReadLine());

            if (firstNumber == "0" || secondNumber == 0 || firstNumber == "")
            {
                Console.WriteLine(0);
                return;
            }

            byte currentNumber = 0;
            var result = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                var product = (byte) (byte.Parse(firstNumber[i].ToString()) * secondNumber + currentNumber);
                currentNumber = (byte) (product / 10);
                var remainder = (byte) (product % 10);
                result.Append(remainder);
                if (i == 0 && currentNumber != 0)
                {
                    result.Append(currentNumber);
                }
            }

            var finalResult = result.ToString().ToCharArray();
            Array.Reverse(finalResult);
            Console.WriteLine(new string(finalResult));
        }
    }
}