using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombNumberAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumberAndPower[0])
                {
                    for (int j = 1; j <= bombNumberAndPower[1]; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i - j] = 0;
                        }
                    }
 
                    for (int j = 1; j <= bombNumberAndPower[1]; j++)
                    {
                        if (i + j > numbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i + j] = 0;
                        }
                    }
 
                    numbers[i] = 0;
                }
 
            }
            Console.WriteLine(numbers.Sum());

        }
    }
}