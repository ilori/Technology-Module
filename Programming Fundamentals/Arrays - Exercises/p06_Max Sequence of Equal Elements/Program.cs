using System;
using System.IO;
using System.Linq;

namespace p06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var lenght = 1;
            var maxLenght = 1;
            var start = 0;
            var word = string.Empty;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    lenght++;
                    if (maxLenght < lenght)
                    {
                        maxLenght = lenght;
                        start = i;
                    }
                }
                else
                {
                    lenght = 1;
                }
            }
            var finalIndex = start - maxLenght + 1;
            while (maxLenght > 0)
            {
                word += numbers[finalIndex] + " ";
                finalIndex++;
                maxLenght--;
            }
            Console.WriteLine(word);
        }
    }
}