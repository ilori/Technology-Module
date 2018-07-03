using System;
using System.Linq;

namespace p02_Command_Interpreter
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().ToList();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(' ').ToList();

                var command = tokens[0];

                switch (command)
                {
                    case "reverse":
                        var start = int.Parse(tokens[2]);
                        var count = int.Parse(tokens[4]);
                        if (start < 0 || count < 0 || start + count > numbers.Count ||
                            start > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        numbers.Reverse(start, count);
                        break;
                    case "sort":
                        start = int.Parse(tokens[2]);
                        count = int.Parse(tokens[4]);
                        if (start < 0 || count < 0 || start + count > numbers.Count ||
                            start > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        numbers.Sort(start, count, StringComparer.CurrentCulture);
                        break;
                    case "rollLeft":
                        count = int.Parse(tokens[1]) % numbers.Count;

                        if (count >= 0 && count < numbers.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                var temp = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(temp);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollRight":
                        count = int.Parse(tokens[1]) % numbers.Count;
                        if (count >= 0 && count < numbers.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                var temp = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, temp);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}