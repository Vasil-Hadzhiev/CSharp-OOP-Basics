namespace _12.Google.Models
{
    public class Child
    {
        private string name;
        private string birthDate;

        public Child(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string BirthDate
        {
            get { return this.birthDate; }
            private set { this.birthDate = value; }
        }
    }
}