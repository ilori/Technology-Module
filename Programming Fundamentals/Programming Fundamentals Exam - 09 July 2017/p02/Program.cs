using System;
using System.Linq;

namespace p02
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var totalSum = 0L;
            while (numbers.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());
                var currentValue = 0;
                if (index < 0)
                {
                    var lastElement = numbers[numbers.Count - 1];
                    currentValue = numbers[0];
                    numbers[0] = lastElement;
                }
                else if (index >= numbers.Count)
                {
                    var firstElement = numbers[0];
                    currentValue = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = firstElement;
                }
                else
                {
                    currentValue = numbers[index];
                    numbers.RemoveAt(index);
                }
                totalSum += currentValue;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= currentValue)
                    {
                        numbers[i] += currentValue;
                    }
                    else
                    {
                        numbers[i] -= currentValue;
                    }
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}