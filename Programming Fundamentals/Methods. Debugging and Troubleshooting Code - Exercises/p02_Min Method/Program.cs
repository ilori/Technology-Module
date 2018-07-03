using System;

namespace p02_Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMax();
        }

        private static void GetMax()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            if (firstNum >= secondNum && firstNum >= thirdNum)
            {
                Console.WriteLine($"{firstNum}");
            }else if (secondNum >= firstNum && secondNum >= thirdNum)
            {
                Console.WriteLine($"{secondNum}");
            }
            else
            {
                Console.WriteLine($"{thirdNum}");
            }
        }
    }
}