using System;
using System.Linq;

namespace p02_Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split();
            string[] secondArray = new string[firstArray.Length];
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                var index = 0;
                if (command[index] == "Distinct")
                {
                    secondArray = firstArray.Distinct().ToArray();
                    firstArray = secondArray;
                }
                else if (command[index] == "Reverse")
                {
                    Array.Reverse(firstArray);
                }
                else if (command[index] == "Replace")
                {
                    firstArray[int.Parse(command[1])] = command[2];
                }
            }
            Console.WriteLine(string.Join(", ",firstArray));
        }
    }
}