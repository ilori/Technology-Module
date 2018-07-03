using System;

namespace p06_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            RaiseToPower(number, power);
            Console.WriteLine(RaiseToPower(number,power));
        }

        private static double RaiseToPower(double number, int power)
        {
            var result = Math.Pow(number, power);
            return result;
        }
    }
}