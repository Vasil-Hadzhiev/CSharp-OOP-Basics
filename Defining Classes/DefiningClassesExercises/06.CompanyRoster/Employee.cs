namespace _06.CompanyRoster
{
    public class Employee
    {
        private string name;
        private double salary;
        private string department;
        private string email;
        private int age;

        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
            this.Email = "n/a";
            this.Age = -1;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public double Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }

        public string Deparment
        {
            get { return this.department; }
            private set { this.department = value; }
        }
    }
}
