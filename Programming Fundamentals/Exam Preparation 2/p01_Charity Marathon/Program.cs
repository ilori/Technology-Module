using System;

namespace p01_Charity_Marathon
{
    class Program
    {
        public static void Main()
        {
            var days = decimal.Parse(Console.ReadLine());
            var runners = decimal.Parse(Console.ReadLine());
            var avarageLaps = decimal.Parse(Console.ReadLine());
            var trackLenght = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());
            if (trackCapacity * days < runners)
            {
                runners = trackCapacity * days;
            }
            var totalMoney = (runners * avarageLaps * trackLenght / 1000) * moneyPerKilometer;
            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}