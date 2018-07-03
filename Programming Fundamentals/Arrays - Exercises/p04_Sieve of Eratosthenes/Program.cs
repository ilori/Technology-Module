using System;
using System.Collections.Generic;

namespace p04_Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool[] primesArr = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                primesArr[i] = true;
            }
            primesArr[0] = false;
            primesArr[1] = false;
            for (int i = 0; i < primesArr.Length; i++)
            {
                if (primesArr[i] == true)
                {
                    for (int a = 2; (a * i) <= n; a++)
                    {
                        primesArr[a * i] = false;
                    }
                }
            }
            for (int j = 2; j <= n; j++)
            {
                if (primesArr[j] == true)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine();
        }
    }
}