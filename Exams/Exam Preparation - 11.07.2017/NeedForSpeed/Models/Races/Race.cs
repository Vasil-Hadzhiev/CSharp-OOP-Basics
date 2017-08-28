namespace NeedForSpeed.Models.Races
{   
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NeedForSpeed.Models.Cars;

    public abstract class Race
    {
        private int length;
        private string route;
        private int prizePool;
        private Dictionary<int, Car> participants;

        public Race(int length, string route, int prizePool)
        {
            this.length = length;
            this.route = route;
            this.prizePool = prizePool;
            this.Participants = new Dictionary<int, Car>();
        }

        public Dictionary<int, Car> Participants
        {
            get
            {
                return this.participants;
            }

            private set
            {
                this.participants = value;
            }
        }

        public abstract int GetPerformance(int id);
        
        public override string ToString()
        {
            var sb = new StringBuilder();

            var winners = this.GetWinners();
            var prizes = this.GetPrizes();

            sb.AppendLine($"{this.route} - {this.length}");

            for (int i = 0; i < winners.Count; i++)
            {
                var car = winners.ElementAt(i);

                sb.AppendLine($"{i + 1}. {car.Value.Brand} {car.Value.Model} {this.GetPerformance(car.Key)}PP - ${prizes[i]}");
            }

            return sb.ToString().Trim();
        }

        private Dictionary<int, Car> GetWinners()
        {
            var winners = this.Participants
                .OrderByDescending(n => this.GetPerformance(n.Key))
                .Take(3)
                .ToDictionary(n => n.Key, n => n.Value);

            return winners;
        }

        private List<int> GetPrizes()
        {
            var prizes = new List<int>();

            prizes.Add(this.prizePool * 50 / 100);
            prizes.Add(this.prizePool * 30 / 100);
            prizes.Add(this.prizePool * 20 / 100);

            return prizes;
        }
    }
}