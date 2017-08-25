namespace _04.FirstAndReserveTeam
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var team = new Team("Bojurishte");

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                var player = new Person(
                    cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    double.Parse(cmdArgs[3]));

                team.AddPlayer(player);
            }

            Console.WriteLine(team.ToString());
        }
    }
}