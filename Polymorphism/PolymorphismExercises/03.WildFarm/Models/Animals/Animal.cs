namespace _03.WildFarm.Animals
{
    using Foods;

    public abstract class Animal
    {
        private string name;
        private string type;
        private double weight;
        private int foodEaten;

        public Animal(string type, string name, double weight)
        {
            this.Type = type;
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }
        public abstract void MakeSound();

        public abstract void Eat(Food food);
    }
}