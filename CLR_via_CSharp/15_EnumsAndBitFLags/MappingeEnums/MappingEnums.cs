var c = Color.Red;
Console.WriteLine(c);
Console.WriteLine(c.ToString());

//this is some formatting fun -- things to keep from last time, general, decimal,hex

Console.WriteLine(c.ToString("D"));
Console.WriteLine(c.ToString("X"));
//The operators on the enum applies to the _instance field
Console.WriteLine(Color.Blue != Color.Red);

internal enum Color : byte
{
    Red,
    Orange,
    Yellow,
    Green,
    Blue,
    Indigo,
    Violet
}