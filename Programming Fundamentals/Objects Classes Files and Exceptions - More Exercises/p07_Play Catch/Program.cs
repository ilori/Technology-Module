using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_Play_Catch
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var count = 0;
            var input = Console.ReadLine().Split(' ');
            while (true)
            {
                if (input[0] == "Replace")
                {
                    try
                    {
                        var index = int.Parse(input[1]);
                        var number = int.Parse(input[2]);
                        try
                        {
                            numbers[index] = number;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("The index does not exist!");
                            count++;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        count++;
                    }
                }
                else if (input[0] == "Print")
                {
                    var showNumbers = new List<int>();
                    try
                    {
                        var start = int.Parse(input[1]);
                        var end = int.Parse(input[2]);
                        for (int i = start; i <= end; i++)
                        {
                            showNumbers.Add(numbers[i]);
                        }
                        Console.WriteLine(string.Join(", ", showNumbers));
                        showNumbers.Clear();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("The index does not exist!");
                        showNumbers.Clear();
                        count++;
                    }
                }
                else if (input[0] == "Show")
                {
                    try
                    {
                        try
                        {
                            var showNum = int.Parse(input[1]);
                            Console.WriteLine(numbers[showNum]);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("The index does not exist!");
                            count++;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        count++;
                    }
                }
                if (count == 3)
                {
                    break;
                }
                input = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}