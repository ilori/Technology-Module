using System;
using System.IO;
using System.Linq;

namespace p02_Ladybugs
{
    class Program
    {
        public static void Main()
        {
            var fieldSize = new long[long.Parse(Console.ReadLine())];
            var bugIndex = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            foreach (var index in bugIndex)
            {
                if (index >= 0 && index < fieldSize.Length)
                {
                    fieldSize[index] = 1;
                }
            }
            var command = Console.ReadLine();
            while (command != "end")
            {
                var tokens = command.Split(' ').ToList();
                var firstIndex = long.Parse(tokens[0]);
                var direction = tokens[1];
                var secondIndex = long.Parse(tokens[2]);
                if (firstIndex < 0 || firstIndex >= fieldSize.Length)
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (fieldSize[firstIndex] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (direction == "right")
                {
                    if (firstIndex + secondIndex >= fieldSize.Length || firstIndex + secondIndex < 0)
                    {
                        fieldSize[firstIndex] = 0;
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        var distance = firstIndex + secondIndex;
                        fieldSize[firstIndex] = 0;
                        while (firstIndex < fieldSize.Length && firstIndex >= 0 && distance < fieldSize.Length &&
                               distance >= 0)
                        {
                            if (fieldSize[distance] == 0)
                            {
                                fieldSize[distance] = 1;
                                break;
                            }
                            else
                            {
                                distance += secondIndex;
                            }
                        }
                    }
                }
                else if (direction == "left")
                {
                    if (firstIndex - secondIndex >= fieldSize.Length || firstIndex - secondIndex < 0)
                    {
                        fieldSize[firstIndex] = 0;
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        var distance = firstIndex - secondIndex;
                        fieldSize[firstIndex] = 0;
                        while (firstIndex < fieldSize.Length && firstIndex >= 0 && distance < fieldSize.Length &&
                               distance >= 0)
                        {
                            if (fieldSize[distance] == 0)
                            {
                                fieldSize[distance] = 1;
                                break;
                            }
                            else
                            {
                                distance -= secondIndex;
                            }
                        }
                    }
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", fieldSize));
        }
    }
}