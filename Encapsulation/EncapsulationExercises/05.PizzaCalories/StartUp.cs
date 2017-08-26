namespace _05.PizzaCalories
{
    using System;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    var tokens = input.Split();

                    var command = tokens[0];

                    switch (command)
                    {
                        case "Pizza":
                            var pizza = CreatePizza(tokens[1], int.Parse(tokens[2]));
                            Console.WriteLine(pizza.ToString());
                            break;
                        case "Dough":
                            var dough = CreateDough(tokens[1], tokens[2], double.Parse(tokens[3]));
                            Console.WriteLine(dough.ToString());
                            break;
                        case "Topping":
                            Topping topping = CreateTopping(tokens[1], double.Parse(tokens[2]));
                            Console.WriteLine(topping.ToString());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }      

        private static Pizza CreatePizza(string name, int numberOfToppings)
        {
            var pizza = new Pizza(name, numberOfToppings);

            var doughInfo = Console.ReadLine()
                .Split();

            var flourType = doughInfo[1];
            var bakingTechnique = doughInfo[2];
            var doughWeight = double.Parse(doughInfo[3]);

            var dough = new Dough(flourType, bakingTechnique, doughWeight);

            pizza.Dough = dough;

            for (int i = 0; i < numberOfToppings; i++)
            {
                var toppingInfo = Console.ReadLine().Split();

                var toppingType = toppingInfo[1];
                var toppingWeight = double.Parse(toppingInfo[2]);

                var topping = new Topping(toppingType, toppingWeight);

                pizza.AddTopping(topping);
            }

            return pizza;
        }

        private static Dough CreateDough(string flourType, string bakingTechnique, double doughWeight)
        {
            var dough = new Dough(flourType, bakingTechnique, doughWeight);

            return dough;
        }

        private static Topping CreateTopping(string toppingType, double toppingWeight)
        {
            var topping = new Topping(toppingType, toppingWeight);

            return topping;
        }
    }
}