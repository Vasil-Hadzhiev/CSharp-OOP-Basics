public abstract class Bender
{
    private string name;
    private int power;

    protected Bender(string name, int power)
    {
        this.power = power;
        this.name = name;
    }

    public int Power => this.power;

    public abstract double GetTotalPower();

    public override string ToString()
    {
        var name = this.GetType().Name;
        var index = name.IndexOf("Bender");
        name = name.Insert(index, " ");

        return $"###{name}: {this.name}, Power: {this.power}, ";
    }
}

