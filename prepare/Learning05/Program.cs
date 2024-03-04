using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("red",4),
            new Rectangle("green",3,4),
            new Circle("blue",2)
        };
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
        }
    }
}
public abstract class Shape
{
    protected string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}

public class Square : Shape
{
    private double _side;
    public Square(string color, double side):base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return Math.Pow(_side,2);
    }


}
public class Rectangle: Shape
{
    private double _length;
    private double _width;
    public Rectangle(string color, double length, double width):base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length*_width;
    }
}
public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius):base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return _radius * 2 * Math.PI;
    }
}