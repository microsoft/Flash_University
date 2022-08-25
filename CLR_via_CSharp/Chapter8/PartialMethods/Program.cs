Console.WriteLine("Does it work");
//Directly from msdn docs

A a = new A();

a.OnSomethingHappened("It really happened");

public partial class A
{
    public partial void OnSomethingHappened(string s);
}

// This part can be in a separate file.
public partial class A
{
    // Comment out this method and the program
    // will still compile.
    public partial void OnSomethingHappened(String s)
    {
        Console.WriteLine("Something happened: {0}", s);
    }
}
