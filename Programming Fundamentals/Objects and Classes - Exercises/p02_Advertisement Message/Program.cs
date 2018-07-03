    using System;
    using System.Collections.Generic;
    
    namespace p02_Advertisement_Message
    {
        class Program
        {
            static void Main()
            {
                var phrases = new List<string>()
                {
                    "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."
                };
                var events = new List<string>()
                {
                    "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
                };
                var author = new List<string>()
                {
                    "Diana",
                    "Petya",
                    "Stella",
                    "Elena",
                    "Katya",
                    "Iva",
                    "Annie",
                    "Eva"
                };
                var cities = new List<string>()
                {
                    "Burgas",
                    "Sofia",
                    "Plovdiv",
                    "Varna",
                    "Ruse",
                };
                var n = int.Parse(Console.ReadLine());
                var rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    var first = rnd.Next(0, events.Count);
                    var second = rnd.Next(0, author.Count);
                    var third = rnd.Next(0, cities.Count);
                    var forth = rnd.Next(0, phrases.Count);
    
                    Console.WriteLine($"{phrases[forth]} {events[first]} {author[second]} - {cities[third]}");
                }
            }
        }
    }