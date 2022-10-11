using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1.Inheritance
{
    /**
     * In this example, Rectangle inherits from Shape, and RotatedRectangle
     * inherits from Rectangle. Each class builds on its superclass,
     * adding functionality specific to the subclass.
     * 
     * In other words a RotatedRectangle is a Rectangle, and a Rectangle is a Shape
     * 
     * Inheritance also enables code reuse across sibling classes -
     * a Triangle class that inherits from Shape could be added; the location logic
     * would be defined in a single place (Shape) but both Triangle and Rectangle
     * classes use it.
     * 
     * However, inheritance can cause issues in the future if not thought through
     * completely. This example is not necessarily the best design - what if we
     * wanted to add a Triangle AND a RotatedTriangle class? 
     */

    /**
     * The base class - contains location logic (eg x, y)
     */
    public class Shape
    {
        public Shape(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public void Move(int dx = 0, int dy = 0)
        {
            X = X + dx;
            Y = Y + dy;
        }
    }

    /**
     * contains rectangle specific logic (eg width, height, area)
     */
    public class Rectangle : Shape
    {
        public Rectangle(int x = 0, int y = 0, int width = 0, int height = 0): 
            base(x, y)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;

        public int Area => Width * Height;
    }

    /**
     * contains rotation logic
     */
    public class RotatedRectangle : Rectangle
    {
        public RotatedRectangle(int x = 0, int y = 0, int width = 0, int height = 0, double rotation = 0):
            base(x, y, width, height)
        {
            Rotation = rotation;
        }

        public double Rotation { get; set; }

        public void Rotate(double degrees)
        {
            Rotation = Rotation + degrees;
        }
    }
}
