namespace _09.RectangleIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var numberOfRectangles = tokens[0];
            var numberOfIntersections = tokens[1];

            var rectangles = new List<Rectangle>();

            for (int i = 0; i < numberOfRectangles; i++)
            {
                var rectangleTokens = Console.ReadLine().Split();

                var id = rectangleTokens[0];
                var width = double.Parse(rectangleTokens[1]);
                var height = double.Parse(rectangleTokens[2]);
                var xCoordinates = double.Parse(rectangleTokens[3]);
                var yCoordinates = double.Parse(rectangleTokens[4]);

                var rectangle = new Rectangle(id, width, height, xCoordinates, yCoordinates);
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < numberOfIntersections; i++)
            {
                var pairs = Console.ReadLine().Split();

                var firstID = pairs[0];
                var secondID = pairs[1];

                var firstRect = rectangles.First(r => r.ID == firstID);
                var secondRect = rectangles.First(r => r.ID == secondID);

                if (firstRect.XCoordinates > secondRect.XCoordinates + secondRect.Width ||
                    secondRect.XCoordinates > firstRect.XCoordinates + firstRect.Width)
                {
                    Console.WriteLine("false");
                }
                else if (firstRect.YCoordinates < secondRect.YCoordinates - secondRect.Height ||
                    secondRect.YCoordinates < firstRect.YCoordinates - firstRect.Height)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
            }
        }
    }
}