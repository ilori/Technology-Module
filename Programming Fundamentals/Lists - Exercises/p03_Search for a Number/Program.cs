using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var finalNumbers = new List<int>();
            var isFound = false;
            for (int i = 0; i < commands[0]; i++)
            {
                finalNumbers.Add(numbers[i]);
            }
            for (int i = 0; i < commands[1]; commands[1]--)
            {
                finalNumbers.RemoveAt(i);
            }
            for (int i = 0; i < finalNumbers.Count; i++)
            {
                if (commands[2] == finalNumbers[i])
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}