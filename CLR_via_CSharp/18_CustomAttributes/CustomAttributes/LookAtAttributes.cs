// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
WriteSomethingElse();
Dummy.StaticShock();

void WriteSomethingElse()
{
    Console.WriteLine("something else");
}

class Dummy
{
    public static void StaticShock()
    {
        Console.WriteLine("static");
    }
}