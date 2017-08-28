namespace Avatar.Models.Monuments
{
    public class WaterMonument : Monument
    {
        private int waterAffinity;

        public WaterMonument(string name, int waterAffinity)
            : base(name)
        {
            this.waterAffinity = waterAffinity;
        }

        public override int GetAffinityBonus()
        {
            return this.waterAffinity;
        }

        public override string ToString()
        {
            return $"Water {base.ToString()}, Water Affinity: {this.waterAffinity}";
        }
    }
}