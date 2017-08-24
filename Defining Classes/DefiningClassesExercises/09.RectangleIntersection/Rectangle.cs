namespace _09.RectangleIntersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double xCoordinates;
        private double yCoordinates;

        public Rectangle(string id, double width, double height, double xCoordinates, double yCoordinates)
        {
            this.ID = id;
            this.Width = width;
            this.Height = height;
            this.XCoordinates = xCoordinates;
            this.YCoordinates = yCoordinates;
        }

        public string ID
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public double Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }

        public double XCoordinates
        {
            get { return this.xCoordinates; }
            private set { this.xCoordinates = value; }
        }

        public double YCoordinates
        {
            get { return this.yCoordinates; }
            private set { this.yCoordinates = value; }
        }
    }
}