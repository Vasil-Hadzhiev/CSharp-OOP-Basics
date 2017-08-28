namespace Avatar.Models.Monuments
{
    public class AirMonument : Monument
    {
        private int airAffinity;

        public AirMonument(string name, int airAffinity)
            : base(name)
        {
            this.airAffinity = airAffinity;
        }

        public override int GetAffinityBonus()
        {
            return this.airAffinity;
        }

        public override string ToString()
        {
            return $"Air {base.ToString()}, Air Affinity: {this.airAffinity}";
        }
    }
}