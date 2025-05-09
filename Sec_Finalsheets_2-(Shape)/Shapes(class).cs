namespace Shapes;

abstract class Shape
{
    protected double width;
    protected double height;

    public Shape(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public abstract double CalculateSurface();
}

class Rectangle : Shape
{
    public Rectangle(double width, double height) : base(width, height) { }
    public override double CalculateSurface() => width * height;
}

class Triangle : Shape
{
    public Triangle(double width, double height) : base(width, height) { }

    public override double CalculateSurface() => (width * height) / 2;
}

class Circle : Shape
{
    public Circle(double radius) : base(radius, radius) { }

    public override double CalculateSurface() => Math.PI * width * height; 
}