var one = "one";
var two = "two";
var three = "three";

Console.WriteLine(one + two + three);

TripleSwap(ref one, ref two, ref three);

Console.WriteLine(one + two + three);

var yi = 1;
var ar = 2;
var san = 3;


Console.WriteLine(yi + " " + ar + " " + san);
TripleSwap(ref yi, ref ar, ref san);
Console.WriteLine(yi + " " + ar + " " + san);

//quick why are we using ref (pass by REFerence)
static void TripleSwap<T>(ref T o1, ref T o2, ref T o3)
{
    var temp = o1;
    o1 = o2;
    o2 = o3;
    o3 = temp;
}