namespace _14.CatLady.Models
{
    public abstract class Cat
    {
        private string name;

        protected Cat(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
