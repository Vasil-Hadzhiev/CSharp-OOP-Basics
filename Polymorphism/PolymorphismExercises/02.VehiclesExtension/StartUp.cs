using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var carInfo = Console.ReadLine().
            Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

        var carFuelQuantity = double.Parse(carInfo[1]);
        var carFuelConsumption = double.Parse(carInfo[2]);
        var carTankCapacity = double.Parse(carInfo[3]);

        var truckInfo = Console.ReadLine().
            Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

        var truckFuelQuantity = double.Parse(truckInfo[1]);
        var truckFuelConsumption = double.Parse(truckInfo[2]);
        var truckTankCapacity = double.Parse(truckInfo[3]);

        var busInfo = Console.ReadLine().
            Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

        var busFuelQuantity = double.Parse(busInfo[1]);
        var busFuelConsumption = double.Parse(busInfo[2]);
        var busTankCapacity = double.Parse(busInfo[3]);

        var car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
        var truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
        var bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

        var entries = int.Parse(Console.ReadLine());

        for (int i = 0; i < entries; i++)
        {
            var tokens = Console.ReadLine().Split();

            var command = tokens[0];
            var vehicleType = tokens[1];
            var value = double.Parse(tokens[2]);
            try
            {
                if (vehicleType == "Car")
                {
                    switch (command)
                    {
                        case "Drive":
                            car.Drive(value);
                            break;
                        case "Refuel":
                            car.Refuel(value);
                            break;
                    }
                }
                else if (vehicleType == "Truck")
                {
                    switch (command)
                    {
                        case "Drive":
                            truck.Drive(value);
                            break;
                        case "Refuel":
                            truck.Refuel(value);
                            break;
                    }
                }
                else
                {
                    switch (command)
                    {
                        case "Drive":
                            bus.Drive(value);
                            break;
                        case "Refuel":
                            bus.Refuel(value);
                            break;
                        case "DriveEmpty":
                            bus.DriveEmpty(value);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }
}

