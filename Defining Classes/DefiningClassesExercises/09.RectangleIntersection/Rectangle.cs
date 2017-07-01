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
        set { this.id = value; }
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public double XCoordinates
    {
        get { return this.xCoordinates; }
        set { this.xCoordinates = value; }
    }

    public double YCoordinates
    {
        get { return this.yCoordinates; }
        set { this.yCoordinates = value; }
    }
}

