namespace Avatar.Factories
{
    using Avatar.Models.Benders;

    public class BenderFactory
    {
        public Bender CreateBender(string type, string name, int power, double specialPower)
        {
            switch (type)
            {
                case "Air":
                    return new AirBender(name, power, specialPower);
                case "Fire":
                    return new FireBender(name, power, specialPower);
                case "Water":
                    return new WaterBender(name, power, specialPower);
                case "Earth":
                    return new EarthBender(name, power, specialPower);
                default:
                    return null;
            }
        }
    }
}