using System;

public class Engine
{
    private CarManager manager;

    public Engine()
    {
        this.manager = new CarManager();
    }

    public void Run()
    {
        while (true)
        {
            var command = Console.ReadLine();

            if (command == "Cops Are Here")
            {
                break;
            }

            var cmdArgs = command.Split();

            ExecuteCommand(cmdArgs);
        }
    }

    public void ExecuteCommand(string[] cmdArgs)
    {
        var currentCommand = cmdArgs[0];

        switch (currentCommand)
        {
            case "register":
                break;
            case "check":
                break;
            case "open":
                break;
            case "participate":
                break;
            case "start":
                break;
            case "park":
                break;
            case "unpark":
                break;
            case "tune":
                break;
        }
    }
}

