
namespace Session_1.Polymorphism
{
    /*
     * This example demonstrates different implementations of
     * a common interface.
     * 
     * Both Circle and Rectangle can be used as a Shape;
     * and when .Area is accessed it will use the correct implementation.
     * 
     * The important thing is that Area is declared abstract (or virtual) on
     * the base Shape class. The abstract/virtual keyword makes C# look at
     * the runtime type of the object and find the property/method there.
     * 
     * Without the abstract/virtual keyword, when a subclass is used as
     * the base class it will just use the property/method definition
     * on the base class - it won't look into the subclass.
     * (See ImproperShape.cs and Program.cs for an example)
     */
    
    /**
     * The base class - it provides no implementation
     */
    public abstract class Shape
    {
        public abstract double Area { get; }

        // or could be virtual
        //public virtual double Area { get => 0; }
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
