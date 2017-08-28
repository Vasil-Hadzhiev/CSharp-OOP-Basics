namespace NeedForSpeed.Models.Cars
{
    using System.Text;

    public class ShowCar : Car
    {
        private int stars;

        public ShowCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
            : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
        {
        }

        public override void Tune(int tuneIndex, string tuneAddon)
        {
            base.Tune(tuneIndex, tuneAddon);
            this.stars += tuneIndex;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"{this.stars} *");

            return sb.ToString().Trim();
        }
    }
}