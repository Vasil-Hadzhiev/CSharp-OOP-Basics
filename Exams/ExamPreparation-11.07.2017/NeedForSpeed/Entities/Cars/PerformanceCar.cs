using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Horsepower += (this.Horsepower * 50 / 100);
        this.Suspension -= (this.Suspension * 25 / 100);
        this.addOns = new List<string>();
    }

    public override void Tune(int tuneIndex, string tuneAddOn)
    {
        base.Tune(tuneIndex, tuneAddOn);
        this.addOns.Add(tuneAddOn);
    }

    public override string ToString()
    {
        var sb = new StringBuilder(base.ToString());

        if (this.addOns.Count > 0)
        {
            sb.AppendLine("Add-ons: " + string.Join(", ", addOns));
        }
        else
        {
            sb.AppendLine("Add-ons: None");
        }

        return sb.ToString().Trim();
    }
}

