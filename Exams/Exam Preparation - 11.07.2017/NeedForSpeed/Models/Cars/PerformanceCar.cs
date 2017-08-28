namespace NeedForSpeed.Models.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PerformanceCar : Car
    {
        private List<string> addOns;

        public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
            : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
        {
            this.HorsePower += this.HorsePower * 50 / 100;
            this.Suspension -= this.Suspension * 25 / 100;
            this.addOns = new List<string>();
        }

        public override void Tune(int tuneIndex, string tuneAddon)
        {
            base.Tune(tuneIndex, tuneAddon);
            this.addOns.Add(tuneAddon);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if (this.addOns.Any())
            {
                sb.AppendLine($"Add-ons: {string.Join(", ", this.addOns)}");
            }
            else
            {
                sb.AppendLine("Add-ons: None");
            }

            return sb.ToString().Trim();
        }
    }
}