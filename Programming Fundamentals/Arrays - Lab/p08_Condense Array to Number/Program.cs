using System;
using System.Linq;

namespace p08_Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            while (numbers.Length > 1)
            {
                var finalNums = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    finalNums[i] = numbers[i] + numbers[i + 1];
                }
                numbers = finalNums;
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}