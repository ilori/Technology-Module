using System;

namespace p01Trainers
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var technicalMoney = 0m;
            var theoreticalMoney = 0m;
            var practicalMoney = 0m;

            for (int i = 0; i < n; i++)
            {
                var distance = long.Parse(Console.ReadLine()) * 1600;
                var cargo = decimal.Parse(Console.ReadLine()) * 1000m;
                var team = Console.ReadLine();
                var fuelExpenses = 0.7m * distance * 2.5m;
                var cargoIncome = 1.5m * cargo;
                var total = cargoIncome - fuelExpenses;
                switch (team)
                {
                    case "Technical":

                        technicalMoney += total;
                        break;
                    case "Theoretical":

                        theoreticalMoney += total;
                        break;
                    case "Practical":

                        practicalMoney += total;
                        break;
                }
            }
            if (technicalMoney > theoreticalMoney && technicalMoney > practicalMoney)
            {
                Console.WriteLine($"The Technical Trainers win with ${technicalMoney:F3}.");
            }
            else if (theoreticalMoney > technicalMoney && theoreticalMoney > practicalMoney)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${theoreticalMoney:F3}.");
            }
            else
            {
                Console.WriteLine($"The Practical Trainers win with ${practicalMoney:F3}.");
            }
        }
    }
}