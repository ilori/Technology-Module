using System;

namespace p06_IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            if (secondNum > firstNum)
            {
                for (int i = firstNum; i <= secondNum; i++)
                {
                    Console.WriteLine(i);
                }
            }else if (secondNum < firstNum)
            {
                for (int i = secondNum; i <= firstNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}