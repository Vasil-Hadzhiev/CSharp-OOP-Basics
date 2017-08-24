namespace _12.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                var tokens = inputLine
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var personName = tokens[0];
                var parameter = tokens[1];

                var person = people.FirstOrDefault(p => p.Name == personName);

                if (person == null)
                {
                    person = new Person(personName);
                    ProcessCommands(tokens, parameter, person);
                    people.Add(person);
                }
                else
                {
                    ProcessCommands(tokens, parameter, person);
                }
            }

            var name = Console.ReadLine();

            var chosenPerson = people.FirstOrDefault(p => p.Name == name);

            Console.WriteLine(chosenPerson.ToString());
        }

        private static void ProcessCommands(string[] tokens, string parameter, Person person)
        {
            switch (parameter)
            {
                case "company":
                    var companyName = tokens[2];
                    var department = tokens[3];
                    var salary = double.Parse(tokens[4]);
                    var company = new Company(companyName, department, salary);
                    person.Company = company;
                    break;
                case "pokemon":
                    var pokemonName = tokens[2];
                    var pokemonType = tokens[3];
                    var pokemon = new Pokemon(pokemonName, pokemonType);
                    person.Pokemons.Add(pokemon);
                    break;
                case "parents":
                    var parentName = tokens[2];
                    var parentBirthday = tokens[3];
                    var parent = new Parent(parentName, parentBirthday);
                    person.Parents.Add(parent);
                    break;
                case "children":
                    var childName = tokens[2];
                    var childBirthday = tokens[3];
                    var child = new Child(childName, childBirthday);
                    person.Children.Add(child);
                    break;
                case "car":
                    var carModel = tokens[2];
                    var carSpeed = int.Parse(tokens[3]);
                    Car car = new Car(carModel, carSpeed);
                    person.Car = car;
                    break;
            }
        }
    }
}