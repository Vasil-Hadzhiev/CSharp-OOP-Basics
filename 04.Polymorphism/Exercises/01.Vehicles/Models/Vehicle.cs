namespace _01.Vehicles.Models
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public virtual double FuelConsumption
        {
            get { return this.fuelConsumption; }
            private set { this.fuelConsumption = value; }
        }

        public abstract void Drive(double distance);

        public abstract void Refuel(double liters);
    }
}