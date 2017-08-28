namespace Avatar.Models.Monuments
{
    public abstract class Monument
    {
        private string name;

        protected Monument(string name)
        {
            this.name = name;
        }

        public abstract int GetAffinityBonus();

        public override string ToString()
        {
            return $"Monument: {this.name}";
        }
    }
}