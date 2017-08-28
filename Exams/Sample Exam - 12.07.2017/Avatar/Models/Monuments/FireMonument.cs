namespace Avatar.Models.Monuments
{
    public class FireMonument : Monument
    {
        private int fireAffinity;

        public FireMonument(string name, int fireAffinity)
            : base(name)
        {
            this.fireAffinity = fireAffinity;
        }

        public override int GetAffinityBonus()
        {
            return this.fireAffinity;
        }

        public override string ToString()
        {
            return $"Fire {base.ToString()}, Fire Affinity: {this.fireAffinity}";
        }
    }
}