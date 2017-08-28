namespace Avatar.Factories
{
    using Avatar.Models.Monuments;

    public class MonumentFactory
    {
        public Monument CreateMonument(string type, string name, int affinity)
        {
            switch (type)
            {
                case "Air":
                    return new AirMonument(name, affinity);
                case "Fire":
                    return new FireMonument(name, affinity);
                case "Water":
                    return new WaterMonument(name, affinity);
                case "Earth":
                    return new EarthMonument(name, affinity);
                default:
                    return null;
            }
        }
    }
}