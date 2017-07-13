using System;

public class Zebra : Mammal
{
    public Zebra(string type, string name, double weight, string livingRegion) 
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
            Console.WriteLine("Zebras are not eating that type of food!");
        }
    }

    public override void MakeSound()
    {
        Console.WriteLine("Zs");
    }

    public override string ToString()
    {
        return $"{this.Type}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

