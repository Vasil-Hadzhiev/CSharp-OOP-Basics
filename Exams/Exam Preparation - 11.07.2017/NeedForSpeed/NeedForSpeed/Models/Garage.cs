namespace NeedForSpeed.Models
{
    using System.Collections.Generic;

    public class Garage
    {
        private List<int> parkedCars;

        public Garage()
        {
            this.ParkedCars = new List<int>();
        }

        public List<int> ParkedCars
        {
            get
            {
                return this.parkedCars;
            }

            private set
            {
                this.parkedCars = value;
            }
        }

        public void ParkCar(int id)
        {
            this.ParkedCars.Add(id);
        }

        public void UnparkCar(int id)
        {
            this.ParkedCars.Remove(id);
        }
    }
}