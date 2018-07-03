using System;


namespace p09Melrah_Shake
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            var canShakeIt = true;

            while (canShakeIt)
            {
                var firstIndex = input.IndexOf(pattern);
                var secondIndex = input.LastIndexOf(pattern);
                if (firstIndex > -1 && secondIndex > -1 && pattern.Length > 0)
                {
                    firstIndex = input.IndexOf(pattern);
                    input = input.Remove(firstIndex, pattern.Length);
                    secondIndex = input.LastIndexOf(pattern);
                    input = input.Remove(secondIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    if (pattern.Length > 0)
                    {
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    canShakeIt = false;
                    break;
                }
            }
            Console.WriteLine(input);
        }
    }
}