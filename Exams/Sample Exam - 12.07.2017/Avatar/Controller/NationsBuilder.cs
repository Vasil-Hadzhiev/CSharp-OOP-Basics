namespace Avatar.Controller
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Avatar.Factories;
    using Avatar.Models;

    public class NationsBuilder
    {
        private Dictionary<string, Nation> nations;
        private BenderFactory benderFactory;
        private MonumentFactory monumentFactory;
        private List<string> wars;

        public NationsBuilder()
        {
            this.nations = new Dictionary<string, Nation>
        {
            { "Air", new Nation() },
            { "Fire", new Nation() },
            { "Water", new Nation() },
            { "Earth", new Nation() }
        };
            this.benderFactory = new BenderFactory();
            this.monumentFactory = new MonumentFactory();
            this.wars = new List<string>();
        }

        public void AssignBender(List<string> benderArgs)
        {
            var type = benderArgs[1];
            var name = benderArgs[2];
            var power = int.Parse(benderArgs[3]);
            var specialPower = double.Parse(benderArgs[4]);

            var bender = this.benderFactory.CreateBender(type, name, power, specialPower);

            this.nations[type].AddBender(bender);
        }

        public void AssignMonument(List<string> monumentArgs)
        {
            var type = monumentArgs[1];
            var name = monumentArgs[2];
            var affinity = int.Parse(monumentArgs[3]);

            var monument = this.monumentFactory.CreateMonument(type, name, affinity);

            this.nations[type].AddMonument(monument);
        }

        public string GetStatus(string nationsType)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{nationsType} Nation");
            sb.AppendLine(this.nations[nationsType].ToString());

            return sb.ToString().Trim();
        }

        public void IssueWar(string nationsType)
        {
            this.wars.Add(nationsType);

            var winner = this.nations
                .OrderByDescending(n => n.Value.GetTotalPower())
                .First()
                .Key;

            foreach (var nation in this.nations)
            {
                if (nation.Key != winner)
                {
                    nation.Value.RemovePower();
                }
            }
        }

        public string GetWarsRecord()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < this.wars.Count; i++)
            {
                sb.AppendLine($"War {i + 1} issued by {this.wars[i]}");
            }

            return sb.ToString().Trim();
        }
    }
}