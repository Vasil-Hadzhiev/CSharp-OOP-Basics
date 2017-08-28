namespace Avatar.Models.Monuments
{
    public class EarthMonument : Monument
    {
        private int earthAffinity;

        public EarthMonument(string name, int earthAffinity)
            : base(name)
        {
            this.earthAffinity = earthAffinity;
        }

        public override int GetAffinityBonus()
        {
            return this.earthAffinity;
        }

        public override string ToString()
        {
            return $"Earth {base.ToString()}, Earth Affinity: {this.earthAffinity}";
        }
    }
}