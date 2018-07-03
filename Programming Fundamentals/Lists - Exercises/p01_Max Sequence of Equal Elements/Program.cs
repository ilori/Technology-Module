using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var lenght = 1;
            var maxLenght = 1;
            var index = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                }
                if (maxLenght < lenght)
                {
                    maxLenght = lenght;
                    index = i;
                }
            }
            var finalIndex = index - maxLenght + 1;
            var finalSequence = new List<int>();
            for (int i = finalIndex; i < index + 1; i++)
            {
                finalSequence.Add(numbers[i]);
            }
            Console.WriteLine(string.Join(" ", finalSequence));
        }
    }
}