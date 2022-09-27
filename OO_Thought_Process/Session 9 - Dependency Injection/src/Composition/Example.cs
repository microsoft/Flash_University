namespace Session_9.Composition;

/*
 * How easy would it be to add a Whale (swim) class?
 */

#region behavior classes

public class Mammal
{
    public void Eat()
    {
        Console.WriteLine("eating");
    }
}

public class Walkable
{
    public void Walk()
    {
        Console.WriteLine("walking");
    }
}

public class Flyable
{
    public void Fly()
    {
        Console.WriteLine("flying");
    }
}

#endregion

#region animals

public class Dog
{
    public readonly Mammal Mammal = new Mammal();
    public readonly Walkable Walker = new Walkable();
}

public class Bat
{
    public readonly Mammal Mammal = new Mammal();
    public readonly Flyable Flyer = new Flyable();
}

#endregion

#region example

public class Example
{
    public static void Run()
    {
        Dog fido = new Dog();
        fido.Mammal.Eat();
        fido.Walker.Walk();

        Bat bat = new Bat();
        bat.Mammal.Eat();
        bat.Flyer.Fly();
    }
}

#endregion