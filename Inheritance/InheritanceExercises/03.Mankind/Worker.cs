namespace _03.Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHours;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHours = workHours;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHours
        {
            get
            {
                return this.workHours;
            }

            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHours = value;
            }
        }

        public decimal SalaryPerHour()
        {
            return this.weekSalary / ((decimal)this.WorkHours * 5);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkHours:f2}");
            sb.AppendLine($"Salary per hour: {this.SalaryPerHour():f2}");

            return sb.ToString();
        }
    }
}