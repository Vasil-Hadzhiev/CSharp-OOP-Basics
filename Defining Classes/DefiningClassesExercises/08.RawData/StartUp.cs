using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var cars = new List<Car>();

        var numberOfCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCars; i++)
        {
            var carTokens = Console.ReadLine().Split();

            var model = carTokens[0];
            var engineSpeed = int.Parse(carTokens[1]);
            var enginePower = int.Parse(carTokens[2]);

            var engine = new Engine(engineSpeed, enginePower);

            var cargoWeight = int.Parse(carTokens[3]);
            var cargoType = carTokens[4];

            var cargo = new Cargo(cargoWeight, cargoType);

            var tires = new List<Tire>();

            for (int j = 5; j < carTokens.Length - 1; j += 2)
            {
                var tirePressure = double.Parse(carTokens[j]);
                var tireAge = int.Parse(carTokens[j + 1]);

                var tire = new Tire(tirePressure, tireAge);
                tires.Add(tire);
            }

            var car = new Car(model, engine, cargo, tires);

            cars.Add(car);
        }

        var givenCargoType = Console.ReadLine();

        if (givenCargoType == "fragile")
        {
            cars = cars.
            Where(c => c.Cargo.Type == givenCargoType && c.Tires.Any(t => t.Pressure < 1)).
            ToList();
        }
        else
        {
            cars = cars.
            Where(c => c.Cargo.Type == givenCargoType && c.Engine.Power > 250).
            ToList();
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.Model);
        }
        
    }
}

