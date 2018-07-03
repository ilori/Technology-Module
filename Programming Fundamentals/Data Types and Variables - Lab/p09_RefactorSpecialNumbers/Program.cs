using System;

namespace p09_RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int index = 1; index <= number; index++)
            {
                var sum = 0;
                var actualNumber = index;
                string tF = "";
                while (index > 0)
                {
                    sum += index % 10;
                    index = index / 10;
                }
                bool isTrue = (sum == 5) || (sum == 7) || (sum == 11);
                if (isTrue)
                {
                    tF = "True";
                }
                else
                {
                    tF = "False";
                }
                Console.WriteLine($"{actualNumber} -> " + tF, actualNumber);
                index = actualNumber;
            }
        }
    }
}