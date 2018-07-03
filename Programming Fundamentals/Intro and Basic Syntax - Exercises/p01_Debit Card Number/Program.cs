using System;

namespace p01_Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var forthNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNum:d4} {secondNum:d4} {thirdNum:d4} {forthNum:d4}");
        }
    }
}