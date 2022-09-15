// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, this is 'common way of doing things. Across Languages");

Employee e = new Employee();
e.Name = "Jeff The Richter";
e.Age = 48;

Console.WriteLine(e.Name);

//What is the problem with this?

e.Age = -5;

//giving direct access (as we've seen in OO, allows for some unconstrained behavior)


public sealed class Employee
{
    public String Name;
    public Int32 Age;
}

public sealed class EncapsulatedEmployee
{
    private String Name;
    private Int32 Age;

    public String GetName()
    {
        return Name;
    }
    public  void SetName(String name)
    { 
        Name = name;
    }
    public int GetAge()
    {
        return Age;
    }
    public void SetAge(int newAge)
    {
        Age = newAge;
    }
}