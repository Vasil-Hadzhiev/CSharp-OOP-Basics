using System;
using System.Collections.Generic;

public class Dough
{
    private static readonly Dictionary<string, double> flourMacros =
        new Dictionary<string, double>
        {
            { "white", 1.5 },
            { "wholegrain", 1.0 }
        };

    private static readonly Dictionary<string, double> bakingMacros =
        new Dictionary<string, double>
        {
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1.0 }
        };

    private const int baseCaloriesPerGram = 2;
    private const int minWeight = 1;
    private const int maxWeight = 200;

    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        get { return this.flourType; }
        private set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.flourType = value;
        }
    }

    public string BakingTechnique
    {
        get { return this.bakingTechnique; }
        private set
        {
            if (value.ToLower() != "crispy" &&
                value.ToLower() != "chewy" &&
                value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.bakingTechnique = value;
        }
    }

    public double Weight
    {
        get { return this.weight; }
        private set
        {
            if (value < minWeight || value > maxWeight)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            this.weight = value;
        }
    }

    public double GetDoughCalories()
    {
        return baseCaloriesPerGram * this.Weight * 
            flourMacros[this.FlourType.ToLower()] * 
            bakingMacros[this.BakingTechnique.ToLower()];
    }

    public override string ToString()
    {
        return $"{GetDoughCalories():f2}";
    }
}

