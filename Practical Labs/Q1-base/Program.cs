class Shape
{
    protected string shapeName;
    public Shape(string name)
    {
        shapeName = name;
        Console.WriteLine("Shape constructor called for: " + shapeName);
    }
}
class Rectangle : Shape
{
    private double length;
    private double breadth;
    public Rectangle(double length, double breadth, string name) : base(name)
    {
        this.length = length;
        this.breadth = breadth;
    }
    public double calculateArea()
    {
        return length * breadth;
    }

    public void display()
    {
        Console.WriteLine("Area of " + shapeName + " is: " + calculateArea());
    }
}
class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle(9, 5, "Rectangle");
        r.display();
    }
}