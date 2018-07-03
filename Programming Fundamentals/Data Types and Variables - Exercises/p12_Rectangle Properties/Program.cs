﻿using System;

namespace p12_Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var perimeter = 2 * (width + height);
            var area = height * width;
            var diagonal = Math.Pow(width,2) + Math.Pow(height,2);
            diagonal = Math.Sqrt(diagonal);
            Console.WriteLine($"{perimeter}");
            Console.WriteLine($"{area}");
            Console.WriteLine($"{diagonal}");
        }
    }
}