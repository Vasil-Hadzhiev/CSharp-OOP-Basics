namespace _01.Vehicles.Models
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + 1.6;

        public override void Drive(double distance)
        {
            if (this.FuelConsumption * distance > this.FuelQuantity)
            {
                Console.WriteLine("Truck needs refueling");
            }
            else
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters * 0.95;
        }

        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:f2}";
        }
    }
}