namespace _03.WildFarm.Animals
{
    using System;
    using Foods;

    public class Mouse : Mammal
    {
        public Mouse(string type, string name, double weight, string livingRegion)
            : base(type, name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Vegetable")
            {
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Mouses are not eating that type of food!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override string ToString()
        {
            return $"{this.Type}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}