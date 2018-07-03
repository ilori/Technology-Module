using System;

namespace p08_CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var totalCalories = 0;
            for (int i = 0; i < n; i++)
            {
                var ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    totalCalories += 500;
                }else if (ingredients == "tomato sauce")
                {
                    totalCalories += 150;
                }else if (ingredients == "salami")
                {
                    totalCalories += 600;
                }else if (ingredients == "pepper")
                {
                    totalCalories += 50;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}