﻿namespace _01.DefineAClassPerson
{
    using System;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            var personType = typeof(Person);
            var fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}