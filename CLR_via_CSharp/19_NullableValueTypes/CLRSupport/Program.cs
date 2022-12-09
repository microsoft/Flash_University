// Boxing
int? a=null;
Object o = a;

Console.WriteLine($"o is null = {o}");

a = 5;
o = a;
Console.WriteLine($"o is a {o.GetType()}");

//Unboxing

Object c = 42;

int? c = 