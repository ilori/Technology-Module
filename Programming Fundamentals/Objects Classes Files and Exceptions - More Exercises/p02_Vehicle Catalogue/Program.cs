using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Vehicle_Catalogue
{
    class Program
    {
        public static void Main()
        {
            var trucks = new List<Truck>();
            var cars = new List<Car>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(' ').ToList();
                var vehicleType = tokens[0].ToLower();
                var vehicleModel = tokens[1];
                var vehicleColor = tokens[2];
                var vehicleHorsePower = int.Parse(tokens[3]);
                var truck = new Truck();
                var car = new Car();
                if (vehicleType == "truck")
                {
                    truck.Model = vehicleModel;
                    truck.Color = vehicleColor;
                    truck.HorsePower = vehicleHorsePower;
                    trucks.Add(truck);
                }
                else if (vehicleType == "car")
                {
                    car.Model = vehicleModel;
                    car.Color = vehicleColor;
                    car.HorsePower = vehicleHorsePower;
                    cars.Add(car);
                }
                input = Console.ReadLine();
            }
            var secondInput = Console.ReadLine();
            while (secondInput != "Close the Catalogue")
            {
                foreach (var car in cars)
                {
                    if (secondInput == car.Model)
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }
                }
                foreach (var truck in trucks)
                {
                    if (secondInput == truck.Model)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                    }
                }
                secondInput = Console.ReadLine();
            }
            var carsHorsepower = 0m;
            var trucksHorsepower = 0m;
            foreach (var car in cars)
            {
                carsHorsepower += car.HorsePower;
            }
            foreach (var truck in trucks)
            {
                trucksHorsepower += truck.HorsePower;
            }
            if (carsHorsepower > 0)
            {
                carsHorsepower /= cars.Count;
            }
            if (trucksHorsepower > 0)
            {
                trucksHorsepower /= trucks.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: {carsHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksHorsepower:f2}.");
        }
    }
}

public class Truck
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int HorsePower { get; set; }
}

public class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int HorsePower { get; set; }
}