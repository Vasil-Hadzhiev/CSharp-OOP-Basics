namespace _05.PizzaCalories.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private const int MinLength = 1;
        private const int MaxLength = 15;
        private const int MinToppings = 0;
        private const int MaxToppings = 10;

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
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) ||
                    string.IsNullOrWhiteSpace(value) ||
                    value.Length < MinLength ||
                    value.Length > MaxLength)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public int NumberOfToppings
        {
            get
            {
                return this.numberOfToppings;
            }

            private set
            {
                if (value < MinToppings || value > MaxToppings)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this.numberOfToppings = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dough;
            }

            set
            {
                this.dough = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public double GetTotalCalories()
        {
            return this.dough.GetDoughCalories() + this.toppings.Sum(t => t.GetToppingCalories());
        }

        public override string ToString()
        {
            return $"{this.Name} - {GetTotalCalories():f2} Calories.";
        }
    }
}