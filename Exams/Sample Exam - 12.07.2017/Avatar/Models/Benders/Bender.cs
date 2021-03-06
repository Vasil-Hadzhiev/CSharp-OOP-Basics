﻿namespace Avatar.Models.Benders
{
    public abstract class Bender
    {
        private string name;
        private int power;

        protected Bender(string name, int power)
        {
            this.name = name;
            this.power = power;
        }

        public int Power
        {
            get
            {
                return this.power;
            }
        }

        public abstract double GetTotalPower();

        public override string ToString()
        {
            return $"Bender: {this.name}, Power: {this.power}";
        }
    }
}