using System;
using System.Collections.Generic;
using System.Linq;

namespace p04
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pokemons = new Dictionary<string, List<Pokemon>>();
            while (input != "wubbalubbadubdub")
            {
                var tokens = input.Split(new[] {" -> "}, StringSplitOptions.None).ToList();
                if (tokens.Count > 1)
                {
                    var pokemonName = tokens[0];
                    var pokeEvo = tokens[1];
                    var evoIndex = int.Parse(tokens[2]);

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons[pokemonName] = new List<Pokemon>();
                    }
                    var pokemon = new Pokemon();
                    pokemon.Name = pokemonName;
                    pokemon.Evolution = pokeEvo;
                    pokemon.Index = evoIndex;
                    pokemons[pokemonName].Add(pokemon);

                    input = Console.ReadLine();
                }
                else
                {
                    var pokemonName = tokens[0];
                    if (pokemons.ContainsKey(pokemonName))
                    {
                        foreach (var pokemon in pokemons.Where(x=>x.Key == pokemonName))
                        {
                            Console.WriteLine($"# {pokemon.Key}");
                            foreach (var pokemon1 in pokemon.Value)
                            {
                                Console.WriteLine($"{pokemon1.Evolution} <-> {pokemon1.Index}");
                            }
                        }
                    }
                    input = Console.ReadLine();
                }
            }
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var pokemon1 in pokemon.Value.OrderByDescending(x=>x.Index))
                {
                    Console.WriteLine($"{pokemon1.Evolution} <-> {pokemon1.Index}");

                }
            }
        }
    }
}

public class Pokemon
{
    public string Name { get; set; }
    public string Evolution { get; set; }
    public int Index { get; set; }
}