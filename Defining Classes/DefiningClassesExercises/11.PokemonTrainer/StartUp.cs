using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var trainers = new List<Trainer>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine == "Tournament")
            {
                break;
            }

            var tokens = inputLine.
                Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).
                ToArray();

            var trainerName = tokens[0];
            var pokemonName = tokens[1];
            var pokemonElement = tokens[2];
            var pokemonHealth = int.Parse(tokens[3]);

            var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            if (trainers.Any(t => t.Name == trainerName))
            {
                trainers.FirstOrDefault(t => t.Name == trainerName).Pokemons.Add(pokemon);
            }
            else
            {
                var trainer = new Trainer(trainerName);
                trainer.Pokemons.Add(pokemon);
                trainers.Add(trainer);
            }
        }

        while (true)
        {
            var element = Console.ReadLine();

            if (element == "End")
            {
                break;
            }

            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == element))
                {
                    trainer.Badges++;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                }

                for (int i = 0; i < trainer.Pokemons.Count; i++)
                {
                    if (trainer.Pokemons[i].Health <= 0)
                    {
                        trainer.Pokemons.RemoveAt(i);
                    }
                }
            }
        }

        trainers = trainers.
            OrderByDescending(t => t.Badges).
            ToList();

        foreach (var trainer in trainers)
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }
}

