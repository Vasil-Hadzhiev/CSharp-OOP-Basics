using System;
using System.Collections.Generic;

public class Topping
{
    private Dictionary<string, double> toppingMacros =
        new Dictionary<string, double>
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };

    private const int baseCaloriesPerGram = 2;
    private const int minWeight = 1;
    private const int maxWeight = 50;

    private string type;
    private double weight;

    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    public string Type
    {
        get { return this.type; }
        private set
        {
            if (value.ToLower() != "meat" && 
                value.ToLower() != "veggies" && 
                value.ToLower() != "cheese" && 
                value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            this.type = value;
        }
    }

    public double Weight
    {
        get { return this.weight; }
        private set
        {
            if (value < minWeight || value > maxWeight)
            {
                throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
            }

            this.weight = value;
        }
    }

    public double GetToppingCalories()
    {
        return toppingMacros[this.Type.ToLower()] * this.Weight * baseCaloriesPerGram;
    }

    public override string ToString()
    {
        return $"{GetToppingCalories():f2}";
    }
}

