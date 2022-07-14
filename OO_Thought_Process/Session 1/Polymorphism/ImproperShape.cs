
namespace Session_1.Polymorphism
{
    /*
     * This example demonstrates how non abstract/virtual methods and properties
     * are handled with inheritance.
     * 
     * Because Area is not declared abstract or virtual, when a subclass is used
     * as the base class, it will use the Area implementation defined on the
     * base class rather than using Area from the subclass.
     * 
     * "Using a subclass as the base class" refers to assigning a subclass object
     * to a variable declared as the superclass, or passing a subclass object as
     * a method param that's declared as the superclass, etc. Here are some examples:
     * 
     * ImproperShape shape = new ImproperCircle(1);
     * 
     * getArea(new ImproperCircle(1))
     * // getArea is - public double getArea(ImproperShape shape)
     */

    /**
     * The base class
     * 
     * Area is not declared abstract or virtual, so it will not delegate
     * to the runtime type of the object
     */
    public class ImproperShape
    {
        public double Area { get => 0; }
    }

    /**
     * Circle implements Area for circles (pi*r^2)
     */
    public class ImproperCircle : ImproperShape
    {
        public ImproperCircle(double radius = 0)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public new double Area => Radius * Radius * System.Math.PI;
    }

    /**
     * Rectangle implements Area for rectangles (w*h)
     */
    public class ImproperRectangle : ImproperShape
    {
        public ImproperRectangle(double width = 0, double height = 0)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public new double Area => Width * Height;
    }
}
