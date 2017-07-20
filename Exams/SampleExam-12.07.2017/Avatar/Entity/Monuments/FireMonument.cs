﻿using System;

public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name, int fireAffinity) 
        : base(name)
    {
        this.fireAffinity = fireAffinity;
    }

    public override int GetAffinityBonus()
    {
        return fireAffinity;
    }

    public override string ToString()
    {
        return base.ToString() + $"Fire Affinity: {this.fireAffinity}";
    }
}
