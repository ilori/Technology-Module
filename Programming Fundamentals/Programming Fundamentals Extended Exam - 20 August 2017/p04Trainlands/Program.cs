using System;
using System.Collections.Generic;
using System.Linq;

namespace p04Trainlands
{
    class Program
    {
        static void Main()
        {
            var trains = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine();

            while (input != "It's Training Men!")
            {
                var tokens = input.Split(new[] {" ", "->", ":", "="}, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (tokens.Count == 3)
                {
                    var trainName = tokens[0];
                    var wagonName = tokens[1];
                    var power = long.Parse(tokens[2]);
                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, long>());
                    }
                    trains[trainName].Add(wagonName, power);
                }
                else
                {
                    if (input.Contains("="))
                    {
                        var firstTrain = tokens[0];
                        var secondTrain = tokens[1];
                        if (!trains.ContainsKey(firstTrain))
                        {
                            trains[firstTrain] = new Dictionary<string, long>(trains[secondTrain]);
                        }
                        trains[firstTrain] = new Dictionary<string, long>(trains[secondTrain]);
                    }
                    else if (input.Contains("->"))
                    {
                        var firstTrain = tokens[0];
                        var secondTrain = tokens[1];
                        if (!trains.ContainsKey(firstTrain))
                        {
                            trains[firstTrain] = new Dictionary<string, long>();
                        }
                        foreach (var train in trains[secondTrain])
                        {
                            trains[firstTrain].Add(train.Key, train.Value);
                        }
                        trains.Remove(secondTrain);
                    }
                }


                input = Console.ReadLine();
            }
            foreach (var train in trains.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Keys.Count))
            {
                Console.WriteLine($"Train: {train.Key}");

                foreach (var wagon in train.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}