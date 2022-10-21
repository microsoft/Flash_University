Char f;
int i;
f = (Char)97;

Console.WriteLine(f);


//what will this print, which conversion mechanism did we use?
i = (int)f;
Console.WriteLine(i);

//Jeffrey unicode flex
Char b = unchecked((Char)(65536+98));
Console.WriteLine(b);

b=Convert.ToChar(97);
Console.WriteLine(b);

// Convert's max range

try
{
    f = Convert.ToChar(87902347509423875);
    Console.WriteLine(f);
}
catch (OverflowException)
{
    Console.WriteLine("Too big");
}

Char c= ((IConvertible)100).ToChar(null);
Console.WriteLine(c);


var k = ((IConvertible)c).ToInt32(null);
Console.WriteLine(k);