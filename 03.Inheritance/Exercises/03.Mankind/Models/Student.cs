namespace _03.Mankind.Models
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            private set
            {
                var isValid = false;
                var pattern = @"^([0-9[a-zA-Z]{5,10})$";
                var regex = new Regex(pattern);
                var match = regex.Match(value);

                if (match.Success)
                {
                    isValid = true;
                }

                if (isValid == false)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");

            return sb.ToString();
        }
    }
}