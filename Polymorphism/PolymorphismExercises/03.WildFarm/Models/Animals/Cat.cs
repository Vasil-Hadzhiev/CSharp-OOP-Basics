namespace _03.WildFarm.Animals
{
    using Foods;
    using System;

    public class Cat : Felime
    {
        private string breed;

        public Cat(string type, string name, double weight, string livingRegion, string breed)
            : base(type, name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return $"{this.Type}[{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}