using System;
using System.Linq;

namespace p02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rotations = int.Parse(Console.ReadLine());
            var temporaryArray = new int[firstArray.Length - 1];
            var secondArray = new int[firstArray.Length];
            var sum = new int[firstArray.Length];
            for (int i = 0; i < rotations; i++)
            {
                for (int j = 0; j < temporaryArray.Length; j++)
                {
                    temporaryArray[j] = firstArray[j];
                }
                secondArray[0] = firstArray[firstArray.Length - 1];
                for (int j = 0; j < temporaryArray.Length; j++)
                {
                    secondArray[j + 1] = temporaryArray[j];
                }
                firstArray = secondArray;
                for (int j = 0; j < firstArray.Length; j++)
                {
                    sum[j] += secondArray[j];
                }
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}