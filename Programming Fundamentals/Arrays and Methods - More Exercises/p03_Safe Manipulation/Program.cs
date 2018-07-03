using System;
using System.Linq;

namespace p03_Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                if (command[0] != "Replace" && command[0] != "Distinct" && command[0] != "Reverse")
                {
                    Console.WriteLine("Invalid input!");
                }
                if (command[0] == "Reverse")
                {
                    Array.Reverse(firstArray);
                }
                else if (command[0] == "Distinct")
                {
                    firstArray = firstArray.Distinct().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    if (int.Parse(command[1]) > firstArray.Length - 1 || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        firstArray[int.Parse(command[1])] = command[2];
                    }
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(string.Join(", ", firstArray));
        }
    }
}