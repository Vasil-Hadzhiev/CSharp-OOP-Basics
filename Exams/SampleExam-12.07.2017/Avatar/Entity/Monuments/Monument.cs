public abstract class Monument
{
    private string name;

    protected Monument(string name)
    {
        this.name = name;
    }

    public abstract int GetAffinityBonus();

    public override string ToString()
    {
        var name = this.GetType().Name;
        var index = name.IndexOf("Monument");
        name = name.Insert(index, " ");

        return $"###{name}: {this.name}, ";
    }
}

