//basically page 94

internal class Employee{}
internal class Manager: Employee{}

public sealed class Program
{
    public static void Main()
    {
        Console.WriteLine("Goal here is to see something that compiles, but casting fails at run time. Identify the problem");
        Manager m = new Manager();
        PromoteEmployee(m);

        String dummyString = "Just a placeholder";
        // PromoteEmployee(dummyString);
        DateTime dummydatetime = DateTime.Now;
        // PromoteEmployee(dummydatetime);
        //One point RIchter makes is that exception handling, especially runtime exception handling, is expensive. Here are a few ideas/build in methods to handle it

        //this basically guarantees the type of the value, this should never run
        if (dummyString is Employee)
        {
            PromoteEmployee(dummyString);
        }
        //In this case, it's always tru\e, but if we see the other case, it';s ahndled

        // Employee w = m as Employee;
        Object o = new Object();
        Employee w = o as Employee;
        if (w != null)
        {
            PromoteEmployee(m);
        }
    }

    public static void PromoteEmployee(Object O)
    {
        Employee e = (Employee)O;
    }
}