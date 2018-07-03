using System;
using System.Linq;

namespace p18_Sequence_of_Commands
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sizeOfArray = long.Parse(Console.ReadLine());

            var array = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();


            while (true)
            {
                var line = Console.ReadLine().Split(' ');
                var command = line[0];

                if (command == "stop")
                {
                    break;
                }

                var arguments = new long[2];

                if (command.Equals("add") ||
                    command.Equals("subtract") ||
                    command.Equals("multiply"))
                {
                    arguments[0] = long.Parse(line[1]);
                    arguments[1] = long.Parse(line[2]);

                    PerformAction(array, command, arguments);
                }
                else
                {
                    if (command.Equals("lshift"))
                    {
                        ArrayShiftLeft(array);
                    }
                    else if (command.Equals("rshift"))
                    {
                        ArrayShiftRight(array);
                    }
                }

                PrintArray(array);
                Console.WriteLine();
            }
        }


        static void PerformAction(long[] array, string action, long[] args)
        {
            var pos = args[0] - 1;
            var value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
            }
        }


        private static void ArrayShiftRight(long[] array)
        {
            var lastElement = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastElement;
        }


        private static void ArrayShiftLeft(long[] array)
        {
            long firstElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstElement;
        }


        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}