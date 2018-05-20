namespace _04.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            var inputPeople = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var personInfo in inputPeople)
            {
                var tokens = personInfo.Split('=');

                var personName = tokens[0];
                var personMoney = decimal.Parse(tokens[1]);

                try
                {
                    var person = new Person(personName, personMoney);
                    people.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
                
            var inputProducts = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var productInfo in inputProducts)
            {
                var tokens = productInfo.Split('=');

                var productName = tokens[0];
                var productCost = decimal.Parse(tokens[1]);

                try
                {
                    var product = new Product(productName, productCost);
                    products.Add(product);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }              

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "END")
                {
                    break;
                }

                var tokens = inputLine.Split();

                var personName = tokens[0];
                var productName = tokens[1];

                var person = people
                    .FirstOrDefault(p => p.Name == personName);

                var product = products
                    .FirstOrDefault(p => p.Name == productName);

                try
                {
                    person.BuyProduct(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}