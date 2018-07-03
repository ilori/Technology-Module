using System;
using System.Linq;
using System.Numerics;

namespace p04_Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var searchNumber = long.Parse(Console.ReadLine());
            var index = 0;
            var isFound = false;
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] == searchNumber)
                {
                    index = i;
                    isFound = true;
                    break;
                }
            }
            var finalArray = new long[index];
            for (int i = 0; i < finalArray.Length; i++)
            {
                finalArray[i] = array[i];
            }
            var sum = finalArray.Sum();
            if (!isFound)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}