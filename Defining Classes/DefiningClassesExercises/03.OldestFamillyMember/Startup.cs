namespace _03.OldestFamilyMember
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            var addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var n = int.Parse(Console.ReadLine());

            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                var name = tokens[0];
                var age = int.Parse(tokens[1]);

                var person = new Person(name, age);

                family.AddMember(person);
            }

            var oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}