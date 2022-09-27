namespace Session_9.Inheritance;

#region base class
public class Mammal
{
    public void Eat()
    {
        Console.WriteLine("eating");
    }
}

#endregion

#region animals
public class Bat : Mammal {
    public void Fly()
    {
        Console.WriteLine("flying");
    }
}

public class Dog : Mammal
{
    public void Walk()
    {
        Console.WriteLine("flying");
    }
}

#endregion

#region example

public class Example
{
    public static void Run()
    {
        Dog fido = new Dog();
        fido.Eat();
        fido.Walk();

        Bat bat = new Bat();
        bat.Eat();
        bat.Fly();
    }
}

#endregion