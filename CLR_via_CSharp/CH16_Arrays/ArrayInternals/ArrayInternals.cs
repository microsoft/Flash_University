// Again, example from the book

Array a;


a = new string[0];
Console.WriteLine(a.GetType());

a = Array.CreateInstance(typeof(string), new[] { 0 }, new[] { 0 });
Console.WriteLine(a.GetType());


a = Array.CreateInstance(typeof(string), new[] { 0 }, new[] { 1 });
Console.WriteLine(a.GetType());
Console.WriteLine();


a = new string[0, 0];
Console.WriteLine(a.GetType());


a = Array.CreateInstance(typeof(string), new[] { 0, 0 }, new[] { 0, 0 });
Console.WriteLine(a.GetType());


a = Array.CreateInstance(typeof(string), new[] { 0, 0 }, new[] { 1, 1 });
Console.WriteLine(a.GetType());

var c = new int[5];
for (var i = 0; i < c.Length; i++) c[i] = i;