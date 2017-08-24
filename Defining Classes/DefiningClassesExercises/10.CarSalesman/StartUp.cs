namespace _10.CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfEngines = int.Parse(Console.ReadLine());

            var engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var model = engineTokens[0];
                var power = int.Parse(engineTokens[1]);

                var engine = new Engine(model, power);

                if (engineTokens.Length == 3)
                {
                    var tryDisplacement = 0;
                    var isDisplacement = int.TryParse(engineTokens[2], out tryDisplacement);

                    if (isDisplacement)
                    {
                        engine.Displacement = engineTokens[2];
                    }
                    else
                    {
                        engine.Efficiency = engineTokens[2];
                    }
                }
                else if (engineTokens.Length == 4)
                {
                    engine.Displacement = engineTokens[2];
                    engine.Efficiency = engineTokens[3];
                }

                engines.Add(engine);
            }

            var cars = new List<Car>();

            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var carTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var model = carTokens[0];
                var engine = carTokens[1];

                var carEngine = engines.First(e => e.Model == engine);

                var car = new Car(model, carEngine);

                if (carTokens.Length == 3)
                {
                    var tryWeight = 0;
                    var isWeight = int.TryParse(carTokens[2], out tryWeight);

                    if (isWeight)
                    {
                        car.Weight = carTokens[2];
                    }
                    else
                    {
                        car.Color = carTokens[2];
                    }
                }
                else if (carTokens.Length == 4)
                {
                    car.Weight = carTokens[2];
                    car.Color = carTokens[3];
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine("{0}:", car.Model);
                Console.WriteLine("  {0}:", car.Engine.Model);
                Console.WriteLine("    Power: {0}", car.Engine.Power);
                Console.WriteLine("    Displacement: {0}", car.Engine.Displacement);
                Console.WriteLine("    Efficiency: {0}", car.Engine.Efficiency);
                Console.WriteLine("  Weight: {0}", car.Weight);
                Console.WriteLine("  Color: {0}", car.Color);
            }
        }
    }
}