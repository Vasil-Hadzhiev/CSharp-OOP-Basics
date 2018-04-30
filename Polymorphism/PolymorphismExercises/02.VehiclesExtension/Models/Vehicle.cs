namespace _02.VehiclesExtension.Models
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            private set { this.fuelConsumption = value; }
        }

        public double TankCapacity
        {
            get { return this.tankCapacity; }
            private set { this.tankCapacity = value; }
        }

        public abstract void Drive(double distance);

        public abstract void Refuel(double liters);

        public virtual void DriveEmpty(double distance) { }
    }
}