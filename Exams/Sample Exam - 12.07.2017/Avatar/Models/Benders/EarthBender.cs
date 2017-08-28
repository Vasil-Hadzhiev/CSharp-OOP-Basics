﻿namespace Avatar.Models.Benders
{
    public class EarthBender : Bender
    {
        private double groundSaturation;

        public EarthBender(string name, int power, double groundSaturation)
            : base(name, power)
        {
            this.groundSaturation = groundSaturation;
        }

        public override double GetTotalPower()
        {
            return this.Power * this.groundSaturation;
        }

        public override string ToString()
        {
            return $"Earth {base.ToString()}, Ground Saturation: {this.groundSaturation:f2}";
        }
    }
}