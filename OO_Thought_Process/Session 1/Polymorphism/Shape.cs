
namespace Session_1.Polymorphism
{
    /*
     * This example demonstrates different implementations of
     * a common interface.
     * 
     * Both Circle and Rectangle can be used as a Shape;
     * and when .Area is accessed it will use the correct implementation.
     */
    
    /**
     * The base class - it provides no implementation
     */
    public abstract class Shape
    {
        public abstract double Area { get; }
    }

    /**
     * Circle implements Area for circles (pi*r^2)
     */
    public class Circle : Shape
    {
        public Circle(double radius = 0)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double Area => Radius * Radius * System.Math.PI;
    }

    /**
     * Rectangle implements Area for rectangles (w*h)
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
}
