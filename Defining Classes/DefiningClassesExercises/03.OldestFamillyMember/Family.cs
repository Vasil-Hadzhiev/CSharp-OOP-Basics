namespace _03.OldestFamillyMember
{
    using System.Collections.Generic;

    public class Family
    {
        private List<Person> people = new List<Person>();

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public Person GetOldestMember()
        {
            var oldestAge = int.MinValue;
            var oldestPerson = new Person(string.Empty, 0);

            for (int i = 0; i < this.people.Count; i++)
            {
                var currentPerson = new Person(this.people[i].Name, this.people[i].Age);

                if (this.people[i].Age > oldestAge)
                {
                    oldestAge = this.people[i].Age;
                    oldestPerson = currentPerson;
                }
            }

            return oldestPerson;
        }
    }
}