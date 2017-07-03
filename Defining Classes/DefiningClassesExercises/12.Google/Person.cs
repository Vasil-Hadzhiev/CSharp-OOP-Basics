using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private Company company;
    private List<Pokemon> pokemons;
    private List<Parent> parents;
    private List<Child> children;
    private Car car;

    public Person(string name)
    {
        this.Name = name;
        this.Parents = new List<Parent>();
        this.Children = new List<Child>();
        this.Pokemons = new List<Pokemon>();
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Company Company
    {
        get { return this.company; }
        set { this.company = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
    }

    public List<Parent> Parents
    {
        get { return this.parents; }
        set { this.parents = value; }
    }

    public List<Child> Children
    {
        get { return this.children; }
        set { this.children = value; }
    }

    public Car Car
    {
        get { return this.car; }
        set { this.car = value; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.Name}");

        sb.AppendLine("Company:");

        if (this.Company != null)
        {
            sb.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:f2}");
        }

        sb.AppendLine("Car:");

        if (this.Car != null)
        {
            sb.AppendLine($"{this.Car.Model} {this.Car.Speed}");
        }

        sb.AppendLine("Pokemon:");

        foreach (var pokemon in this.Pokemons)
        {
            sb.AppendLine($"{pokemon.Name} {pokemon.Type}");
        }

        sb.AppendLine("Parents:");

        foreach (var parent in this.Parents)
        {
            sb.AppendLine($"{parent.Name} {parent.BirthDate}");
        }

        sb.AppendLine("Children:");

        foreach (var children in this.Children)
        {
            sb.AppendLine($"{children.Name} {children.BirthDate}");
        }

        return sb.ToString();
    }
}

