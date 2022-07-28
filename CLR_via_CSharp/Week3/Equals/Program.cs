// See https://aka.ms/new-console-template for more information

using Equals;
// there are 2 equality checks

//we're creating two primitive types
//where will they be stored
int a = 1;
int b = 2;

Console.WriteLine(a==b); //fair enough, they aren't the same number
Console.WriteLine(a.Equals(b)); //also fair enough
b= a; //based off of today, what happens here
Console.WriteLine(a.Equals(b)); // same pointer, to same object, makes sense
b= 3; //what is going on here?
Console.WriteLine("The value of a is {0}", a);
Console.WriteLine(a.Equals(b));

//it's worth remembering that this is all on the stack; it's going to create a new object for each one, see ppt example as line 13 copies and instance

//lets look at something that's stored in the heap


//again,look at key word here 
SimpleClass c = new SimpleClass();
SimpleClass d = new SimpleClass();
Console.WriteLine(c.x); //fun fact, ints are instantiated at 0 here
c.x = 1;
d.x = 2;

Console.WriteLine(c.Equals(d));
c = d;
Console.WriteLine(d.Equals(c));

SimpleStruct e = new SimpleStruct();
SimpleStruct f = new SimpleStruct();

e = f;

Console.WriteLine(e.Equals(f));
e.x = 1;

Console.WriteLine(e.Equals(f));


InnocentClass z = new InnocentClass();
SimpleClass y = new SimpleClass();
Console.WriteLine(z.Equals(y));
Console.WriteLine(y.Equals(z));

Console.WriteLine(z.GetHashCode());
Console.WriteLine(y.GetHashCode());

