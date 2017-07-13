using System;

public class Tiger : Felime
{
    public Tiger(string type, string name, double weight, string livingRegion) 
        : base(type, name, weight, livingRegion)
    {
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name == "Meat")
        {
            this.FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine("Tigers are not eating that type of food!");
        }
    }

    public override void MakeSound()
    {
        Console.WriteLine("ROAAR!!!");
    }

    public override string ToString()
    {
        return $"{this.Type}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

