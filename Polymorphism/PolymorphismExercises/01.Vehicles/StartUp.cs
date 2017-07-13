using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var carInfo = Console.ReadLine()
            .Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

        var carFuelQuantity = double.Parse(carInfo[1]);
        var carFuelConsumption = double.Parse(carInfo[2]);
        var car = new Car(carFuelQuantity, carFuelConsumption);

        var truckInfo = Console.ReadLine()
            .Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

        var truckFuelQuantity = double.Parse(truckInfo[1]);
        var truckFuelConsumption = double.Parse(truckInfo[2]);
        var truck = new Truck(truckFuelQuantity, truckFuelConsumption);

        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var inputLine = Console.ReadLine().Split();

            var command = inputLine[0];
            var vehicleType = inputLine[1];
            var value = double.Parse(inputLine[2]);

            if (command == "Drive")
            {
                switch (vehicleType)
                {
                    case "Car":
                        car.Drive(value);
                        break;
                    case "Truck":
                        truck.Drive(value);
                        break;
                }
            }
            else
            {
                switch (vehicleType)
                {
                    case "Car":
                        car.Refuel(value);
                        break;
                    case "Truck":
                        truck.Refuel(value);
                        break;
                }
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
    }
}

