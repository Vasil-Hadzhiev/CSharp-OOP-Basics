using System.Collections.Generic;

public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons = new List<Pokemon>();

    public Trainer(string name)
    {
        this.Name = name;
        this.Badges = 0;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Badges
    {
        get { return this.badges; }
        set { this.badges = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
    }
}

