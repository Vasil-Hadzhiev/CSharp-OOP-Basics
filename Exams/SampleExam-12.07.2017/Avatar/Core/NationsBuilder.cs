using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> wars;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            { "Air", new Nation() },
            { "Earth", new Nation() },
            { "Fire", new Nation() },
            { "Water", new Nation() },
        };
        this.wars = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[1];
        var name = benderArgs[2];
        var power = int.Parse(benderArgs[3]);
        var secondaryParameter = double.Parse(benderArgs[4]);

        switch (type)
        {
            case "Air":
                this.nations[type].AddBender(new AirBender(name, power, secondaryParameter));
                break;
            case "Earth":
                this.nations[type].AddBender(new EarthBender(name, power, secondaryParameter));
                break;
            case "Fire":
                this.nations[type].AddBender(new FireBender(name, power, secondaryParameter));
                break;
            case "Water":
                this.nations[type].AddBender(new WaterBender(name, power, secondaryParameter));
                break;
        }
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[1];
        var name = monumentArgs[2];
        var affinity = int.Parse(monumentArgs[3]);

        switch (type)
        {
            case "Air":
                this.nations[type].AddMonument(new AirMonument(name, affinity));
                break;
            case "Earth":
                this.nations[type].AddMonument(new EarthMonument(name, affinity));
                break;
            case "Fire":
                this.nations[type].AddMonument(new FireMonument(name, affinity));
                break;
            case "Water":
                this.nations[type].AddMonument(new WaterMonument(name, affinity));
                break;
        }
    }
    public string GetStatus(string nationsType)
    {
        var sb = new StringBuilder();

        sb.AppendLine(nationsType + $" Nation");
        sb.AppendLine(this.nations[nationsType].ToString());

        return sb.ToString().Trim();

    }
    public void IssueWar(string nationsType)
    {
        this.wars.Add(nationsType);
        var winner = this.nations.
            OrderByDescending(n => n.Value.GetTotalPoints()).First();

        foreach (var nation in this.nations)
        {
            if (nation.Key != winner.Key)
            {
                nation.Value.EraseNationPowers();
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

