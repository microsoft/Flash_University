int? a = 42;
int? b = null;

//nullable to regular, explicit
var c = (int) a;

Console.WriteLine(c);

var one = 1;
var two = 2;
int? three = 3;
int? four = 4;

Console.WriteLine(one + two);

Console.WriteLine(three + four);

Console.WriteLine(one + two + three + four);