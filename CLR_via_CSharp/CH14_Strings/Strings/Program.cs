// This program is just showing the basics

var min = char.MinValue;
var max = char.MaxValue;

Console.WriteLine(min);
Console.WriteLine(max);


int i_a = min;
int i_b = max;

Console.WriteLine(i_a);

Console.WriteLine(i_b);

var a = 'a';
Console.WriteLine(a);
Console.WriteLine((int)a);

//  this is hexadecimal or unicode?
// let's find it on the internet
var d = char.GetNumericValue('\u00bc');
Console.WriteLine(d);
