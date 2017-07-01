using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carTokens = Console.ReadLine().Split();

                var model = carTokens[0];
                var fuelAmount = double.Parse(carTokens[1]);
                var fuelConsumptionPerKm = double.Parse(carTokens[2]);

                var car = new Car(model, fuelAmount, fuelConsumptionPerKm);
                cars.Add(car);
            }

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                var tokens = inputLine.Split();

                var model = tokens[1];
                var travelDistance = double.Parse(tokens[2]);

                var carToDrive = cars.First(c => c.Model == model);
                carToDrive.DriveCar(travelDistance);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
