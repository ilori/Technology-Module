using System;

namespace p03_English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            LastDigitName();
        }

        private static void LastDigitName()
        {
            var number = Console.ReadLine();
            var num = Convert.ToChar(number[number.Length - 1]);
            var finalWord = Convert.ToString(num);
            switch (finalWord)
            {
                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                case "6":
                    Console.WriteLine("six");
                    break;
                case "7":
                    Console.WriteLine("seven");
                    break;
                case "8":
                    Console.WriteLine("eight");
                    break;
                case "9":
                    Console.WriteLine("nine");
                    break;
                case "0":
                    Console.WriteLine("zero");
                    break;
            }
        }
    }
}