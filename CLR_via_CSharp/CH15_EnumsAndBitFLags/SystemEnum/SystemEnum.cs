Console.WriteLine(Enum.GetUnderlyingType(typeof(Musketeers)));

var t = typeof(Musketeers);
Console.WriteLine(t);


Console.WriteLine(0x00);
Console.WriteLine(0x00);
Console.WriteLine(0x00);

Console.WriteLine(Enum.GetUnderlyingType(typeof(UnoCards)));

Console.WriteLine(Enum.GetUnderlyingType(typeof(BadCards)));

internal enum Musketeers
{
    Athos,
    Porthos,
    Aramis,
    dArtagnan
}


internal enum UnoCards : byte
{
    Zero,
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Reverse,
    Skip,
    Wild,
    DrawTwo,
    DrawFour
}


internal enum BadCards : sbyte
{
    Zero,
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Reverse,
    Skip,
    Wild,
    DrawTwo,
    DrawFour
}