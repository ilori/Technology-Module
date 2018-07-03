using System;

namespace p17_Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var finishNum = int.Parse(Console.ReadLine());
            for (char i = Convert.ToChar(startNum); i <= finishNum; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}