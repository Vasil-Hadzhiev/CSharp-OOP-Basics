namespace Avatar.Models.Benders
{
    public class WaterBender : Bender
    {
        private double waterClarity;

        public WaterBender(string name, int power, double waterClarity)
            : base(name, power)
        {
            this.waterClarity = waterClarity;
        }

        public override double GetTotalPower()
        {
            return this.Power * this.waterClarity;
        }

        public override string ToString()
        {
            return $"Water {base.ToString()}, Water Clarity: {this.waterClarity:f2}";
        }
    }
}