﻿using System;

namespace p09_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}",n,i,n*i);
            }
        }
    }
}