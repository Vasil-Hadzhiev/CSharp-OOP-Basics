namespace Avatar.Controller
{
    using System;
    using System.Linq;

    public class Engine
    {
        private bool isRunning;
        private NationsBuilder builder;

        public Engine()
        {
            this.builder = new NationsBuilder();
            this.isRunning = true;
        }

        public void Run()
        {
            while (this.isRunning)
            {
                var cmdArgs = Console.ReadLine().Split(' ').ToList();
                var command = cmdArgs[0];

                switch (command)
                {
                    case "Bender":
                        this.builder.AssignBender(cmdArgs);
                        break;
                    case "Monument":
                        this.builder.AssignMonument(cmdArgs);
                        break;
                    case "Status":
                        Console.WriteLine(this.builder.GetStatus(cmdArgs[1]));
                        break;
                    case "War":
                        this.builder.IssueWar(cmdArgs[1]);
                        break;
                    case "Quit":
                        Console.WriteLine(this.builder.GetWarsRecord());
                        this.isRunning = false;
                        break;
                }
            }
        }
    }
}