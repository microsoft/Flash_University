namespace Session_5.Concretization;

/*
 * This example demonstrates Concretization inheritance
 */

/**
 * The base Shape class is abstract - you cannot create
 * just a 'shape', it must be a concrete kind of shape.
 *
 * The shape class has the Area property (all shapes have an area),
 * but it is abstract since the implementation varies by
 * the kind of shape.
 */
public abstract class Shape
{
    public abstract double Area { get; }
}

/**
 * Circle is a concrete kind of shape
 */
public class Circle : Shape
{
    public Circle(double radius = 0)
    {
        Radius = radius;
    }

    public double Radius { get; set; }

    public override double Area => Radius * Radius * Math.PI;
}

/**
 * Rectangle is a concrete kind of shape
 */
public class Rectangle : Shape
{
    public Rectangle(double width = 0, double height = 0)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area => Width * Height;
}