namespace _06.FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var teams = new List<Team>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var tokens = input.Split(';');

                var command = tokens[0];

                try
                {
                    switch (command)
                    {
                        case "Team":
                            var newTeam = new Team(tokens[1]);
                            teams.Add(newTeam);
                            break;
                        case "Add":
                            if (teams.Any(t => t.Name == tokens[1]))
                            {
                                var currentTeam = teams
                                    .FirstOrDefault(t => t.Name == tokens[1]);

                                var newPlayer = new Player(
                                    tokens[2],
                                    int.Parse(tokens[3]),
                                    int.Parse(tokens[4]),
                                    int.Parse(tokens[5]),
                                    int.Parse(tokens[6]),
                                    int.Parse(tokens[7]));

                                currentTeam.AddPlayer(newPlayer);
                            }
                            else
                            {
                                throw new ArgumentException($"Team {tokens[1]} does not exist.");
                            }

                            break;
                        case "Remove":
                            var teamToRemoveFrom = teams
                                .FirstOrDefault(t => t.Name == tokens[1]);

                            teamToRemoveFrom.RemovePlayer(tokens[2]);
                            break;
                        case "Rating":
                            if (teams.Any(t => t.Name == tokens[1]))
                            {
                                var teamStats = teams.FirstOrDefault(t => t.Name == tokens[1]);
                                Console.WriteLine(teamStats.ToString());
                            }
                            else
                            {
                                throw new ArgumentException($"Team {tokens[1]} does not exist.");
                            }

                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }            
            }
        }
    }
}