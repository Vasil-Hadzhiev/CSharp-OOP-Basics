using System;

public class StartUp
{
    public static void Main()
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            var animalInfo = input.Split();

            var animalType = animalInfo[0];
            var animalName = animalInfo[1];
            var weight = double.Parse(animalInfo[2]);
            var livingRegion = animalInfo[3];

            var foodInfo = Console.ReadLine().Split();

            var foodType = foodInfo[0];
            var foodQuantity = int.Parse(foodInfo[1]);

            Food food;

            if (foodType == "Vegetable")
            {
                food = new Vegetable(foodQuantity);
            }
            else
            {
                food = new Meat(foodQuantity);
            }

            switch (animalType)
            {
                case "Cat":
                    var breed = animalInfo[4];
                    var cat = new Cat(animalType, animalName, weight, livingRegion, breed);                  
                    cat.MakeSound();
                    cat.Eat(food);
                    Console.WriteLine(cat);
                    break;
                case "Tiger":
                    var tiger = new Tiger(animalType, animalName, weight, livingRegion);
                    tiger.MakeSound();
                    tiger.Eat(food);
                    Console.WriteLine(tiger);
                    break;
                case "Mouse":
                    var mouse = new Mouse(animalType, animalName, weight, livingRegion);
                    mouse.MakeSound();
                    mouse.Eat(food);                   
                    Console.WriteLine(mouse);
                    break;
                case "Zebra":
                    var zebra = new Zebra(animalType, animalName, weight, livingRegion);                 
                    zebra.MakeSound();
                    zebra.Eat(food);
                    Console.WriteLine(zebra);
                    break;
            }
        }
    }
}

