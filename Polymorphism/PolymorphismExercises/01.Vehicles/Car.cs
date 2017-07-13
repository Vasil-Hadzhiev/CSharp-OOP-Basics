using System;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption) 
        : base(fuelQuantity, fuelConsumption)
    {
    }

    public override double FuelConsumption => base.FuelConsumption + 0.9;

    public override void Drive(double distance)
    {
        if (this.FuelConsumption * distance > this.FuelQuantity)
        {
            Console.WriteLine("Car needs refueling");
        }
        else
        {
            this.FuelQuantity -= this.FuelConsumption * distance;
            Console.WriteLine($"Car travelled {distance} km");
        }
    }

    public override void Refuel(double liters)
    {
        this.FuelQuantity += liters;
    }

    public override string ToString()
    {
        return $"Car: {this.FuelQuantity:f2}";
    }
}

