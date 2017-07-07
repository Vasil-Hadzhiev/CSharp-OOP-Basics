using System;
using System.Collections;
using System.Collections.Generic;

public class RandomList : ArrayList
{
    private Random rnd;
    private List<string> list;

    public RandomList()
    {
        this.list = new List<string>();
    }

    public string RandomString()
    {
        var element = rnd.Next(0, list.Count - 1);
        var str = list[element];
        list.Remove(str);

        return str;
    }
}

