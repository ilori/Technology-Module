using System;

namespace p10_Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());
            var years = centuries * 100;
            var days = 365.242199 * years;
            var hours =(int) days * 24;
            var minutes =(int) hours * 60;
            var seconds =(int) minutes * 60.0;
            var milliseconds = (decimal)seconds * 1000m;
            var microseconds =(decimal) milliseconds * 1000m;
            var nanoseconds = (decimal)microseconds * 1000m;
            Console.WriteLine(
                $"{centuries} centuries = {years} years = {Math.Truncate(days)} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}