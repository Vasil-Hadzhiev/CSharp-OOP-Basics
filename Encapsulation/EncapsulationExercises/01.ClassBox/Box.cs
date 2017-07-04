﻿using System.Text;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double GetSurfaceArea()
    {
        return
            2 * this.length * this.width + 
            2 * this.length * this.height + 
            2 * this.width * this.height;
    }

    public double GetLateralSurfaceArea()
    {
        return
            2 * this.length * this.height +
            2 * this.width * this.height;
    }

    public double GetVolume()
    {
        return this.length * this.width * this.height;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Surface Area - {this.GetSurfaceArea():f2}");
        sb.AppendLine($"Lateral Surface Area - {this.GetLateralSurfaceArea():f2}");
        sb.AppendLine($"Volume - {this.GetVolume():f2}");

        return sb.ToString();
    }
}
