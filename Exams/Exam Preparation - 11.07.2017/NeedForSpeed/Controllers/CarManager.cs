namespace NeedForSpeed.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using NeedForSpeed.Factories;
    using NeedForSpeed.Models;
    using NeedForSpeed.Models.Cars;
    using NeedForSpeed.Models.Races;
    
    public class CarManager
    {
        private CarFactory carFactory;
        private RaceFactory raceFactory;
        private Dictionary<int, Car> cars;
        private Dictionary<int, Race> races;
        private Garage garage;
        private List<int> closedRaces;

        public CarManager()
        {
            this.carFactory = new CarFactory();
            this.raceFactory = new RaceFactory();
            this.cars = new Dictionary<int, Car>();
            this.races = new Dictionary<int, Race>();
            this.garage = new Garage();
            this.closedRaces = new List<int>();
        }

        public void Register(int id, string type, string brand, string model, int year, int horsepower, int acceleration, int suspension, int durability)
        {
            var car = this.carFactory.CreateCar(type, brand, model, year, horsepower, acceleration, suspension, durability);

            this.cars.Add(id, car);
        }

        public string Check(int id)
        {
            return this.cars[id].ToString();
        }

        public void Open(int id, string type, int length, string route, int prizePool)
        {
            var race = this.raceFactory.CreateRace(type, length, route, prizePool);

            this.races.Add(id, race);
        }

        public void Participate(int carId, int raceId)
        {
            if (!this.garage.ParkedCars.Contains(carId))
            {
                if (!this.closedRaces.Contains(raceId))
                {
                    this.races[raceId].Participants.Add(carId, this.cars[carId]);
                }
            }
        }

        public string Start(int id)
        {
            if (this.races[id].Participants.Count == 0)
            {
                return "Cannot start the race with zero participants.";
            }

            this.closedRaces.Add(id);

            return this.races[id].ToString();
        }

        public void Park(int id)
        {
            foreach (var race in this.races.Where(r => !this.closedRaces.Contains(r.Key)))
            {
                if (race.Value.Participants.ContainsKey(id))
                {
                    return;
                }
            }

            this.garage.ParkCar(id);
        }

        public void Unpark(int id)
        {
            this.garage.UnparkCar(id);
        }

        public void Tune(int tuneIndex, string addOn)
        {
            foreach (var id in this.garage.ParkedCars)
            {
                this.cars[id].Tune(tuneIndex, addOn);
            }
        }
    }
}