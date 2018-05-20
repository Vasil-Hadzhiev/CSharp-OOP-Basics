namespace _02.VehiclesExtension.Models
{
    using System;

    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if ((this.FuelConsumption + 1.4) * distance > this.FuelQuantity)
            {
                Console.WriteLine("Bus needs refueling");
            }
            else
            {
                this.FuelQuantity -= (this.FuelConsumption + 1.4) * distance;
                Console.WriteLine($"Bus travelled {distance} km");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }
        }

        public override void DriveEmpty(double distance)
        {
            if (this.FuelConsumption * distance > this.FuelQuantity)
            {
                Console.WriteLine("Bus needs refueling");
            }
            else
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                Console.WriteLine($"Bus travelled {distance} km");
            }
        }

        public override string ToString()
        {
            return $"Bus: {this.FuelQuantity:f2}";
        }
    }
}