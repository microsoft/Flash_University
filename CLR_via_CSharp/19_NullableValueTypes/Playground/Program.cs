int? x = 5;
int? y = 6;

Console.WriteLine(x.Equals(y));
x = null;
Console.WriteLine(x.Equals(y));