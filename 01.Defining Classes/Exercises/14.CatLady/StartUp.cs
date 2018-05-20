namespace _14.CatLady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    
    public class StartUp
    {
        public static void Main()
        {
            var cats = new List<Cat>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var catInfo = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var catType = catInfo[0];
                var catName = catInfo[1];

                switch (catType)
                {
                    case "Cymric":
                        var furLength = double.Parse(catInfo[2]);
                        var cymric = new Cymric(catName, furLength);
                        cats.Add(cymric);
                        break;
                    case "Siamese":
                        var earSize = int.Parse(catInfo[2]);
                        var siamese = new Siamese(catName, earSize);
                        cats.Add(siamese);
                        break;
                    case "StreetExtraordinaire":
                        var decibelsOfMeows = int.Parse(catInfo[2]);
                        var streetExtraordinaire = new StreetExtraordinaire(catName, decibelsOfMeows);
                        cats.Add(streetExtraordinaire);
                        break;
                }
            }

            var catInfoName = Console.ReadLine();

            var ourCat = cats
                .FirstOrDefault(c => c.Name == catInfoName);

            Console.WriteLine(ourCat);
        }
    }
}