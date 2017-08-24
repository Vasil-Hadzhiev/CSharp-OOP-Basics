namespace _07.SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
        }

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            private set { this.fuelAmount = value; }
        }

        public double TraveledDistance
        {
            get { return this.traveledDistance; }
            private set { this.traveledDistance = value; }
        }

        public void DriveCar(double amountOfKm)
        {
            if (amountOfKm * this.fuelConsumption <= this.fuelAmount)
            {
                this.fuelAmount -= amountOfKm * this.fuelConsumption;
                this.traveledDistance += amountOfKm;
            }
            else
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}