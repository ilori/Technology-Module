using System;

namespace p04_PhotoGallery
{
    class Program
    {
        private static void Main(string[] args)
        {
            var photoNum = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSize = int.Parse(Console.ReadLine());
            var photoWidth = int.Parse(Console.ReadLine());
            var photoHeight = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: DSC_{photoNum:d4}.jpg");
            if (year < 1000)
            {
                Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/20{year:d2} {hours:d2}:{minutes:D2}");
            }
            else
            {
                Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hours:d2}:{minutes:D2}");
            }
            if (photoSize < 1000)
            {
                Console.WriteLine($"Size: {photoSize}B");
            }
            else if (photoSize > 100000 && photoSize < 1000000)
            {
                Console.WriteLine($"Size: {photoSize / 1000d}KB");
            }
            else if (photoSize > 1000000)
            {
                Console.WriteLine($"Size: {photoSize / 1000000d}MB");
            }
            if (photoWidth > photoHeight)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (landscape)");
            }
            else if (photoWidth < photoHeight)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (portrait)");
            }
            else
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (square)");
            }
        }
    }
}