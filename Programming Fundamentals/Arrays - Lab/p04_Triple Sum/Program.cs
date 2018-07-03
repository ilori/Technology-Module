using System;
using System.Linq;

namespace p04_Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var isFound = false;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    for (int k = 0; k < num.Length; k++)
                    {
                        if (num[i] + num[j] == num[k])
                        {
                            Console.WriteLine($"{num[i]} + {num[j]} == {num[k]}");
                            isFound = true;
                            break;
                        }
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}