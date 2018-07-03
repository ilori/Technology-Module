﻿using System;

namespace p15_Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}