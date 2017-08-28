namespace Avatar.Models.Benders
{
    public class FireBender : Bender
    {
        private double heatAggression;

        public FireBender(string name, int power, double heatAggression)
            : base(name, power)
        {
            this.heatAggression = heatAggression;
        }

        public override double GetTotalPower()
        {
            return this.Power * this.heatAggression;
        }

        public override string ToString()
        {
            return $"Fire {base.ToString()}, Heat Aggression: {this.heatAggression:f2}";
        }
    }
}