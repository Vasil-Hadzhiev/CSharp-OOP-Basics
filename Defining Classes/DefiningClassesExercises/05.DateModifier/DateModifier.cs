namespace _05.DateModifier
{
    using System;
    using System.Globalization;

    public class DateModifier
    {
        public static string DifferenceBetweenTwoDates(string date1, string date2)
        {
            var firstDate = DateTime.ParseExact(date1, "yyyy MM dd", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(date2, "yyyy MM dd", CultureInfo.InvariantCulture);

            if (firstDate >= secondDate)
            {
                var difference = (firstDate - secondDate).Days;
                return difference.ToString();
            }
            else
            {
                var difference = (secondDate - firstDate).Days;
                return difference.ToString();
            }
        }
    }
}