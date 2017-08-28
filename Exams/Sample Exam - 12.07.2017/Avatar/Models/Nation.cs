namespace Avatar.Models
{ 
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Avatar.Models.Benders;
    using Avatar.Models.Monuments;

    public class Nation
    {
        private List<Bender> benders;
        private List<Monument> monuments;

        public Nation()
        {
            this.benders = new List<Bender>();
            this.monuments = new List<Monument>();
        }

        public void AddBender(Bender bender)
        {
            this.benders.Add(bender);
        }

        public void AddMonument(Monument monument)
        {
            this.monuments.Add(monument);
        }

        public double GetTotalPower()
        {
            var power = this.benders.Sum(b => b.GetTotalPower());
            var bonus = this.monuments.Sum(m => m.GetAffinityBonus());

            power += (power / 100) * bonus;

            return power;
        }

        public void RemovePower()
        {
            this.benders.Clear();
            this.monuments.Clear();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (this.benders.Any())
            {
                sb.AppendLine("Benders:");

                foreach (var bender in this.benders)
                {
                    sb.AppendLine($"###{bender.ToString()}");
                }
            }
            else
            {
                sb.AppendLine("Benders: None");
            }

            if (this.monuments.Any())
            {
                sb.AppendLine("Monuments:");

                foreach (var monument in this.monuments)
                {
                    sb.AppendLine($"###{monument.ToString()}");
                }
            }
            else
            {
                sb.AppendLine("Monuments: None");
            }

            return sb.ToString().Trim();
        }
    }
}