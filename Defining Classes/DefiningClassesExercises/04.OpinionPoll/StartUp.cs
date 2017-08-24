namespace _04.OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                var name = tokens[0];
                var age = int.Parse(tokens[1]);

                var person = new Person(name, age);

                people.Add(person);
            }

            people
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList()
                .ForEach(x =>
                {
                    Console.WriteLine($"{x.Name} - {x.Age}");
                });
        }
    }
}
