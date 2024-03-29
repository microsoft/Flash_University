﻿char f;
int i;

// casting
f = (char)97;

Console.WriteLine(f);

// what will this print, which conversion mechanism did we use?
i = f;
Console.WriteLine(i);

// Jeffrey unicode flex
var b = unchecked((char)(65536 + 98));
Console.WriteLine(b);

b = Convert.ToChar(97);
Console.WriteLine(b);

// Convert's max range

try
{
    f = Convert.ToChar(8790234750942387588);
    Console.WriteLine(f);
}
catch (OverflowException)
{
    Console.WriteLine("Too big");
}

var c = ((IConvertible)100).ToChar(null);
Console.WriteLine(c);


var k = ((IConvertible)c).ToInt32(null);
Console.WriteLine(k);