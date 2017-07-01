namespace _06.CompanyRoster
{
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
            this.email = "n/a";
            this.age = -1;
        }

        public string Name
        {
            get { return this.name ; }
            set { this.name = value; }
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
            set { this.salary = value; }
        }

        public string Deparment
        {
            get { return this.department; }
            set { this.department = value; }
        }
    }
}
