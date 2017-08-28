namespace NeedForSpeed.Models.Cars
{
    using System.Text;

    public abstract class Car
    {
        private string brand;
        private string model;
        private int yearOfProduction;
        private int horsePower;
        private int acceleration;
        private int suspension;
        private int durability;

        protected Car(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
        {
            this.brand = brand;
            this.model = model;
            this.yearOfProduction = yearOfProduction;
            this.HorsePower = horsePower;
            this.acceleration = acceleration;
            this.Suspension = suspension;
            this.durability = durability;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public int YearOfProduction
        {
            get
            {
                return this.yearOfProduction;
            }
        }

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }

            protected set
            {
                this.horsePower = value;
            }
        }

        public int Acceleration
        {
            get
            {
                return this.acceleration;
            }
        }

        public virtual int Suspension
        {
            get
            {
                return this.suspension;
            }

            protected set
            {
                this.suspension = value;
            }
        }

        public int Durability
        {
            get
            {
                return this.durability;
            }
        }

        public virtual void Tune(int tuneIndex, string tuneAddon)
        {
            this.HorsePower += tuneIndex;
            this.Suspension += tuneIndex * 50 / 100;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}");
            sb.AppendLine($"{this.HorsePower} HP, 100 m/h in {this.acceleration} s");
            sb.AppendLine($"{this.Suspension} Suspension force, {this.durability} Durability");

            return sb.ToString().Trim();
        }
    }
}