using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ').ToList();
            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    for (int i = command.Count - 1; i > 1; i--)
                    {
                        numbers.Insert(int.Parse(command[1]), int.Parse(command[i]));
                    }
                }
                else if (command[0] == "addMany")
                {
                    for (int i = command.Count - 1; i >= 2; i--)
                    {
                        numbers.Insert(int.Parse(command[1]), int.Parse(command[i]));
                    }
                }
                else if (command[0] == "contains")
                {
                    var isContained = false;
                    var index = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == int.Parse(command[1]))
                        {
                            isContained = true;
                            index = i;
                            break;
                        }
                    }
                    if (isContained)
                    {
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (command[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "shift")
                {
                    var index = 0;
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        var number = numbers[0];
                        numbers.RemoveAt(index);
                        numbers.Add(number);
                    }
                }
                if (command[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                    }
                }


                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}