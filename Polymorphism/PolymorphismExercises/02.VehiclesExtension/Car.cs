using System;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override void Drive(double distance)
    {
        if ((this.FuelConsumption + 0.9) * distance > this.FuelQuantity)
        {
            Console.WriteLine("Car needs refueling");
        }
        else
        {
            this.FuelQuantity -= (this.FuelConsumption + 0.9) * distance;
            Console.WriteLine($"Car travelled {distance} km");
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

    public override string ToString()
    {
        return $"Car: {this.FuelQuantity:f2}";
    }
}

