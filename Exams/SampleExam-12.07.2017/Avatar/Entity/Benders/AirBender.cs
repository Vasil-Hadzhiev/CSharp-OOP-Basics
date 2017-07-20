using System;

public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power, double areialIntegrity) 
        : base(name, power)
    {
        this.aerialIntegrity = areialIntegrity;
    }

    public override double GetTotalPower()
    {
        return base.Power * this.aerialIntegrity;
    }

    public override string ToString()
    {
        return base.ToString() + $"Aerial Integrity: {this.aerialIntegrity:f2}";
    }
}

