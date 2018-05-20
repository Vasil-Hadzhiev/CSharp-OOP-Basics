namespace _02.VehiclesExtension.Models
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if ((this.FuelConsumption + 1.6) * distance > this.FuelQuantity)
            {
                Console.WriteLine("Truck needs refueling");
            }
            else
            {
                this.FuelQuantity -= (this.FuelConsumption + 1.6) * distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += liters * 0.95;
        }

        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:f2}";
        }
    }
}