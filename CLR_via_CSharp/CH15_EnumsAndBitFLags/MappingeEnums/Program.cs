Color c = Color.Red;
Console.WriteLine(c);
Console.WriteLine(c.ToString());

//this is some formatting fun -- things to keep from last time, general, decimal,hex

Console.WriteLine(c.ToString("G"));
Console.WriteLine(c.ToString("D"));
Console.WriteLine(c.ToString("X"));
enum Color: byte
{
    Red,Orange, Yellow,Green,Blue,Indigo,Violet
}