using System.Collections.Generic;

public class Family
{
    private List<Person> people = new List<Person>();

    public void AddMember(Person member)
    {
        People.Add(member);
    }

    public Person GetOldestMember()
    {
        var oldestAge = int.MinValue;
        var oldestPerson = new Person(string.Empty, 0);

        for (int i = 0; i < People.Count; i++)
        {
            var currentPerson = new Person(People[i].Name, People[i].Age);

            if (People[i].Age > oldestAge)
            {
                oldestAge = People[i].Age;
                oldestPerson = currentPerson;
            }
        }

        return oldestPerson;
    }

    public List<Person> People
    {
        get { return this.people; }
        set { this.people = value; }
    }
}

