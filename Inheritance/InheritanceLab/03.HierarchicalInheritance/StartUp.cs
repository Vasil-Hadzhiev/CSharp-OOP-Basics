using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();

        Cat cat = new Cat();
        cat.Eat();
        cat.Meow();
    }
}

