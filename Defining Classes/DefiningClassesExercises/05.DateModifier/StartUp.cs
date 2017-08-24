namespace _05.DateModifier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var date1 = Console.ReadLine();
            var date2 = Console.ReadLine();

            Console.WriteLine(DateModifier.DifferenceBetweenTwoDates(date1, date2));
        }
    }
}