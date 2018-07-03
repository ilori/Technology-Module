using System;

namespace p08_RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = 0;
            Console.Write("Length: ");
            var lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var height = double.Parse(Console.ReadLine());
            volume = (lenght * width * height) / 3;
            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}