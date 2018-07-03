using System;

namespace p11_FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            bool isSatisfied = false;
            for (int i = firstNum; i <= secondNum ; i++)
            {
                for (int j = i + 1; j <= secondNum; j++)
                {
                    for (int k = j + 1; k <= secondNum; k++)
                    {
                        for (int l = k + 1; l <= secondNum; l++)
                        {
                            for (int m = l + 1; m <= secondNum; m++)
                            {
                                Console.WriteLine($"{i} {j} {k} {l} {m}");
                                isSatisfied = true;
                            }
                        }
                    }
                }
            }
            if (!isSatisfied)
            {
                Console.WriteLine("No");
            }
        }
    }
}