using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private Dictionary<int, Car> participants;
    private List<Car> winners;

    protected Race(int length, string route, int prizePool)
    {
        this.length = length;
        this.route = route;
        this.prizePool = prizePool;
        this.Participants = new Dictionary<int, Car>();
        this.winners = new List<Car>();
    }

    public Dictionary<int, Car> Participants
    {
        get { return this.participants; }
        set { this.participants = value; }
    }

    public abstract int GetPerformance(int id);

    public Dictionary<int, Car> GetWinners()
    {
        var winnerz = this.Participants.
            OrderByDescending(n => this.GetPerformance(n.Key)).
            Take(3).
            ToDictionary(n => n.Key, m => m.Value);

        return winnerz;
    }

    public List<int> GetPrizes()
    {
        var prizes = new List<int>();
        prizes.Add((this.prizePool * 50) / 100);
        prizes.Add((this.prizePool * 30) / 100);
        prizes.Add((this.prizePool * 20) / 100);

        return prizes;
    }

    public string StartRace()
    {

        var winners = GetWinners();
        var prizes = GetPrizes();
        var sb = new StringBuilder();
        sb.AppendLine($"{this.route} - {this.length}");

        for (int i = 0; i < winners.Count; i++)
        {
            var car = winners.ElementAt(i);

            sb.AppendLine($"{i + 1}. {car.Value.Brand} {car.Value.Model} {this.GetPerformance(car.Key)}PP - ${prizes[i]}");
        }

        return sb.ToString().Trim();
    }
}

