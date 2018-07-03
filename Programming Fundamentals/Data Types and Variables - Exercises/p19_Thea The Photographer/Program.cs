using System;

namespace p19_Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfPictures = double.Parse(Console.ReadLine());
            var filterTime = double.Parse(Console.ReadLine());
            var filterFactor = double.Parse(Console.ReadLine());
            var uploadTime = double.Parse(Console.ReadLine());
            var filteredPictures = Math.Ceiling((double) amountOfPictures * (filterFactor / 100.0));
            var totalSeconds = (filteredPictures * uploadTime) + (amountOfPictures * filterTime);
            var ts = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine($"{ts.Days}:{ts.Hours:d2}:{ts.Minutes:d2}:{ts.Seconds:d2}");
            
        }
    }
}