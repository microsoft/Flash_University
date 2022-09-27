namespace Session_9.Dependency_Injection;

#region behavior

public class Mammal
{
    public void Eat()
    {
        Console.WriteLine("eating");
    }
}

public interface IWalkable
{
    public void Walk();
}

public class Walkable : IWalkable
{
    public void Walk()
    {
        Console.WriteLine("walking");
    }
}

public interface IFlyable
{
    public void Fly();
}

public class Flyable : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("flying");
    }
}


#endregion

#region animals

/*
 * This uses "constructor" injection
 */
public class Dog : Mammal
{
    private readonly IWalkable _walkable;

    public Dog(IWalkable walkable)
    {
        this._walkable = walkable;
    }

    public void Walk()
    {
        this._walkable.Walk();
    }
}

/*
 * This uses "setter method" injection
 */
public class Bat : Mammal
{
    private IFlyable? _flyable;

    public void SetFlyable(IFlyable flyable)
    {
        _flyable = flyable;
    }

    public void Fly()
    {
        this._flyable?.Fly();
    }
}

#endregion

public class Example
{
    public static void Run()
    {
        Walkable walkable = new Walkable();
        Dog fido = new Dog(walkable);

        fido.Eat();
        fido.Walk();

        Flyable flyable = new Flyable();
        Bat bat = new Bat();

        bat.SetFlyable(flyable);
        bat.Eat();
        bat.Fly();
    }
}