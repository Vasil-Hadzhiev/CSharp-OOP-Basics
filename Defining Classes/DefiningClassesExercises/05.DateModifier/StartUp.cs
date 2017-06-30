using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string date1 = Console.ReadLine();
        string date2 = Console.ReadLine();

        Console.WriteLine(DateModifier.DifferenceBetweenTwoDates(date1, date2));
    }
}

