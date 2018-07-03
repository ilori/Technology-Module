using System;

namespace p02_AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var sum = firstNum + secondNum;
            Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
        }
    }
}