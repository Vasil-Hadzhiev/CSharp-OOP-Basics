using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        while (true)
        {
            var animal = Console.ReadLine();

            if (animal == "Beast!")
            {
                break;
            }

            var tokens = Console.ReadLine().
                Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).
                ToArray();

            try
            {
                switch (animal)
                {
                    case "Cat":
                        var cat = new Cat(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        Console.WriteLine(cat.ToString());
                        break;
                    case "Dog":
                        var dog = new Dog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        Console.WriteLine(dog.ToString());
                        break;
                    case "Frog":
                        var frog = new Frog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        Console.WriteLine(frog.ToString());
                        break;
                    case "Tomcat":
                        var tomcat = new Tomcat(tokens[0], int.Parse(tokens[1]), "Male");
                        Console.WriteLine(tomcat.ToString());
                        break;
                    case "Kitten":
                        var kitten = new Kitten(tokens[0], int.Parse(tokens[1]), "Female");
                        Console.WriteLine(kitten.ToString());
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

