﻿using System;

namespace p10_MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());
            if (times > 10)
            {
                Console.WriteLine("{0} X {1} = {2}",n,times,n*times);
            }
            else
            {
                for (int i = times; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}",n,i,n*i);
                }
            }
        }
    }
}