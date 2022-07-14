
using Encapsulation = Session_1.Encapsulation;
using Inheritance = Session_1.Inheritance;
using Polymorphism = Session_1.Polymorphism;
using Composition = Session_1.Composition;

class Program
{
    public static void RunEncapsulation() {
        /*
         * Usage is the same between Eager & Lazy versions -
         * ie the interface is the same, but the implementation is different
         * 
         * You can change the declaration of lazyRect to use EagerRectangle (or vice versa)
         * and the rest of the code will work without any additional changes
         */

        Encapsulation.LazyRectangle lazyRect = new Encapsulation.LazyRectangle(width: 1, height: 2);
        Encapsulation.EagerRectangle eagerRect = new Encapsulation.EagerRectangle(width: 1, height: 2);

        lazyRect.Width = 5;
        eagerRect.Width = 5;

        Console.WriteLine("  lazy rectangle: area={0}", lazyRect.Area);
        Console.WriteLine(" eager rectangle: area={0}", eagerRect.Area);
    }
    
    public static void RunInheritance() {
        /*
         * X/Y/Move is defined in Shape, Area is defined in Rectangle
         * 
         * Since both `rect` and `rotRect` inherit from `shape`, so they have X/Y/Move functionality
         * `rotRect` also inherits from `rect`, so it has the Area functionality
         */

        Inheritance.Shape shape = new Inheritance.Shape(x: 1, y: 2);
        Inheritance.Rectangle rect = new Inheritance.Rectangle(x: 1, y: 2, width: 2, height: 5);
        Inheritance.RotatedRectangle rotRect =
            new Inheritance.RotatedRectangle(x: 1, y: 2, width: 2, height: 5, rotation: 30);

        shape.Move(dx: 2);
        rect.Move(dx: 2);
        rotRect.Move(dx: 2);

        rotRect.Rotate(15);

        Console.WriteLine("        shape: x={0} y={1}", shape.X, shape.Y);
        Console.WriteLine("         rect: x={0} y={1} area={2}", rect.X, rect.Y, rect.Area);
        Console.WriteLine(" rotated rect: x={0} y={1} area={2} rotation={3}", rotRect.X, rotRect.Y, rotRect.Area, rotRect.Rotation);
    }
    
    public static void RunPolymorphism() {
        /*
         * Both `circle` and `rect` are stored in a list of Shape,
         * but, at runtime, it uses the specific implementation (Circle or Rectangle)
         * to calculate the area.
         * 
         * This is another example of the separation of interface & implementation
         */

        /*
         * In Shape, Area is marked abstract (virtual would also work),
         * so it uses the implementation in the subclass based on the
         * runtime type of the object (eg Circle or Rectangle).
         */
        Console.WriteLine("shapes with proper polymorphism");

        List<Polymorphism.Shape> shapes = new List<Polymorphism.Shape>() {
            new Polymorphism.Circle(2),
            new Polymorphism.Rectangle(2, 4)
        };

        for (int i = 0; i < shapes.Count; i++)
        {
            Console.WriteLine(" shape {0}: area={1:N}", i, shapes[i].Area);
        }

        /*
         * In ImproperShape, Area is not marked virtual or abstract,
         * so it uses the implementation in the base class (returning 0).
         */
        Console.WriteLine("\nshapes with improper polymorphism");

        Polymorphism.ImproperShape shapeCircle = new Polymorphism.ImproperCircle(2);
        Polymorphism.ImproperShape shapeRect = new Polymorphism.ImproperRectangle(2, 4);
        Console.WriteLine("    circle: {0:N} (should be 12.57)", shapeCircle.Area);
        Console.WriteLine(" rectangle: {0:N} (should be 8.00)", shapeRect.Area);

    }

    public static void RunComposition() {
        /*
         * Usage is the same between Composed & Uncomposed versions -
         * the additional abstraction the Composed class employs (via composition)
         * is invisible to the user
         */

        Composition.UncomposedShape uncomposedShape = new Composition.UncomposedShape(x: 5, y: 5);
        Composition.ComposedShape composedShape = new Composition.ComposedShape(x: 5, y: 5);

        uncomposedShape.Move(dx: 5, dy: 10);
        composedShape.Move(dx: 5, dy: 10);

        Console.WriteLine(" uncomposed shape: x={0} y={1}", uncomposedShape.X, uncomposedShape.Y);
        Console.WriteLine("   composed shape: x={0} y={1}", composedShape.X, composedShape.Y);
    }

    public static void Main()
    {
        Console.WriteLine("\n\n-- Encapsulation --");
        RunEncapsulation();

        Console.WriteLine("\n\n-- Inheritance --");
        RunInheritance();

        Console.WriteLine("\n\n-- Polymorphism --");
        RunPolymorphism();

        Console.WriteLine("\n\n-- Composition --");
        RunComposition();
    }
}
