using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private const int minLength = 1;
    private const int maxLength = 15;
    private const int minToppings = 0;
    private const int maxToppings = 10;

    private string name;
    private int numberOfToppings;
    private Dough dough;
    private List<Topping> toppings;

    public Pizza(string name, int numberOfToppings)
    {
        this.Name = name;
        this.NumberOfToppings = numberOfToppings;
        this.toppings = new List<Topping>();
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrEmpty(value) || 
                string.IsNullOrWhiteSpace(value) || 
                value.Length < minLength || 
                value.Length > maxLength)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }

            this.name = value;
        }
    }

    public int NumberOfToppings
    {
        get { return this.numberOfToppings; }
        private set
        {
            if (value < minToppings || value > maxToppings)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.numberOfToppings = value;
        }
    }

    public Dough Dough
    {
        get { return this.dough; }
        set { this.dough = value; }
    }

    public void AddTopping(Topping topping)
    {
        this.toppings.Add(topping);
    }

    public double GetTotalCalories()
    {
        return dough.GetDoughCalories() + this.toppings.Sum(t => t.GetToppingCalories());
    }

    public override string ToString()
    {
        return $"{this.Name} - {GetTotalCalories():f2} Calories.";
    }
}

