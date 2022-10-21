String s1 = "something";
String s2 = "something";


Console.WriteLine(Object.ReferenceEquals(s1, s2));

// THis is supposed to be 'false' but we're on a later version of C# that ignores it

s1 = String.Intern(s1);
s2 = String.Intern(s2);

Console.WriteLine(Object.ReferenceEquals(s1, s2));
