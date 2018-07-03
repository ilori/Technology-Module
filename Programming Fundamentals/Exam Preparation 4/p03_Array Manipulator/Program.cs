using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace p03_Array_Manipulator
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine();
            while (input != "end")
            {
                var tokens = input.Split();
                var command = tokens[0];
                switch (command)
                {
                    case "exchange":
                        Exchange(tokens, numbers);
                        break;
                    case "max":
                        ReturnMax(tokens, numbers);
                        break;
                    case "min":
                        ReturnMin(tokens, numbers);
                        break;
                    case "first":
                        ReturnFirst(tokens, numbers);
                        break;
                    case "last":
                        ReturnLast(tokens, numbers);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ",numbers)}]");
        }

        private static void ReturnLast(string[] tokens, List<int> numbers)
        {
            var count = int.Parse(tokens[1]);
            var oddOrEven = tokens[2];
            var tempList = new List<int>();
            if (count > numbers.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (oddOrEven == "odd")
                {
                    tempList = numbers.Where(x => x % 2 != 0).ToList();
                    tempList.Reverse();
                    tempList=tempList.Take(count).ToList();
                    tempList.Reverse();
                    if (tempList.Count > 0)
                    {
                        Console.WriteLine($"[{string.Join(", ", tempList)}]");
                    }
                    else
                    {
                        Console.WriteLine("[]");
                    }
                }
                else if (oddOrEven == "even")
                {
                    tempList = numbers.Where(x => x % 2 == 0).ToList();
                    tempList.Reverse();
                    tempList=tempList.Take(count).ToList();
                    tempList.Reverse();
                    if (tempList.Count > 0)
                    {
                        Console.WriteLine($"[{string.Join(", ", tempList)}]");
                    }
                    else
                    {
                        Console.WriteLine("[]");
                    }
                }
            }
        }

        private static void ReturnFirst(string[] tokens, List<int> numbers)
        {
            var count = int.Parse(tokens[1]);
            var oddOrEven = tokens[2];
            var tempList = new List<int>();
            if (count > numbers.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (oddOrEven == "odd")
                {
                    tempList = numbers.Where(x => x % 2 != 0).Take(count).ToList();
                    if (tempList.Count > 0)
                    {
                        Console.WriteLine($"[{string.Join(", ", tempList)}]");
                    }
                    else
                    {
                        Console.WriteLine("[]");
                    }
                }
                else if (oddOrEven == "even")
                {
                    tempList = numbers.Where(x => x % 2 == 0).Take(count).ToList();
                    if (tempList.Count > 0)
                    {
                        Console.WriteLine($"[{string.Join(", ", tempList)}]");
                    }
                    else
                    {
                        Console.WriteLine("[]");
                    }
                }
            }
        }

        private static void ReturnMin(string[] tokens, List<int> numbers)
        {
            var minNumber = 0;
            var temp = int.MaxValue;
            var command = tokens[1];
            var isFound = false;
            if (command == "odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        if (numbers[i] <= temp)
                        {
                            minNumber = i;
                            temp = numbers[i];
                            isFound = true;
                        }
                    }
                }
                if (isFound)
                {
                    Console.WriteLine(minNumber);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (command == "even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] <= temp)
                        {
                            minNumber = i;
                            temp = numbers[i];
                            isFound = true;
                        }
                    }
                }
                if (isFound)
                {
                    Console.WriteLine(minNumber);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void ReturnMax(string[] tokens, List<int> numbers)
        {
            var maxNumber = 0;
            var temp = int.MinValue;
            var command = tokens[1];
            var isFound = false;
            if (command == "odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        if (numbers[i] >= temp)
                        {
                            maxNumber = i;
                            temp = numbers[i];
                            isFound = true;
                        }
                    }
                }
                if (isFound)
                {
                    Console.WriteLine(maxNumber);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (command == "even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        if (numbers[i] >= temp)
                        {
                            maxNumber = i;
                            temp = numbers[i];
                            isFound = true;
                        }
                    }
                }
                if (isFound)
                {
                    Console.WriteLine(maxNumber);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void Exchange(string[] tokens, List<int> numbers)
        {
            var count = int.Parse(tokens[1]);
            if (count <= 0 || count > numbers.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                for (int i = 0; i <= count; i++)
                {
                    var temp = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(temp);
                }
            }
        }
    }
}