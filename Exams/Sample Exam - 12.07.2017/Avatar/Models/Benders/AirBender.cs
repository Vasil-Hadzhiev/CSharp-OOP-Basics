namespace Avatar.Models.Benders
{
    public class AirBender : Bender
    {
        private double aerialIntegrity;

        public AirBender(string name, int power, double aerialIntegrity)
            : base(name, power)
        {
            this.aerialIntegrity = aerialIntegrity;
        }

        public override double GetTotalPower()
        {
            return this.Power * this.aerialIntegrity;
        }

        public override string ToString()
        {
            return $"Air {base.ToString()}, Aerial Integrity: {this.aerialIntegrity:f2}";
        }
    }
}