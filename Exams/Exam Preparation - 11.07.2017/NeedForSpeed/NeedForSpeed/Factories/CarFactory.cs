namespace NeedForSpeed.Factories
{
    using NeedForSpeed.Models.Cars;

    public class CarFactory
    {
        public Car CreateCar(string type, string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
        {
            switch (type)
            {
                case "Performance":
                    return new PerformanceCar(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability);
                case "Show":
                    return new ShowCar(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability);
                default:
                    return null;
            }
        }
    }
}