using System;

namespace p05_BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var beatsPerMinute = double.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());
            var numberOfBars = Math.Round(numberOfBeats / 4.0, 1);
            var seconds = numberOfBeats / beatsPerMinute * 60;
            var minutes = seconds / 60;
            seconds = seconds % 60;
            Console.WriteLine($"{numberOfBars} bars - {Math.Truncate(minutes)}m {Math.Truncate(seconds)}s");
        }
    }
}