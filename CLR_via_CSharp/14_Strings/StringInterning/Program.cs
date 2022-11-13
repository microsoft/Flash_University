using System.Runtime.CompilerServices;

[assembly: CompilationRelaxations(CompilationRelaxations.NoStringInterning)]
var s1 = "something";
var s2 = "something";

// This is supposed to be 'false' but we're on a later version of C# that ignores it, string interning is still happening as the attribute is not mandatory
Console.WriteLine(ReferenceEquals(s1, s2));


s1 = string.Intern(s1);
s2 = string.Intern(s2);

Console.WriteLine(ReferenceEquals(s1, s2));

//if you have multiple strings of the same vluae